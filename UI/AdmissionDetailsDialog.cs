using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing; // NEW: Required for printing
using System.Windows.Forms;
using BusinessLogic.Controller;
using BusinessLogic.Repository; // NEW: Required for UserRepository
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

		// NEW: Track who is printing the receipt
		private readonly string _username;

		// Pass the admission to display, and the current user's username
		public AdmissionDetailsDialog(Admission admission, string username = "")
		{
			InitializeComponent();
			_admission = admission;
			_username = username;
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
					h.Rate.ToString("N2") + " ₱",
					h.StartDate.ToString("MM/dd/yyyy hh:mm tt"),
					to
				);
			}

			// ---- BILLING ----
			Bill bill = billController.GetBill(_admission.AdmissionCode);

			if (bill != null)
			{
				// A bill exists (either Draft or Paid)
				lblRoomChargesValue.Text = bill.RoomCharges.ToString("N2") + " ₱";
				lblTreatmentValue.Text = bill.TreatmentCharges.ToString("N2") + " ₱";

				if (bill.DiscountComputed > 0)
				{
					lblDiscountValue.Text = "-" + bill.DiscountComputed.ToString("N2") + " ₱" + " (" + bill.DiscountReason + ")";
				}
				else
				{
					lblDiscountValue.Text = "0.00 ₱";
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

				lblRoomChargesValue.Text = roomCharges.ToString("N2") + " ₱";
				lblTreatmentValue.Text = treatmentCharges.ToString("N2") + " ₱";
				lblDiscountValue.Text = "—";
				lblTotalValue.Text = total.ToString("N2") + " ₱";
				lblPaymentStatusValue.Text = "Not Billed";
				lblPaymentStatusValue.ForeColor = Color.Gray;
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// =============================================================
		// PRINT
		// =============================================================
		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (_admission == null) return;

			// Fetch the logged-in user's Full Name and Role
			string admittedBy = _username; // Fallback to username
			try
			{
				if (!string.IsNullOrEmpty(_username))
				{
					var userRepo = new BusinessLogic.Repository.UserRepository();
					var currentUser = userRepo.GetUserByUsername(_username);
					if (currentUser != null)
					{
						// Combine Full Name and Role (e.g., "Lebron James (Admin)")
						admittedBy = currentUser.FullName + " (" + currentUser.Role + ")";
					}
				}
				else
				{
					admittedBy = "System / Unknown";
				}
			}
			catch { /* Ignore DB errors during print */ }

			PrintDocument pd = new PrintDocument();
			pd.PrintPage += (s, args) =>
			{
				Font titleFont = new Font("Arial", 16, FontStyle.Bold);
				Font headerFont = new Font("Arial", 12, FontStyle.Bold);
				Font normalFont = new Font("Arial", 10, FontStyle.Regular);

				float y = 50;
				float x = 50;

				args.Graphics.DrawString("Hospital Admission System", titleFont, Brushes.Black, x, y);
				y += 30;
				args.Graphics.DrawString("Admission Receipt", headerFont, Brushes.Black, x, y);
				y += 40;

				args.Graphics.DrawString("Admission Code: " + _admission.AdmissionCode, normalFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("Patient: " + lblPatientValue.Text, normalFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("Admission Date: " + _admission.AdmissionDate.ToString("MM/dd/yyyy hh:mm tt"), normalFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("Status: " + _admission.Status, normalFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("Attending Doctor: " + lblDoctorValue.Text, normalFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("Assigned Nurse: " + lblNurseValue.Text, normalFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("Diagnosis: " + lblDiagnosisValue.Text, normalFont, Brushes.Black, x, y);
				y += 40;

				args.Graphics.DrawString("--- BILLING SUMMARY ---", headerFont, Brushes.Black, x, y);
				y += 25;
				args.Graphics.DrawString("Room Charges: " + lblRoomChargesValue.Text, normalFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("Treatment Charges: " + lblTreatmentValue.Text, normalFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("Discount: " + lblDiscountValue.Text, normalFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("Total Due: " + lblTotalValue.Text, headerFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("Payment Status: " + lblPaymentStatusValue.Text, normalFont, Brushes.Black, x, y);
				y += 40;

				// UPDATED: Now shows "Admitted By: Name (Role)"
				args.Graphics.DrawString("Admitted By: " + admittedBy, headerFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("Date Printed: " + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"), normalFont, Brushes.Black, x, y);
			};

			// Show the print preview dialog
			PrintPreviewDialog preview = new PrintPreviewDialog();
			preview.Document = pd;
			preview.ShowDialog();
		}
	}
}