using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class PatientRoomSearchForm : Form
	{
		private readonly RoomController controller = new RoomController();
		private readonly LoginPage _loginPage;
		private readonly string _username;
		private readonly string _role;

		public PatientRoomSearchForm(LoginPage loginPage, string username, string role)
		{
			InitializeComponent();
			_loginPage = loginPage;
			_username = username;
			_role = role;
		}

		public PatientRoomSearchForm()
		{
			InitializeComponent();
		}

		private void PatientRoomSearchForm_Load(object sender, EventArgs e)
		{
			// Force uniform font across rows
			dgvRooms.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvRooms.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvRooms.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvRooms.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

			lblUserInfo.Text = "Logged in as: " + _username + "   |   Role: " + _role;

			// Populate status filter dropdown
			cmbStatus.Items.Clear();
			cmbStatus.Items.Add("All");
			cmbStatus.Items.Add("Available");
			cmbStatus.Items.Add("Occupied");
			cmbStatus.Items.Add("Maintenance");
			cmbStatus.SelectedIndex = 0;

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
			btnNavRoomSearch.Click += (s, e) => { };

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
			btnNavPatientSearch.Click += (s, e) =>
			{
				PatientInfoSearchForm form = new PatientInfoSearchForm(_loginPage, _username, _role);
				form.Show();
				this.Close();
			};
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
			string statusFilter = cmbStatus.SelectedItem != null ? cmbStatus.SelectedItem.ToString() : "All";

			// Get all rooms via controller
			List<Room> rooms = string.IsNullOrWhiteSpace(keyword)
				? controller.GetAllRooms()
				: controller.SearchRooms(keyword);

			// Filter out Deleted rooms — they never appear here
			rooms = rooms.FindAll(r => r.Status != "Deleted");

			// Apply status filter
			if (statusFilter != "All")
			{
				rooms = rooms.FindAll(r => r.Status == statusFilter);
			}

			// If the keyword looks like a name (no digits) and no matches, offer the special message
			bool keywordLooksLikeName = !string.IsNullOrWhiteSpace(keyword) && !ContainsDigit(keyword);

			dgvRooms.Rows.Clear();

			foreach (Room r in rooms)
			{
				// TODO: Replace with real occupant lookup once the Admissions table exists.
				// For now, show "—" for every room.
				string occupant = "—";

				dgvRooms.Rows.Add(
					r.RoomNumber,
					r.RoomType,
					r.Status,
					occupant
				);
			}

			lblCount.Text = "Total Results: " + rooms.Count;

			// Decide which "no results" message to show
			if (rooms.Count == 0)
			{
				lblNoResults.Text = keywordLooksLikeName
					? "Patient is not currently admitted to a room."
					: "No rooms found.";
				lblNoResults.Visible = true;
				dgvRooms.Visible = false;
			}
			else
			{
				lblNoResults.Visible = false;
				dgvRooms.Visible = true;
			}
		}

		private bool ContainsDigit(string text)
		{
			foreach (char c in text)
				if (char.IsDigit(c)) return true;
			return false;
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

		private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.IsHandleCreated && !this.DesignMode)
				RunSearch();
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