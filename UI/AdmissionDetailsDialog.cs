using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class AdmissionDetailsDialog : Form
	{
		private readonly AdmissionController admissionController = new AdmissionController();
		private readonly PatientController patientController = new PatientController();
		private readonly TreatmentController treatmentController = new TreatmentController();
		private readonly BillController billController = new BillController(); // Added
		private readonly Admission _admission;

		// Pass the admission to display
		public AdmissionDetailsDialog(Admission admission)
		{
			InitializeComponent();
			_admission = admission;
		}

		private void AdmissionDetailsDialog_Load(object sender, EventArgs e)
		{
			if (_admission == null)
			{
				MessageBox.Show("Admission not found.", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.Close();
				return;
			}

			// Uniform grid font across all rows
			dgvHistory.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvHistory.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvHistory.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvHistory.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

			lblHeader.Text = "Admission Details — " + _admission.AdmissionCode;

			// ---- PATIENT ----
			Patient p = patientController.GetPatientByCode(_admission.PatientCode);
			string patientName = p != null ? p.FullName : "(unknown)";
			lblPatientValue.Text = _admission.PatientCode + " — " + patientName;

			// ---- ADMISSION ----
			lblCodeValue.Text = _admission.AdmissionCode;
			lblDateValue.Text = _admission.AdmissionDate.ToString("MM/dd/yyyy hh:mm tt");
			lblStatusValue.Text = _admission.Status;
			lblByValue.Text = _admission.AdmittedBy;
			lblDiagnosisValue.Text = string.IsNullOrWhiteSpace(_admission.Diagnosis)
				? "—"
				: _admission.Diagnosis;

			// ---- ASSIGNED STAFF ----
			lblDoctorValue.Text = string.IsNullOrWhiteSpace(_admission.AttendingDoctor)
				? "—"
				: _admission.AttendingDoctor;
			lblNurseValue.Text = string.IsNullOrWhiteSpace(_admission.AssignedNurse)
				? "—"
				: _admission.AssignedNurse;

			// ---- ROOM HISTORY ----
			List<AdmissionRoomHistory> history = admissionController.GetRoomHistory(_admission.AdmissionCode);
			dgvHistory.Rows.Clear();

			foreach (AdmissionRoomHistory h in history)
			{
				string to = h.EndDate.HasValue
					? h.EndDate.Value.ToString("MM/dd/yyyy hh:mm tt")
					: "(current)";

				dgvHistory.Rows.Add(
					h.RoomNumber,
					h.RoomType,
					"₱" + h.Rate.ToString("N2"),
					h.StartDate.ToString("MM/dd/yyyy hh:mm tt"),
					to
				);
			}

			// ---- BILLING ----
			Bill bill = billController.GetBill(_admission.AdmissionCode);

			if (bill != null)
			{
				// A bill exists (either Draft or Paid)
				lblRoomChargesValue.Text = "₱" + bill.RoomCharges.ToString("N2");
				lblTreatmentValue.Text = "₱" + bill.TreatmentCharges.ToString("N2");

				if (bill.DiscountComputed > 0)
				{
					lblDiscountValue.Text = "- ₱" + bill.DiscountComputed.ToString("N2") + " (" + bill.DiscountReason + ")";
				}
				else
				{
					lblDiscountValue.Text = "₱0.00";
				}

				lblTotalValue.Text = "₱" + bill.TotalDue.ToString("N2");

				// Show the status
				lblPaymentStatusValue.Text = bill.Status.ToUpper();
				if (bill.Status == "Paid")
					lblPaymentStatusValue.ForeColor = Color.Green;
				else
					lblPaymentStatusValue.ForeColor = Color.Orange;
			}
			else
			{
				// No bill generated yet — calculate the base charges on the fly
				decimal roomCharges = admissionController.CalculateRoomCharges(_admission.AdmissionCode, DateTime.Now);
				decimal treatmentCharges = treatmentController.CalculateSubtotal(_admission.AdmissionCode);
				decimal total = roomCharges + treatmentCharges;

				lblRoomChargesValue.Text = "₱" + roomCharges.ToString("N2");
				lblTreatmentValue.Text = "₱" + treatmentCharges.ToString("N2");
				lblDiscountValue.Text = "—";
				lblTotalValue.Text = "₱" + total.ToString("N2");
				lblPaymentStatusValue.Text = "Not Billed";
				lblPaymentStatusValue.ForeColor = Color.Gray;
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}