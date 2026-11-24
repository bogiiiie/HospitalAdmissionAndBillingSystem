using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using BusinessLogic.Repository;
using Model;

namespace UI
{
	public partial class RoomManagementForm : Form
	{
		private readonly RoomController controller = new RoomController();
		private readonly BedRepository bedRepo = new BedRepository(); // NEW
		private readonly LoginPage _loginPage;
		private readonly string _username;
		private readonly string _role;

		// Used by menu buttons to pass login context
		public RoomManagementForm(LoginPage loginPage, string username, string role)
		{
			InitializeComponent();
			_loginPage = loginPage;
			_username = username;
			_role = role;
		}

		// Used by the Designer
		public RoomManagementForm()
		{
			InitializeComponent();
		}

		// =============================================================
		// FORM LOAD
		// =============================================================
		private void RoomManagementForm_Load(object sender, EventArgs e)
		{
			dgvRooms.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvRooms.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvRooms.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvRooms.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

			lblUserInfo.Text = "Logged in as: " + _username + "   |   Role: " + _role;

			// Build the filter dropdown — "Deleted" only for Admin
			cmbStatusFilter.Items.Clear();
			cmbStatusFilter.Items.Add("All");
			cmbStatusFilter.Items.Add("Available");
			cmbStatusFilter.Items.Add("Occupied");
			cmbStatusFilter.Items.Add("Maintenance");
			if (_role == "Admin")
				cmbStatusFilter.Items.Add("Deleted");

			cmbStatusFilter.SelectedIndex = 0;

			// Show/hide action panel based on role
			btnEditSelected.Visible = (_role == "Admin");
			btnDeleteSelected.Visible = (_role == "Admin");
			btnReactivateSelected.Visible = (_role == "Admin");

			WireSidebarEvents();
			ApplyRoleToSidebar();
			LoadRooms();
		}

		private void RoomManagementForm_Shown(object sender, EventArgs e)
		{
			// Kept for layout consistency
		}

		// =============================================================
		// SIDEBAR — wire buttons to modules
		// =============================================================
		private void WireSidebarEvents()
		{
			// Room Management button does nothing — we're already here
			btnNavRoom.Click += (s, e) => { };

			// Patient Information — navigate to it
			btnNavPatient.Click += (s, e) =>
			{
				PatientInformationForm form = new PatientInformationForm(_loginPage, _username, _role);
				form.Show();
				this.Close();
			};

			// Future modules — placeholders for now
			btnNavPatientSearch.Click += (s, e) =>
			{
				PatientInfoSearchForm form = new PatientInfoSearchForm(_loginPage, _username, _role);
				form.Show();
				this.Close();
			};
			btnNavRoomSearch.Click += (s, e) =>
			{
				PatientRoomSearchForm form = new PatientRoomSearchForm(_loginPage, _username, _role);
				form.Show();
				this.Close();
			};
			btnNavAdmission.Click += (s, e) =>
			{
				AdmissionForm form = new AdmissionForm(_loginPage, _username, _role);
				form.Show();
				this.Close();
			};
			btnNavAdmissionLog.Click += (s, e) =>
			{
				AdmissionLogForm form = new AdmissionLogForm(_loginPage, _username, _role);
				form.Show();
				this.Close();
			};
			btnNavDoctorNurse.Click += (s, e) =>
			{
				DoctorNurseAssignmentForm form = new DoctorNurseAssignmentForm(_loginPage, _username, _role);
				form.Show();
				this.Close();
			};
			btnNavTreatment.Click += (s, e) =>
			{
				TreatmentBillingForm form = new TreatmentBillingForm(_loginPage, _username, _role);
				form.Show();
				this.Close();
			};
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

		// Hide sidebar buttons the current role cannot access
		private void ApplyRoleToSidebar()
		{
			// Build the list of buttons for this role — in order
			var visibleButtons = new List<Button>
			{
				btnNavRoom,
				btnNavPatient,
				btnNavPatientSearch,
				btnNavRoomSearch,
				btnNavAdmission,
				btnNavAdmissionLog // Visible for both Admin and Staff
			};

			// Doctor / Nurse is Admin-only
			if (_role == "Admin")
			{
				visibleButtons.Add(btnNavDoctorNurse);
			}

			visibleButtons.Add(btnNavTreatment);
			visibleButtons.Add(btnNavBilling);
			visibleButtons.Add(btnNavDischarge);
			visibleButtons.Add(btnNavSummary);

			// Hide all buttons first
			btnNavRoom.Visible = false;
			btnNavPatient.Visible = false;
			btnNavPatientSearch.Visible = false;
			btnNavRoomSearch.Visible = false;
			btnNavAdmission.Visible = false;
			btnNavAdmissionLog.Visible = false;
			btnNavDoctorNurse.Visible = false;
			btnNavTreatment.Visible = false;
			btnNavBilling.Visible = false;
			btnNavDischarge.Visible = false;
			btnNavSummary.Visible = false;

			// Re-show only the visible ones and stack them tightly
			int y = 48;
			foreach (var btn in visibleButtons)
			{
				btn.Visible = true;
				btn.Top = y;
				y += 44;
			}
		}

		// =============================================================
		// LOAD ALL ROOMS (with status filter)
		// =============================================================
		private void LoadRooms()
		{
			List<Room> rooms = controller.GetAllRooms();

			// Read the current dropdown value
			string filter = cmbStatusFilter.SelectedItem != null
				? cmbStatusFilter.SelectedItem.ToString()
				: "All";

			// "All" hides Deleted rooms; other filters show only that status
			if (filter == "All")
				rooms = rooms.FindAll(r => r.Status != "Deleted");
			else
				rooms = rooms.FindAll(r => r.Status == filter);

			dgvRooms.Rows.Clear();

			foreach (Room room in rooms)
			{
				// Get available beds
				int availableBeds = bedRepo.GetAvailableBedCount(room.RoomNumber);

				dgvRooms.Rows.Add(
					room.RoomNumber,
					room.RoomType,
					"P" + room.Rate.ToString("N0") + "/day",
					availableBeds + " / " + room.Capacity, // NEW
					room.Status
				);
			}

			lblCount.Text = "Total Rooms: " + rooms.Count;

			// Reset selection and buttons
			dgvRooms.ClearSelection();
			UpdateActionButtons();
		}

		// =============================================================
		// STATUS FILTER — fires when dropdown changes
		// =============================================================
		private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadRooms();
		}

