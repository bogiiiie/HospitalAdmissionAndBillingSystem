using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class PatientInfoSearchForm : Form
	{
		private readonly PatientController controller = new PatientController();
		private readonly LoginPage _loginPage;
		private readonly string _username;
		private readonly string _role;

		// Track the PatientCode currently selected in the grid
		private string _selectedPatientCode;

		// Used by menu buttons to pass login context
		public PatientInfoSearchForm(LoginPage loginPage, string username, string role)
		{
			InitializeComponent();
			_loginPage = loginPage;
			_username = username;
			_role = role;
		}

		// Used by the Designer
		public PatientInfoSearchForm()
		{
			InitializeComponent();
		}

		private void PatientInfoSearchForm_Load(object sender, EventArgs e)
		{
			// Uniform font across rows
			dgvSearchResults.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvSearchResults.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvSearchResults.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvSearchResults.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

			lblUserInfo.Text = "Logged in as: " + _username + "   |   Role: " + _role;

			// Populate filter dropdowns
			cmbGender.Items.Clear();
			cmbGender.Items.Add("All");
			cmbGender.Items.Add("Male");
			cmbGender.Items.Add("Female");
			cmbGender.Items.Add("Other");
			cmbGender.SelectedIndex = 0;

			cmbAdmissionStatus.Items.Clear();
			cmbAdmissionStatus.Items.Add("All");
			cmbAdmissionStatus.Items.Add("Admitted");
			cmbAdmissionStatus.Items.Add("Discharged");
			cmbAdmissionStatus.SelectedIndex = 0;

			WireSidebarEvents();
			ApplyRoleToSidebar();
			RunSearch();
		}

		// =============================================================
		// SIDEBAR
		// =============================================================
		private void WireSidebarEvents()
		{
			// Current module — do nothing
			btnNavPatientSearch.Click += (s, e) => { };

			// Navigate to other modules
			btnNavRoom.Click += (s, e) =>
			{
				RoomManagementForm form = new RoomManagementForm(_loginPage, _username, _role);
				form.Show();
				this.Close();
			};
			btnNavPatient.Click += (s, e) =>
			{
				PatientInformationForm form = new PatientInformationForm(_loginPage, _username, _role);
				form.Show();
				this.Close();
			};
			btnNavRoomSearch.Click += (s, e) => MessageBox.Show("Patient Room Search module coming soon.");
			btnNavAdmission.Click += (s, e) => MessageBox.Show("Admission module coming soon.");
			btnNavAdmissionLog.Click += (s, e) => MessageBox.Show("Admission Log module coming soon.");
			btnNavTreatment.Click += (s, e) => MessageBox.Show("Treatment / Billing module coming soon.");
			btnNavBilling.Click += (s, e) => MessageBox.Show("Billing module coming soon.");
			btnNavDischarge.Click += (s, e) => MessageBox.Show("Discharge module coming soon.");
			btnNavSummary.Click += (s, e) => MessageBox.Show("Discharge Summary module coming soon.");
		}

		private void ApplyRoleToSidebar()
		{
			var visibleButtons = new List<Button>
			{
				btnNavRoom,
				btnNavPatient,
				btnNavPatientSearch,
				btnNavRoomSearch,
				btnNavAdmission,
			};

			if (_role == "Admin")
				visibleButtons.Add(btnNavAdmissionLog);

			visibleButtons.Add(btnNavTreatment);
			visibleButtons.Add(btnNavBilling);
			visibleButtons.Add(btnNavDischarge);
			visibleButtons.Add(btnNavSummary);

			btnNavRoom.Visible = false;
			btnNavPatient.Visible = false;
			btnNavPatientSearch.Visible = false;
			btnNavRoomSearch.Visible = false;
			btnNavAdmission.Visible = false;
			btnNavAdmissionLog.Visible = false;
			btnNavTreatment.Visible = false;
			btnNavBilling.Visible = false;
			btnNavDischarge.Visible = false;
			btnNavSummary.Visible = false;

			int y = 48;
			foreach (var btn in visibleButtons)
			{
				btn.Visible = true;
				btn.Top = y;
				y += 44;
			}
		}

		// =============================================================
		// SEARCH
		// =============================================================
		private void RunSearch()
		{
			string keyword = txtSearch.Text.Trim();

			// Start with all active patients
			List<Patient> results = controller.SearchPatients(keyword, "Active");

			// Apply gender filter
			if (cmbGender.SelectedItem != null && cmbGender.SelectedItem.ToString() != "All")
			{
				string gender = cmbGender.SelectedItem.ToString();
				results = results.FindAll(p => p.Gender == gender);
			}

			// Apply admission status filter
			// NOTE: Until the Admission module is built, every patient is treated as "Discharged".
			if (cmbAdmissionStatus.SelectedItem != null && cmbAdmissionStatus.SelectedItem.ToString() != "All")
			{
				string status = cmbAdmissionStatus.SelectedItem.ToString();
				string currentStatus = "Discharged";   // placeholder — will become dynamic later

				if (status != currentStatus)
				{
					results.Clear();
				}
			}

			// Populate grid
			dgvSearchResults.Rows.Clear();

			foreach (Patient p in results)
			{
				// Placeholder for admission status — always Discharged for now
				string admissionStatus = "Discharged";

				dgvSearchResults.Rows.Add(
					p.PatientCode,
					p.FullName,
					p.Gender,
					admissionStatus
				);
			}

			lblCount.Text = "Total Results: " + results.Count;

			// Show / hide "No results" label
			lblNoResults.Visible = (results.Count == 0);
			dgvSearchResults.Visible = (results.Count > 0);

			// Reset selection
			_selectedPatientCode = null;
			btnViewDetails.Enabled = false;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			RunSearch();
		}

		private void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				RunSearch();
				e.SuppressKeyPress = true;
			}
		}

		private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Filter change re-runs the search
			if (this.IsHandleCreated && !this.DesignMode)
				RunSearch();
		}

		private void cmbAdmissionStatus_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.IsHandleCreated && !this.DesignMode)
				RunSearch();
		}

		// =============================================================
		// SELECTION
		// =============================================================
		private void dgvSearchResults_SelectionChanged(object sender, EventArgs e)
		{
			// Not wired in Designer currently, but kept for future
		}

		// Double-click a row → open details
		private void dgvSearchResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			OpenSelectedPatient();
		}

		private void btnViewDetails_Click(object sender, EventArgs e)
		{
			OpenSelectedPatient();
		}

		private void OpenSelectedPatient()
		{
			if (dgvSearchResults.CurrentRow == null) return;

			string patientCode = dgvSearchResults.CurrentRow.Cells["colPatientCode"].Value.ToString();
			Patient patient = controller.GetPatientByCode(patientCode);
			if (patient == null) return;

			PatientDetailsForm dialog = new PatientDetailsForm(patient);
			dialog.ShowDialog(this);
		}

		// Enable View Details when a row is selected
		private void dgvSearchResults_SelectionChanged_EnableButton(object sender, EventArgs e)
		{
			btnViewDetails.Enabled = (dgvSearchResults.CurrentRow != null);
		}

		// =============================================================
		// HEADER
		// =============================================================
		private void btnMainMenu_Click(object sender, EventArgs e)
		{
			if (_role == "Admin")
			{
				AdminMenuForm form = new AdminMenuForm(_loginPage, _username, _role);
				form.Show();
			}
			else
			{
				HospitalStaffMenuForm form = new HospitalStaffMenuForm(_loginPage, _username, _role);
				form.Show();
			}
			this.Close();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			DialogResult choice = MessageBox.Show(
				"Are you sure you want to log out?",
				"Logout",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (choice == DialogResult.Yes)
			{
				if (_loginPage != null) _loginPage.Show();
				this.Close();
			}
		}
	}
}