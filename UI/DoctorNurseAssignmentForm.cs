using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class DoctorNurseAssignmentForm : Form
	{
		private readonly StaffAssignmentController staffController = new StaffAssignmentController();
		private readonly AdmissionController admissionController = new AdmissionController();
		private readonly LoginPage _loginPage;
		private readonly string _username;
		private readonly string _role;

		private string _selectedAdmissionCode;

		public DoctorNurseAssignmentForm(LoginPage loginPage, string username, string role)
		{
			InitializeComponent();
			_loginPage = loginPage;
			_username = username;
			_role = role;
		}

		private void DoctorNurseAssignmentForm_Load(object sender, EventArgs e)
		{
			// Uniform fonts
			dgvHistory.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvHistory.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvHistory.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvHistory.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

			lblUserInfo.Text = "Logged in as: " + _username + "   |   Role: " + _role;

			WireSidebarEvents();
			ApplyRoleToSidebar();

			// Hide panels initially
			panelUpdate.Visible = false;
			lblHistoryTitle.Visible = false;
			dgvHistory.Visible = false;
			lblNoResults.Visible = true;
		}

		private void btnFindAdmission_Click(object sender, EventArgs e)
		{
			AdmissionPickerDialog picker = new AdmissionPickerDialog();
			if (picker.ShowDialog(this) == DialogResult.OK)
			{
				_selectedAdmissionCode = picker.SelectedAdmissionCode;
				txtSelectedAdmission.Text = picker.SelectedDisplayText;
				LoadAssignmentData();
			}
		}

		private void LoadAssignmentData()
		{
			if (string.IsNullOrEmpty(_selectedAdmissionCode)) return;

			Admission adm = admissionController.GetAdmissionByCode(_selectedAdmissionCode);
			if (adm != null)
			{
				lblCurrentDoctorValue.Text = string.IsNullOrEmpty(adm.AttendingDoctor) ? "None" : adm.AttendingDoctor;
				lblCurrentNurseValue.Text = string.IsNullOrWhiteSpace(adm.AssignedNurse) ? "None" : adm.AssignedNurse;
			}

			List<StaffAssignment> history = staffController.GetHistory(_selectedAdmissionCode);
			dgvHistory.Rows.Clear();

			foreach (StaffAssignment h in history)
			{
				dgvHistory.Rows.Add(
					h.AssignedDate.ToString("MM/dd/yyyy HH:mm"),
					h.Role,
					h.StaffName,
					h.Reason
				);
			}

			panelUpdate.Visible = true;
			lblHistoryTitle.Visible = true;
			dgvHistory.Visible = true;
			lblNoResults.Visible = false;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string result = staffController.UpdateAssignment(
				_selectedAdmissionCode,
				txtNewDoctor.Text.Trim(),
				txtNewNurse.Text.Trim(),
				txtReason.Text.Trim()
			);

			if (result == "OK")
			{
				MessageBox.Show("Assignment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtNewDoctor.Text = "";
				txtNewNurse.Text = "";
				txtReason.Text = "";
				LoadAssignmentData();
			}
			else
			{
				MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		// =============================================================
		// SIDEBAR
		// =============================================================
		private void WireSidebarEvents()
		{
			btnNavDoctorNurse.Click += (s, e) => { };
			btnNavRoom.Click += (s, e) => { new RoomManagementForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavPatient.Click += (s, e) => { new PatientInformationForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavPatientSearch.Click += (s, e) => { new PatientInfoSearchForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavRoomSearch.Click += (s, e) => { new PatientRoomSearchForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavAdmission.Click += (s, e) => { new AdmissionForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavAdmissionLog.Click += (s, e) => { new AdmissionLogForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavTreatment.Click += (s, e) => { new TreatmentBillingForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavBilling.Click += (s, e) =>
			{
				BillingForm form = new BillingForm(_loginPage, _username, _role);
				form.Show();
				this.Close();
			};
			btnNavDischarge.Click += (s, e) =>
			{
				DischargeForm form = new DischargeForm(_loginPage, _username, _role);
				form.Show();
				this.Close();
			};
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
				btnNavAdmission, btnNavAdmissionLog, btnNavTreatment, btnNavDoctorNurse,
				btnNavBilling, btnNavDischarge, btnNavSummary
			};

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