		// =============================================================
		// SELECTION CHANGED — Enable/Disable buttons based on selected row
		// =============================================================
		private void dgvRooms_SelectionChanged(object sender, EventArgs e)
		{
			UpdateActionButtons();
		}

		private void UpdateActionButtons()
		{
			if (_role != "Admin" || dgvRooms.CurrentRow == null)
			{
				btnEditSelected.Enabled = false;
				btnDeleteSelected.Enabled = false;
				btnReactivateSelected.Visible = false;
				return;
			}

			string roomNumber = dgvRooms.CurrentRow.Cells["colRoomNumber"].Value.ToString();
			Room room = controller.GetRoomByNumber(roomNumber);
			if (room == null) return;

			if (room.Status == "Deleted")
			{
				btnEditSelected.Visible = false;
				btnDeleteSelected.Visible = false;
				btnReactivateSelected.Visible = true;
				btnReactivateSelected.Enabled = true;
			}
			else if (room.Status == "Occupied")
			{
				btnEditSelected.Visible = true;
				btnDeleteSelected.Visible = true;
				btnReactivateSelected.Visible = false;
				btnEditSelected.Enabled = false;
				btnDeleteSelected.Enabled = false;
				// Tooltip could be added here if desired
			}
			else
			{
				btnEditSelected.Visible = true;
				btnDeleteSelected.Visible = true;
				btnReactivateSelected.Visible = false;
				btnEditSelected.Enabled = true;
				btnDeleteSelected.Enabled = true;
			}
		}

		// =============================================================
		// BUTTON CLICKS
		// =============================================================
		private void btnEditSelected_Click(object sender, EventArgs e)
		{
			if (dgvRooms.CurrentRow == null) return;
			string roomNumber = dgvRooms.CurrentRow.Cells["colRoomNumber"].Value.ToString();
			Room room = controller.GetRoomByNumber(roomNumber);
			if (room == null) return;

			AddEditRoomForm dialog = new AddEditRoomForm(room);
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				LoadRooms();
			}
		}

		private void btnDeleteSelected_Click(object sender, EventArgs e)
		{
			if (dgvRooms.CurrentRow == null) return;
			string roomNumber = dgvRooms.CurrentRow.Cells["colRoomNumber"].Value.ToString();

			DialogResult confirm = MessageBox.Show(
				"Move Room " + roomNumber + " to Deleted?",
				"Confirm Delete",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (confirm == DialogResult.Yes)
			{
				string result = controller.DeleteRoom(roomNumber);
				if (result == "OK")
				{
					MessageBox.Show("Room moved to Deleted.", "Success",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadRooms();
				}
				else
				{
					MessageBox.Show(result, "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void btnReactivateSelected_Click(object sender, EventArgs e)
		{
			if (dgvRooms.CurrentRow == null) return;
			string roomNumber = dgvRooms.CurrentRow.Cells["colRoomNumber"].Value.ToString();

			DialogResult confirm = MessageBox.Show(
				"Reactivate Room " + roomNumber + "?\n\nIts status will be set back to Available.",
				"Confirm Reactivate",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (confirm == DialogResult.Yes)
			{
				string result = controller.ReactivateRoom(roomNumber);
				if (result == "OK")
				{
					MessageBox.Show("Room reactivated.", "Success",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadRooms();
				}
				else
				{
					MessageBox.Show(result, "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		// =============================================================
		// ADD ROOM
		// =============================================================
		private void btnAdd_Click(object sender, EventArgs e)
		{
			AddEditRoomForm dialog = new AddEditRoomForm(null);
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				LoadRooms();
			}
		}

		// =============================================================
		// MAIN MENU 
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

		// =============================================================
		// LOGOUT
		// =============================================================
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

	// =============================================================
	// FlatButton — gray background + white text when disabled
	// =============================================================
	public class FlatButton : Button
	{
		public Color DisabledBackColor { get; set; } = Color.FromArgb(160, 160, 160); // gray
		public Color DisabledForeColor { get; set; } = Color.White;

		public FlatButton()
		{
			FlatStyle = FlatStyle.Flat;
			FlatAppearance.BorderSize = 0;
		}

		protected override void OnPaint(PaintEventArgs pevent)
		{
			if (!Enabled)
			{
				using (var bg = new SolidBrush(DisabledBackColor))
					pevent.Graphics.FillRectangle(bg, ClientRectangle);

				TextRenderer.DrawText(
					pevent.Graphics,
					Text,
					Font,
					ClientRectangle,
					DisabledForeColor,
					TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
			}
			else
			{
				base.OnPaint(pevent);
			}
		}
	}
}