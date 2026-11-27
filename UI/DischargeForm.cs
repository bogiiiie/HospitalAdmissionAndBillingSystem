using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing; // Required for printing
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class DischargeForm : Form
	{
		private readonly AdmissionController admissionController = new AdmissionController();
		private readonly BillController billController = new BillController();
		private readonly LoginPage _loginPage;
		private readonly string _username;
		private readonly string _role;

		private string _selectedAdmissionCode;
		private Bill _currentBill = null;

		public DischargeForm(LoginPage loginPage, string username, string role)
		{
			InitializeComponent();
			_loginPage = loginPage;
			_username = username;
			_role = role;
		}

		private void DischargeForm_Load(object sender, EventArgs e)
		{
			lblUserInfo.Text = "Logged in as: " + _username + "   |   Role: " + _role;

			WireSidebarEvents();
			ApplyRoleToSidebar();
			SetAdmissionState(false);
		}

		private void SetAdmissionState(bool hasAdmission)
		{
			lblNoResults.Visible = !hasAdmission;
			dtpDischargeDate.Visible = hasAdmission;
			lblDate.Visible = hasAdmission;
			txtNotes.Visible = hasAdmission;
			lblNotes.Visible = hasAdmission;
			lblBillingStatus.Visible = hasAdmission;
			btnConfirmDischarge.Visible = hasAdmission;

			if (!hasAdmission)
			{
				_selectedAdmissionCode = null;
				txtSelectedAdmission.Text = "";
				_currentBill = null;
				chkAdminOverride.Visible = false;
				chkAdminOverride.Checked = false;
				panelOverride.Visible = false;
			}
		}

		private void btnFindAdmission_Click(object sender, EventArgs e)
		{
			AdmissionPickerDialog picker = new AdmissionPickerDialog();
			if (picker.ShowDialog(this) == DialogResult.OK)
			{
				_selectedAdmissionCode = picker.SelectedAdmissionCode;
				txtSelectedAdmission.Text = picker.SelectedDisplayText;
				LoadDischargeData();
			}
		}

		private void LoadDischargeData()
		{
			SetAdmissionState(true);
			dtpDischargeDate.Value = DateTime.Now;

			// Reset override UI on new search
			chkAdminOverride.Visible = false;
			chkAdminOverride.Checked = false;
			panelOverride.Visible = false;

			// Check Billing Status
			_currentBill = billController.GetBill(_selectedAdmissionCode);

			if (_currentBill != null && _currentBill.Balance <= 0)
			{
				// Fully Paid
				lblBillingStatus.Text = "Billing Status: PAID";
				lblBillingStatus.ForeColor = Color.Green;
				btnConfirmDischarge.Enabled = true;
			}
			else if (_currentBill != null && _currentBill.Balance > 0)
			{
				// Partially Paid
				lblBillingStatus.Text = $"Billing Status: PARTIALLY PAID (Balance: {_currentBill.Balance:N2} ₱)";
				lblBillingStatus.ForeColor = Color.Orange;

				if (_role == "Admin")
				{
					// Admin can override
					btnConfirmDischarge.Enabled = false; // Disabled until they check the override box
					chkAdminOverride.Visible = true;
				}
				else
				{
					// Staff is blocked
					lblBillingStatus.Text = $"Billing Status: OUTSTANDING BALANCE ({_currentBill.Balance:N2} ₱). Ask Admin to override.";
					lblBillingStatus.ForeColor = Color.Red;
					btnConfirmDischarge.Enabled = false;
				}
			}
			else
			{
				// No bill generated
				lblBillingStatus.Text = "Billing Status: NO BILL GENERATED";
				lblBillingStatus.ForeColor = Color.Red;
				btnConfirmDischarge.Enabled = false;
			}
		}

		// =============================================================
		// ADMIN OVERRIDE LOGIC
		// =============================================================
		private void chkAdminOverride_CheckedChanged(object sender, EventArgs e)
		{
			if (chkAdminOverride.Checked)
			{
				// Show the Promissory Note panel
				panelOverride.Visible = true;
				btnConfirmDischarge.Enabled = true;

				// Default to None so they can pick
				cmbFrequency.SelectedIndex = 0;
			}
			else
			{
				// Hide and disable
				panelOverride.Visible = false;
				btnConfirmDischarge.Enabled = false;
			}
		}

		// Auto-calculate Follow-up Date based on Frequency
		private void cmbFrequency_SelectedIndexChanged(object sender, EventArgs e)
		{
			string freq = cmbFrequency.SelectedItem.ToString();

			if (freq == "Weekly")
			{
				dtpFollowUpDate.Value = DateTime.Now.AddDays(7);
			}
			else if (freq == "Monthly")
			{
				dtpFollowUpDate.Value = DateTime.Now.AddMonths(1);
			}
			else
			{
				dtpFollowUpDate.Value = DateTime.Now; // Default to today
			}
		}

		private void btnConfirmDischarge_Click(object sender, EventArgs e)
		{
			// Validation for Admin Override
			if (_currentBill != null && _currentBill.Balance > 0 && chkAdminOverride.Checked)
			{
				if (cmbFrequency.SelectedIndex == 0) // "None" is selected
				{
					MessageBox.Show("Please select a payment frequency (Weekly/Monthly) for the Promissory Note.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}

			DialogResult choice = MessageBox.Show(
				"Are you sure you want to discharge this patient?\n\n" +
				"This will mark the admission as discharged and free up the room.",
				"Confirm Discharge",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (choice == DialogResult.Yes)
			{
				// Auto-generate Promissory Note script
				string generatedReason = null;
				string frequency = null;
				DateTime? followUpDate = null;

				if (chkAdminOverride.Checked && _currentBill != null)
				{
					frequency = cmbFrequency.Text;
					followUpDate = dtpFollowUpDate.Value;
					generatedReason = $"Promissory Note: Patient has an outstanding balance of {_currentBill.Balance:N2} ₱ to be paid on a {frequency} basis, with the next follow-up scheduled on {followUpDate.Value:MM/dd/yyyy}.";
				}

				// Make sure these variables are calculated just above this call
				string instType = cmbInstallmentType.Text;
				decimal instVal = 0;
				decimal.TryParse(txtInstallmentValue.Text, out instVal);

				string result = admissionController.DischargePatient(
					_selectedAdmissionCode,
					dtpDischargeDate.Value,
					txtNotes.Text.Trim(),
					chkAdminOverride.Checked,
					generatedReason,
					frequency,
					followUpDate,
					instType,    // NEW PARAMETER
					instVal      // NEW PARAMETER
				);

				if (result == "OK")
				{
					MessageBox.Show(
						"Patient discharged successfully.\n\nThe room is now available.",
						"Success",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);

					// Auto-open the Summary Form
					DischargeSummaryForm summary = new DischargeSummaryForm(_loginPage, _username, _role, _selectedAdmissionCode);
					summary.Show();
					this.Close();
				}
				else
				{
					MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		// =============================================================
		// PRINT PROMISSORY NOTE
		// =============================================================
		private void btnPrintPromissory_Click(object sender, EventArgs e)
		{
			if (_currentBill == null) return;

			string patientName = "Unknown";
			try
			{
				var adm = admissionController.GetAdmissionByCode(_selectedAdmissionCode);
				if (adm != null)
				{
					var pRepo = new BusinessLogic.Repository.PatientRepository();
					var p = pRepo.GetPatientByCode(adm.PatientCode);
					if (p != null) patientName = p.FullName;
				}
			}
			catch { }

			// Calculate the installment amount based on user input
			decimal instValue = 0;
			decimal.TryParse(txtInstallmentValue.Text, out instValue);
			decimal installmentAmount = 0;

			if (cmbInstallmentType.Text == "Percentage")
			{
				installmentAmount = _currentBill.Balance * (instValue / 100m);
			}
			else if (cmbInstallmentType.Text == "Fixed")
			{
				installmentAmount = instValue;
			}

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
				args.Graphics.DrawString("Promissory Note / Balance Receipt", headerFont, Brushes.Black, x, y);
				y += 40;

				args.Graphics.DrawString("Date Generated: " + DateTime.Now.ToString("MM/dd/yyyy"), normalFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("Patient Name: " + patientName, normalFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("Admission Code: " + _selectedAdmissionCode, normalFont, Brushes.Black, x, y);
				y += 40;

				args.Graphics.DrawString("--- FINANCIAL DETAILS ---", headerFont, Brushes.Black, x, y);
				y += 25;
				args.Graphics.DrawString("Total Bill: " + _currentBill.TotalDue.ToString("N2") + " ₱", normalFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("Amount Paid (Downpayment): " + _currentBill.AmountPaid.ToString("N2") + " ₱", normalFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("REMAINING BALANCE: " + _currentBill.Balance.ToString("N2") + " ₱", headerFont, Brushes.Black, x, y);
				y += 40;

				args.Graphics.DrawString("--- PAYMENT TERMS ---", headerFont, Brushes.Black, x, y);
				y += 25;
				args.Graphics.DrawString("This is to certify that the patient/guardian agrees to pay the remaining", normalFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("balance on a " + cmbFrequency.Text.ToUpper() + " basis.", normalFont, Brushes.Black, x, y);
				y += 20;

				// NEW: Print the calculated installment amount
				args.Graphics.DrawString($"Installment Amount: {installmentAmount:N2} ₱ per {cmbFrequency.Text}", headerFont, Brushes.Black, x, y);
				y += 20;

				args.Graphics.DrawString("Next Follow-up Date: " + dtpFollowUpDate.Value.ToString("MM/dd/yyyy"), normalFont, Brushes.Black, x, y);
				y += 40;

				args.Graphics.DrawString("By signing below, the patient/guardian acknowledges the outstanding balance", normalFont, Brushes.Black, x, y);
				y += 20;
				args.Graphics.DrawString("and agrees to the payment schedule.", normalFont, Brushes.Black, x, y);
				y += 60;

				args.Graphics.DrawString("_____________________________          _____________________________", normalFont, Brushes.Black, x, y);
				y += 20;
				// Draw the labels separately to perfectly align the Admin Signature under the second line
				args.Graphics.DrawString("Patient / Guardian Signature", normalFont, Brushes.Black, x, y);
				args.Graphics.DrawString("Admin Signature", normalFont, Brushes.Black, x + 280, y);
			};

			PrintPreviewDialog preview = new PrintPreviewDialog();
			preview.Document = pd;
			preview.ShowDialog();
		}

		// =============================================================
		// SIDEBAR
		// =============================================================
		private void WireSidebarEvents()
		{
			btnNavDischarge.Click += (s, e) => { };
			btnNavRoom.Click += (s, e) => { new RoomManagementForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavPatient.Click += (s, e) => { new PatientInformationForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavPatientSearch.Click += (s, e) => { new PatientInfoSearchForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavRoomSearch.Click += (s, e) => { new PatientRoomSearchForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavAdmission.Click += (s, e) => { new AdmissionForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavAdmissionLog.Click += (s, e) => { new AdmissionLogForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavTreatment.Click += (s, e) => { new TreatmentBillingForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavDoctorNurse.Click += (s, e) => { new DoctorNurseAssignmentForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavBilling.Click += (s, e) => { new BillingForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavSummary.Click += (s, e) =>
			{
				DischargeSummaryForm form = new DischargeSummaryForm(_loginPage, _username, _role);
				form.Show();
				this.Close();
			};
		}

		private void ApplyRoleToSidebar()
		{
			var visibleButtons = new List<Button>
			{
				btnNavRoom, btnNavPatient, btnNavPatientSearch, btnNavRoomSearch,
				btnNavAdmission, btnNavAdmissionLog, btnNavTreatment, btnNavBilling,
				btnNavDischarge, btnNavSummary
			};

			if (_role == "Admin")
			{
				visibleButtons.Insert(7, btnNavDoctorNurse);
			}

			btnNavRoom.Visible = false; btnNavPatient.Visible = false; btnNavPatientSearch.Visible = false;
			btnNavRoomSearch.Visible = false; btnNavAdmission.Visible = false; btnNavAdmissionLog.Visible = false;
			btnNavTreatment.Visible = false; btnNavDoctorNurse.Visible = false; btnNavBilling.Visible = false;
			btnNavDischarge.Visible = false; btnNavSummary.Visible = false;

			int y = 48;
			foreach (var btn in visibleButtons)
			{
				btn.Visible = true;
				btn.Top = y;
				y += 44;
			}
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