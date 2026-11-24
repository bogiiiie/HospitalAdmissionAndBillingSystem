using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using BusinessLogic.Repository;
using Model;

namespace UI
{
	public partial class PatientRoomSearchForm : Form
	{
		private readonly RoomController controller = new RoomController();
		private readonly AdmissionController admissionController = new AdmissionController();
		private readonly BedRepository bedRepo = new BedRepository();
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
			dgvRooms.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvRooms.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvRooms.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvRooms.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

			lblUserInfo.Text = "Logged in as: " + _username + "   |   Role: " + _role;

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
			btnNavRoomSearch.Click += (s, e) => { };
			btnNavRoom.Click += (s, e) => { new RoomManagementForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavPatient.Click += (s, e) => { new PatientInformationForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavPatientSearch.Click += (s, e) => { new PatientInfoSearchForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavAdmission.Click += (s, e) => { new AdmissionForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavAdmissionLog.Click += (s, e) => { new AdmissionLogForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavDoctorNurse.Click += (s, e) => { new DoctorNurseAssignmentForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavTreatment.Click += (s, e) => { new TreatmentBillingForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavBilling.Click += (s, e) => { new BillingForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavDischarge.Click += (s, e) => { new DischargeForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavSummary.Click += (s, e) => { new DischargeSummaryForm(_loginPage, _username, _role).Show(); this.Close(); };
		}

		private void ApplyRoleToSidebar()
		{
			var visibleButtons = new List<Button>
			{
				btnNavRoom, btnNavPatient, btnNavPatientSearch, btnNavRoomSearch,
				btnNavAdmission, btnNavAdmissionLog
			};

			if (_role == "Admin") visibleButtons.Add(btnNavDoctorNurse);

			visibleButtons.Add(btnNavTreatment);
			visibleButtons.Add(btnNavBilling);
			visibleButtons.Add(btnNavDischarge);
			visibleButtons.Add(btnNavSummary);

			btnNavRoom.Visible = false; btnNavPatient.Visible = false; btnNavPatientSearch.Visible = false;
			btnNavRoomSearch.Visible = false; btnNavAdmission.Visible = false; btnNavAdmissionLog.Visible = false;
			btnNavDoctorNurse.Visible = false; btnNavTreatment.Visible = false; btnNavBilling.Visible = false;
			btnNavDischarge.Visible = false; btnNavSummary.Visible = false;

			int y = 48;
			foreach (var btn in visibleButtons) { btn.Visible = true; btn.Top = y; y += 44; }
		}

		// =============================================================
		// SEARCH
		// =============================================================
		private void RunSearch()
		{
			string keyword = txtSearch.Text.Trim();
			string statusFilter = cmbStatus.SelectedItem != null ? cmbStatus.SelectedItem.ToString() : "All";

			List<Room> rooms = controller.GetAllRooms();
			rooms = rooms.FindAll(r => r.Status != "Deleted");

			var rows = new List<Tuple<Room, Bed, string>>();

			foreach (Room r in rooms)
			{
				List<Bed> bedsInRoom = bedRepo.GetBedsByRoom(r.RoomNumber);
				foreach (Bed b in bedsInRoom)
				{
					bool matchStatus = false;
					if (statusFilter == "All") matchStatus = true;
					else if (statusFilter == "Available") matchStatus = (b.Status == "Available" && r.Status == "Available");
					else if (statusFilter == "Occupied") matchStatus = (b.Status == "Occupied");
					else if (statusFilter == "Maintenance") matchStatus = (r.Status == "Maintenance");

					if (!matchStatus) continue;

					string occupant = "—";
					if (b.Status == "Occupied")
					{
						occupant = admissionController.GetOccupantName(r.RoomNumber, b.BedName);
					}

					rows.Add(Tuple.Create(r, b, occupant));
				}
			}

			if (!string.IsNullOrWhiteSpace(keyword))
			{
				string lower = keyword.ToLower();
				rows = rows.FindAll(t =>
					t.Item1.RoomNumber.ToLower().Contains(lower) ||
					t.Item1.RoomType.ToLower().Contains(lower) ||
					t.Item2.BedName.ToLower().Contains(lower) ||
					t.Item3.ToLower().Contains(lower)
				);
			}

			bool keywordLooksLikeName = !string.IsNullOrWhiteSpace(keyword) && !ContainsDigit(keyword);

			dgvRooms.Rows.Clear();

			foreach (var t in rows)
			{
				dgvRooms.Rows.Add(
					t.Item1.RoomNumber,
					t.Item2.BedName,
					t.Item1.RoomType,
					t.Item2.Status,
					t.Item3
				);
			}

			lblCount.Text = "Total Results: " + rows.Count;

			if (rows.Count == 0)
			{
				lblNoResults.Text = keywordLooksLikeName
					? "Patient is not currently admitted."
					: "No beds found.";
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

		private void btnSearch_Click(object sender, EventArgs e) => RunSearch();

		private void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) { RunSearch(); e.SuppressKeyPress = true; }
		}

		private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.IsHandleCreated && !this.DesignMode) RunSearch();
		}

		// =============================================================
		// HEADER
		// =============================================================
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