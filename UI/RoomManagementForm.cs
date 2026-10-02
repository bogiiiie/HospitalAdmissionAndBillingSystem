using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class RoomManagementForm : Form
	{
		private readonly RoomController controller = new RoomController();
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
			lblUserInfo.Text = "Logged in as: " + _username + "   |   Role: " + _role;

			// Admin sees the Add button; Staff does not
			btnAdd.Visible = (_role == "Admin");

			// Admin sees the Actions column; Staff does not
			colActions.Visible = (_role == "Admin");

			// Default filter = All
			cmbStatusFilter.SelectedIndex = 0;

			LoadRooms();
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

			// Apply the status filter if not "All"
			if (filter != "All")
			{
				rooms = rooms.FindAll(r => r.Status == filter);
			}

			dgvRooms.Rows.Clear();

			foreach (Room room in rooms)
			{
				dgvRooms.Rows.Add(
					room.RoomNumber,
					room.RoomType,
					"P" + room.Rate.ToString("N0") + "/day",
					room.Status,
					_role == "Admin" ? "Edit | Delete" : ""
				);
			}

			lblCount.Text = "Total Rooms: " + rooms.Count;
		}

		// =============================================================
		// STATUS FILTER — fires when dropdown changes
		// =============================================================
		private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadRooms();
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
		// CLICK on the Actions column
		// =============================================================
		private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (_role != "Admin") return;
			if (e.RowIndex < 0) return;
			if (dgvRooms.Columns[e.ColumnIndex].Name != "colActions") return;

			string roomNumber = dgvRooms.Rows[e.RowIndex].Cells["colRoomNumber"].Value.ToString();
			Room room = controller.GetRoomByNumber(roomNumber);
			if (room == null) return;

			DialogResult choice = MessageBox.Show(
				"Room " + roomNumber + "\n\nYes = Edit\nNo = Delete\nCancel = Do nothing",
				"Actions",
				MessageBoxButtons.YesNoCancel,
				MessageBoxIcon.Question);

			if (choice == DialogResult.Yes)
			{
				AddEditRoomForm dialog = new AddEditRoomForm(room);
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					LoadRooms();
				}
			}
			else if (choice == DialogResult.No)
			{
				DialogResult confirm = MessageBox.Show(
					"Delete Room " + roomNumber + "?",
					"Confirm Delete",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning);

				if (confirm == DialogResult.Yes)
				{
					string result = controller.DeleteRoom(roomNumber);
					if (result == "OK")
					{
						MessageBox.Show("Room deleted.", "Success",
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
		}

		// =============================================================
		// NAVIGATION — Main Menu / Logout
		// =============================================================
		private void llblNav_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			DialogResult choice = MessageBox.Show(
				"Return to Main Menu?\n\nYes = Main Menu\nNo = Logout",
				"Navigate",
				MessageBoxButtons.YesNoCancel,
				MessageBoxIcon.Question);

			if (choice == DialogResult.Yes)
			{
				if (_role == "Admin")
				{
					AdminMenuForm menu = new AdminMenuForm(_loginPage, _username, _role);
					menu.Show();
				}
				else
				{
					HospitalStaffMenuForm menu = new HospitalStaffMenuForm(_loginPage, _username, _role);
					menu.Show();
				}
				this.Close();
			}
			else if (choice == DialogResult.No)
			{
				if (_loginPage != null) _loginPage.Show();
				this.Close();
			}
		}
	}
}