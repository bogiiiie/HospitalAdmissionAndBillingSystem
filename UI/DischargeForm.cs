using System;
using System.Collections.Generic;
using System.Drawing;
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

			// Check Billing Status
			Bill bill = billController.GetBill(_selectedAdmissionCode);
			if (bill != null && bill.Status == "Paid")
			{
				lblBillingStatus.Text = "Billing Status: PAID";
				lblBillingStatus.ForeColor = Color.Green;
				btnConfirmDischarge.Enabled = true;
			}
			else
			{
				lblBillingStatus.Text = "Billing Status: UNPAID";
				lblBillingStatus.ForeColor = Color.Red;
				btnConfirmDischarge.Enabled = false;
			}
		}

		private void btnConfirmDischarge_Click(object sender, EventArgs e)
		{
			DialogResult choice = MessageBox.Show(
				"Are you sure you want to discharge this patient?\n\n" +
				"This will mark the admission as discharged and free up the room.",
				"Confirm Discharge",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (choice == DialogResult.Yes)
			{
				string result = admissionController.DischargePatient(
					_selectedAdmissionCode,
					dtpDischargeDate.Value,
					txtNotes.Text.Trim()
				);

				if (result == "OK")
				{
					// Show success message
					MessageBox.Show(
						"Patient discharged successfully.\n\nThe room is now available.",
						"Success",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);

					// Auto-open the Summary Form
					DischargeSummaryForm summary = new DischargeSummaryForm(_loginPage, _username, _role, _selectedAdmissionCode);
					summary.Show();

					// Close the Discharge form (which removes the old placeholder message)
					this.Close();
				}
				else
				{
					MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
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