using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class DischargeSummaryForm : Form
	{
		private readonly AdmissionController admissionController = new AdmissionController();
		private readonly PatientController patientController = new PatientController();
		private readonly TreatmentController treatmentController = new TreatmentController();
		private readonly BillController billController = new BillController();
		private readonly LoginPage _loginPage;
		private readonly string _username;
		private readonly string _role;

		private string _selectedAdmissionCode;
		private Admission _admission;
		private Patient _patient;
		private List<Treatment> _treatments;
		private Bill _bill;

		// Used by the picker to pass the selected admission directly
		public DischargeSummaryForm(LoginPage loginPage, string username, string role, string preselectedAdmissionCode = null)
		{
			InitializeComponent();
			_loginPage = loginPage;
			_username = username;
			_role = role;
			_selectedAdmissionCode = preselectedAdmissionCode;
		}

		private void DischargeSummaryForm_Load(object sender, EventArgs e)
		{
			WireSidebarEvents();
			ApplyRoleToSidebar();

			// ALWAYS show the panel so the user can see the Find button
			panelBody.Visible = true;

			if (!string.IsNullOrEmpty(_selectedAdmissionCode))
			{
				// Patient was passed from the Discharge Form
				LoadSummaryData();
			}
			else
			{
				// Opened from sidebar — show empty state, ready for a search
				ClearSummaryData();
			}
		}

		private void ClearSummaryData()
		{
			txtPatient.Text = "";
			lblName.Text = "Name: —";
			lblPatientId.Text = "Patient ID: —";
			lblGender.Text = "Gender: —";
			lblDob.Text = "DOB: —";
			lblContact.Text = "Contact: —";
			lblAddress.Text = "Address: —";

			lblAdmissionCode.Text = "Admission Code: —";
			lblRoom.Text = "Room: —";
			lblAdmitDate.Text = "Admitted: —";
			lblDischargeDate.Text = "Discharged: —";
			lblDiagnosis.Text = "Diagnosis: —";
			lblDoctor.Text = "Doctor: —";
			lblNurse.Text = "Nurse: —";
			lblNotes.Text = "Notes: —";

			dgvTreatments.Rows.Clear();

			lblRoomCharges.Text = "Room Charges: —";
			lblTreatmentCharges.Text = "Treatment Charges: —";
			lblDiscount.Text = "Discount: —";
			lblTotalPaid.Text = "TOTAL PAID: —";
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			DischargedPatientPickerDialog picker = new DischargedPatientPickerDialog();
			if (picker.ShowDialog(this) == DialogResult.OK)
			{
				_selectedAdmissionCode = picker.SelectedAdmissionCode;
				txtPatient.Text = picker.SelectedDisplayText;
				LoadSummaryData();
			}
		}

		private void LoadSummaryData()
		{
			_admission = admissionController.GetAdmissionByCode(_selectedAdmissionCode);
			if (_admission == null || _admission.Status != "Discharged")
			{
				MessageBox.Show("Invalid or active admission. This form is only for discharged patients.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			_patient = patientController.GetPatientByCode(_admission.PatientCode);
			_treatments = treatmentController.GetTreatments(_admission.AdmissionCode);
			_bill = billController.GetBill(_admission.AdmissionCode);

			// Fill UI
			lblName.Text = "Name: " + (_patient != null ? _patient.FullName : "—");
			lblPatientId.Text = "Patient ID: " + _admission.PatientCode;
			lblGender.Text = "Gender: " + (_patient != null ? _patient.Gender : "—");
			lblDob.Text = "DOB: " + (_patient != null ? _patient.DateOfBirth.ToString("MM/dd/yyyy") : "—");
			lblContact.Text = "Contact: " + (_patient != null ? _patient.ContactNumber : "—");
			lblAddress.Text = "Address: " + (_patient != null ? _patient.Address : "—");

			lblAdmissionCode.Text = "Admission Code: " + _admission.AdmissionCode;
			lblRoom.Text = "Room: " + _admission.RoomNumber;
			lblAdmitDate.Text = "Admitted: " + _admission.AdmissionDate.ToString("MM/dd/yyyy hh:mm tt");
			lblDischargeDate.Text = "Discharged: " + (_admission.DischargeDate?.ToString("MM/dd/yyyy hh:mm tt") ?? "—");
			lblDiagnosis.Text = "Diagnosis: " + _admission.Diagnosis;
			lblDoctor.Text = "Doctor: " + (string.IsNullOrWhiteSpace(_admission.AttendingDoctor) ? "—" : _admission.AttendingDoctor);
			lblNurse.Text = "Nurse: " + (string.IsNullOrWhiteSpace(_admission.AssignedNurse) ? "—" : _admission.AssignedNurse);
			lblNotes.Text = "Notes: " + (string.IsNullOrWhiteSpace(_admission.DischargeNotes) ? "—" : _admission.DischargeNotes);

			dgvTreatments.Rows.Clear();
			foreach (Treatment t in _treatments)
			{
				dgvTreatments.Rows.Add(t.ServiceName, t.TreatmentDate.ToString("MM/dd/yyyy"), t.Quantity, "₱" + t.UnitCost.ToString("N2"), "₱" + t.TotalCost.ToString("N2"));
			}

			if (_bill != null)
			{
				lblRoomCharges.Text = "Room Charges: ₱" + _bill.RoomCharges.ToString("N2");
				lblTreatmentCharges.Text = "Treatment Charges: ₱" + _bill.TreatmentCharges.ToString("N2");
				lblDiscount.Text = "Discount: -₱" + _bill.DiscountComputed.ToString("N2") + " (" + _bill.DiscountReason + ")";
				lblTotalPaid.Text = "TOTAL PAID: ₱" + _bill.TotalDue.ToString("N2");
			}
			else
			{
				lblRoomCharges.Text = "Room Charges: —";
				lblTreatmentCharges.Text = "Treatment Charges: —";
				lblDiscount.Text = "Discount: —";
				lblTotalPaid.Text = "TOTAL PAID: —";
			}

			panelBody.Visible = true;
		}

		// =============================================================
		// PRINT LOGIC
		// =============================================================
		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (_admission == null) return;

			PrintDocument pd = new PrintDocument();
			pd.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

			PrintPreviewDialog preview = new PrintPreviewDialog();
			preview.Document = pd;
			preview.Width = 1000;
			preview.Height = 800;
			preview.ShowDialog();
		}

		private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
		{
			Graphics g = e.Graphics;
			Font fontTitle = new Font("Arial", 16, FontStyle.Bold);
			Font fontHeader = new Font("Arial", 12, FontStyle.Bold);
			Font fontNormal = new Font("Arial", 10, FontStyle.Regular);
			Font fontBold = new Font("Arial", 10, FontStyle.Bold);
			Brush brush = Brushes.Black;

			int y = 50;
			int leftMargin = 50;
			int rightMargin = e.PageBounds.Width - 50;

			// Header
			g.DrawString("HOSPITAL ADMISSION SYSTEM", fontTitle, brush, leftMargin, y);
			y += 25;
			g.DrawString("Official Discharge Summary Report", fontHeader, brush, leftMargin, y);
			y += 30;

			g.DrawLine(Pens.Black, leftMargin, y, rightMargin, y);
			y += 20;

			// Patient Info
			g.DrawString("PATIENT INFORMATION", fontHeader, brush, leftMargin, y); y += 20;
			g.DrawString("Name: " + (_patient?.FullName ?? "—"), fontNormal, brush, leftMargin, y);
			g.DrawString("Patient ID: " + _admission.PatientCode, fontNormal, brush, 400, y); y += 20;
			g.DrawString("Date of Birth: " + (_patient?.DateOfBirth.ToString("MM/dd/yyyy") ?? "—"), fontNormal, brush, leftMargin, y);
			g.DrawString("Gender: " + (_patient?.Gender ?? "—"), fontNormal, brush, 400, y); y += 30;

			// Stay Details
			g.DrawString("STAY DETAILS", fontHeader, brush, leftMargin, y); y += 20;
			g.DrawString("Admission Code: " + _admission.AdmissionCode, fontNormal, brush, leftMargin, y);
			g.DrawString("Room: " + _admission.RoomNumber, fontNormal, brush, 400, y); y += 20;
			g.DrawString("Admitted: " + _admission.AdmissionDate.ToString("MM/dd/yyyy hh:mm tt"), fontNormal, brush, leftMargin, y);
			g.DrawString("Discharged: " + (_admission.DischargeDate?.ToString("MM/dd/yyyy hh:mm tt") ?? "—"), fontNormal, brush, 400, y); y += 20;
			g.DrawString("Doctor: " + (_admission.AttendingDoctor ?? "—"), fontNormal, brush, leftMargin, y);
			g.DrawString("Nurse: " + (_admission.AssignedNurse ?? "—"), fontNormal, brush, 400, y); y += 20;
			g.DrawString("Diagnosis: " + _admission.Diagnosis, fontNormal, brush, leftMargin, y); y += 20;
			g.DrawString("Notes: " + (_admission.DischargeNotes ?? "—"), fontNormal, brush, leftMargin, y); y += 30;

			// Treatments
			g.DrawString("TREATMENTS & SERVICES", fontHeader, brush, leftMargin, y); y += 20;
			g.DrawString("Date", fontBold, brush, leftMargin, y);
			g.DrawString("Service", fontBold, brush, leftMargin + 100, y);
			g.DrawString("Qty", fontBold, brush, leftMargin + 350, y);
			g.DrawString("Unit Cost", fontBold, brush, leftMargin + 420, y);
			g.DrawString("Total Cost", fontBold, brush, leftMargin + 550, y);
			y += 20;
			g.DrawLine(Pens.Black, leftMargin, y, rightMargin, y); y += 10;

			foreach (Treatment t in _treatments)
			{
				g.DrawString(t.TreatmentDate.ToString("MM/dd/yyyy"), fontNormal, brush, leftMargin, y);
				g.DrawString(t.ServiceName, fontNormal, brush, leftMargin + 100, y);
				g.DrawString(t.Quantity.ToString(), fontNormal, brush, leftMargin + 350, y);
				g.DrawString("₱" + t.UnitCost.ToString("N2"), fontNormal, brush, leftMargin + 420, y);
				g.DrawString("₱" + t.TotalCost.ToString("N2"), fontNormal, brush, leftMargin + 550, y);
				y += 20;
			}

			y += 10;
			g.DrawLine(Pens.Black, leftMargin, y, rightMargin, y); y += 20;

			// Billing
			g.DrawString("FINAL BILLING", fontHeader, brush, leftMargin, y); y += 20;
			g.DrawString("Room Charges:", fontNormal, brush, leftMargin, y);
			g.DrawString("₱" + _bill.RoomCharges.ToString("N2"), fontNormal, brush, leftMargin + 200, y); y += 20;
			g.DrawString("Treatment Charges:", fontNormal, brush, leftMargin, y);
			g.DrawString("₱" + _bill.TreatmentCharges.ToString("N2"), fontNormal, brush, leftMargin + 200, y); y += 20;
			g.DrawString("Discount:", fontNormal, brush, leftMargin, y);
			g.DrawString("-₱" + _bill.DiscountComputed.ToString("N2"), fontNormal, brush, leftMargin + 200, y); y += 20;
			g.DrawString("TOTAL PAID:", fontBold, brush, leftMargin, y);
			g.DrawString("₱" + _bill.TotalDue.ToString("N2"), fontBold, brush, leftMargin + 200, y);
		}

		// =============================================================
		// SIDEBAR
		// =============================================================
		private void WireSidebarEvents()
		{
			// Current module — do nothing
			btnNavSummary.Click += (s, e) => { };

			// Wire the rest of the buttons...
			btnNavRoom.Click += (s, e) => { new RoomManagementForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavPatient.Click += (s, e) => { new PatientInformationForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavPatientSearch.Click += (s, e) => { new PatientInfoSearchForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavRoomSearch.Click += (s, e) => { new PatientRoomSearchForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavAdmission.Click += (s, e) => { new AdmissionForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavAdmissionLog.Click += (s, e) => { new AdmissionLogForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavTreatment.Click += (s, e) => { new TreatmentBillingForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavDoctorNurse.Click += (s, e) => { new DoctorNurseAssignmentForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavBilling.Click += (s, e) => { new BillingForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavDischarge.Click += (s, e) => { new DischargeForm(_loginPage, _username, _role).Show(); this.Close(); };
		}

		private void ApplyRoleToSidebar()
		{
			var visibleButtons = new List<Button>
			{
				btnNavRoom, btnNavPatient, btnNavPatientSearch, btnNavRoomSearch,
				btnNavAdmission, btnNavAdmissionLog, btnNavTreatment, btnNavBilling,
				btnNavDischarge, btnNavSummary
			};

			if (_role == "Admin") { visibleButtons.Insert(7, btnNavDoctorNurse); }

			btnNavRoom.Visible = false; btnNavPatient.Visible = false; btnNavPatientSearch.Visible = false;
			btnNavRoomSearch.Visible = false; btnNavAdmission.Visible = false; btnNavAdmissionLog.Visible = false;
			btnNavTreatment.Visible = false; btnNavDoctorNurse.Visible = false; btnNavBilling.Visible = false;
			btnNavDischarge.Visible = false; btnNavSummary.Visible = false;

			int y = 48;
			foreach (var btn in visibleButtons) { btn.Visible = true; btn.Top = y; y += 44; }
		}

		private void btnMainMenu_Click(object sender, EventArgs e)
		{
			if (_role == "Admin") new AdminMenuForm(_loginPage, _username, _role).Show();
			else new HospitalStaffMenuForm(_loginPage, _username, _role).Show();
			this.Close();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (_loginPage != null) _loginPage.Show();
				this.Close();
			}
		}
	}
}