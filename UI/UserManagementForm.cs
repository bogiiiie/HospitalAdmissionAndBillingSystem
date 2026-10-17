using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class UserManagementForm : Form
	{
		private readonly UserController controller = new UserController();
		private readonly LoginPage _loginPage;
		private readonly string _username;
		private readonly string _role;

		public UserManagementForm(LoginPage loginPage, string username, string role)
		{
			InitializeComponent();
			_loginPage = loginPage;
			_username = username;
			_role = role;
		}

		private void UserManagementForm_Load(object sender, EventArgs e)
		{
			dgvUsers.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvUsers.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvUsers.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvUsers.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

			lblUserInfo.Text = "Logged in as: " + _username + "   |   Role: " + _role;

			WireSidebarEvents();
			ApplyRoleToSidebar();
			LoadUsers();
		}

		private void LoadUsers()
		{
			List<User> users = controller.GetAllUsers();
			dgvUsers.Rows.Clear();

			foreach (User u in users)
			{
				string status = u.IsActive ? "Active" : "Inactive";
				dgvUsers.Rows.Add(u.Username, u.Role, status, "");
			}
			lblCount.Text = "Total Users: " + users.Count;
		}

		// =============================================================
		// CELL PAINTING & CLICK (Reset Password Button)
		// =============================================================
		private void dgvUsers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex < 0) return;
			if (dgvUsers.Columns[e.ColumnIndex].Name != "colActions") return;

			string targetRole = dgvUsers.Rows[e.RowIndex].Cells["colRole"].Value.ToString();

			e.PaintBackground(e.CellBounds, true);

			// Only allow resetting passwords for "Hospital Staff"
			if (targetRole == "Hospital Staff")
			{
				// Same width/height as the Logout button
				int buttonWidth = 106;
				int buttonHeight = 32;

				// Align to the left side of the cell (matching the header text)
				int x = e.CellBounds.X + 6;
				int y = e.CellBounds.Y + (e.CellBounds.Height - buttonHeight) / 2;

				Rectangle btnRect = new Rectangle(x, y, buttonWidth, buttonHeight);

				using (var brush = new SolidBrush(Color.FromArgb(37, 99, 235))) // Blue
				{
					e.Graphics.FillRectangle(brush, btnRect);
				}

				TextRenderer.DrawText(
					e.Graphics,
					"Reset Password",
					new Font("Segoe UI", 9F, FontStyle.Bold),
					btnRect,
					Color.White,
					TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
			}

			e.Handled = true;
		}

		private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			if (dgvUsers.Columns[e.ColumnIndex].Name != "colActions") return;

			string targetUser = dgvUsers.Rows[e.RowIndex].Cells["colUsername"].Value.ToString();
			string targetRole = dgvUsers.Rows[e.RowIndex].Cells["colRole"].Value.ToString();

			if (targetRole == "Admin")
			{
				MessageBox.Show("You cannot reset passwords for other Admin accounts.", "Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			ResetPasswordDialog dialog = new ResetPasswordDialog(targetUser);
			if (dialog.ShowDialog(this) == DialogResult.OK)
			{
				// No need to reload, password reset doesn't change the grid
			}
		}

		// =============================================================
		// SIDEBAR
		// =============================================================
		private void WireSidebarEvents()
		{
			btnNavUserMgmt.Click += (s, e) => { };
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
			btnNavSummary.Click += (s, e) => { new DischargeSummaryForm(_loginPage, _username, _role).Show(); this.Close(); };
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
				visibleButtons.Add(btnNavUserMgmt); // Add User Mgmt at the bottom
			}

			btnNavRoom.Visible = false; btnNavPatient.Visible = false; btnNavPatientSearch.Visible = false;
			btnNavRoomSearch.Visible = false; btnNavAdmission.Visible = false; btnNavAdmissionLog.Visible = false;
			btnNavTreatment.Visible = false; btnNavDoctorNurse.Visible = false; btnNavBilling.Visible = false;
			btnNavDischarge.Visible = false; btnNavSummary.Visible = false; btnNavUserMgmt.Visible = false;

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