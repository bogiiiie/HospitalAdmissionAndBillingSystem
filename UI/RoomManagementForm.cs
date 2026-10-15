using System;
using System.Collections.Generic;
using System.Drawing;
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
			dgvRooms.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvRooms.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvRooms.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvRooms.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

			// Wire the mouse enter/leave events so we can show a tooltip on
			// disabled Edit/Delete buttons when a room is occupied.
			dgvRooms.CellMouseEnter += dgvRooms_CellMouseEnter;
			dgvRooms.CellMouseLeave += dgvRooms_CellMouseLeave;

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

			// Admin sees the Actions column; Staff does not
			colActions.Visible = (_role == "Admin");

			WireSidebarEvents();
			ApplyRoleToSidebar();
			LoadRooms();
		}

		private void RoomManagementForm_Shown(object sender, EventArgs e)
		{
			// Hide the Actions column for Staff (after the form is laid out)
			colActions.Visible = (_role == "Admin");
		}

		// =============================================================
		// SIDEBAR — wire buttons to modules
		// =============================================================
		private void WireSidebarEvents()
		{
			// Room Management button does nothing — we're already here
			btnNavRoom.Click += (s, e) => { };

			// Future modules — placeholders for now
			btnNavPatient.Click += (s, e) => MessageBox.Show("Patient Information module coming soon.");
			btnNavPatientSearch.Click += (s, e) => MessageBox.Show("Patient Info Search module coming soon.");
			btnNavRoomSearch.Click += (s, e) => MessageBox.Show("Patient Room Search module coming soon.");
			btnNavAdmission.Click += (s, e) => MessageBox.Show("Admission module coming soon.");
			btnNavAdmissionLog.Click += (s, e) => MessageBox.Show("Admission Log module coming soon.");
			btnNavTreatment.Click += (s, e) => MessageBox.Show("Treatment / Billing module coming soon.");
			btnNavBilling.Click += (s, e) => MessageBox.Show("Billing module coming soon.");
			btnNavDischarge.Click += (s, e) => MessageBox.Show("Discharge module coming soon.");
			btnNavSummary.Click += (s, e) => MessageBox.Show("Discharge Summary module coming soon.");
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
			};

			// Admission Log is Admin-only (per the requirements PDF)
			if (_role == "Admin")
			{
				visibleButtons.Add(btnNavAdmissionLog);
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
				// Actions cell is blank — buttons are drawn in CellPainting
				dgvRooms.Rows.Add(
					room.RoomNumber,
					room.RoomType,
					"P" + room.Rate.ToString("N0") + "/day",
					room.Status,
					""
				);
			}

			lblCount.Text = "Total Rooms: " + rooms.Count;
		}

		// =============================================================
		// STATUS FILTER — fires when dropdown changes
		// =============================================================
		private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			string filter = cmbStatusFilter.SelectedItem != null
				? cmbStatusFilter.SelectedItem.ToString()
				: "All";

			// Hide the Actions column when the Deleted filter is active
			colActions.Visible = (_role == "Admin" && filter != "Deleted");

			LoadRooms();
		}

		// =============================================================
		// CELL PAINTING — draws two buttons inside the Actions cell
		// Disables them (gray) when the room is Occupied.
		// =============================================================
		private void dgvRooms_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			// Only paint data rows (skip header)
			if (e.RowIndex < 0) return;

			// Only paint the Actions column
			if (dgvRooms.Columns[e.ColumnIndex].Name != "colActions") return;

			// Only Admin sees buttons
			if (_role != "Admin") return;

			// Check if this row is a Deleted room
			string roomNumber = dgvRooms.Rows[e.RowIndex].Cells["colRoomNumber"].Value.ToString();
			Room room = controller.GetRoomByNumber(roomNumber);
			bool isDeleted = (room != null && room.Status == "Deleted");
			bool isOccupied = (room != null && room.Status == "Occupied");

			// Paint the background first
			e.PaintBackground(e.CellBounds, true);

			// If deleted, don't paint buttons
			if (isDeleted)
			{
				e.Handled = true;
				return;
			}

			// Calculate the two button rectangles
			int padding = 6;
			int gap = 6;
			int buttonWidth = (e.CellBounds.Width - padding * 2 - gap) / 2;
			int buttonHeight = e.CellBounds.Height - padding * 2;

			Rectangle editRect = new Rectangle(
				e.CellBounds.X + padding,
				e.CellBounds.Y + padding,
				buttonWidth,
				buttonHeight);

			Rectangle deleteRect = new Rectangle(
				e.CellBounds.X + padding + buttonWidth + gap,
				e.CellBounds.Y + padding,
				buttonWidth,
				buttonHeight);

			// Pick colors — gray when occupied, normal when not
			Color editColor = isOccupied
				? Color.FromArgb(203, 213, 225)   // slate-300 gray
				: Color.FromArgb(16, 185, 129);   // emerald-500 green

			Color deleteColor = isOccupied
				? Color.FromArgb(203, 213, 225)   // same gray
				: Color.FromArgb(239, 68, 68);    // red-500

			Color textColor = isOccupied
				? Color.FromArgb(100, 116, 139)   // slate-500 — softer text on gray
				: Color.White;

			// Draw Edit button
			using (var brush = new SolidBrush(editColor))
			{
				e.Graphics.FillRectangle(brush, editRect);
			}
			TextRenderer.DrawText(
				e.Graphics,
				"Edit",
				new Font("Segoe UI", 9F, FontStyle.Bold),
				editRect,
				textColor,
				TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

			// Draw Delete button
			using (var brush = new SolidBrush(deleteColor))
			{
				e.Graphics.FillRectangle(brush, deleteRect);
			}
			TextRenderer.DrawText(
				e.Graphics,
				"Delete",
				new Font("Segoe UI", 9F, FontStyle.Bold),
				deleteRect,
				textColor,
				TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

			e.Handled = true;
		}

		// =============================================================
		// CELL MOUSE ENTER / LEAVE — show a tooltip on disabled buttons
		// Only fires for Occupied rooms in the Actions column.
		// =============================================================
		private void dgvRooms_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			if (e.ColumnIndex < 0) return;
			if (dgvRooms.Columns[e.ColumnIndex].Name != "colActions") return;
			if (_role != "Admin") return;

			string roomNumber = dgvRooms.Rows[e.RowIndex].Cells["colRoomNumber"].Value.ToString();
			Room room = controller.GetRoomByNumber(roomNumber);

			if (room != null && room.Status == "Occupied")
			{
				dgvRooms.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText =
					"Cannot modify — room has an active patient.";
			}
			else
			{
				// Clear any leftover tooltip when not occupied
				dgvRooms.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "";
			}
		}

		private void dgvRooms_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
		{
			// Clear the tooltip when the mouse leaves the cell
			if (e.RowIndex < 0) return;
			if (e.ColumnIndex < 0) return;
			if (dgvRooms.Columns[e.ColumnIndex].Name != "colActions") return;

			dgvRooms.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "";
		}

		// =============================================================
		// CELL CLICK — detect which button was clicked
		// Blocks clicks when the room is Occupied.
		// =============================================================
		private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (_role != "Admin") return;
			if (e.RowIndex < 0) return;
			if (dgvRooms.Columns[e.ColumnIndex].Name != "colActions") return;

			// Get the cell rectangle and mouse position
			Rectangle cellRect = dgvRooms.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
			Point mousePos = dgvRooms.PointToClient(Cursor.Position);

			// Calculate button mid-point
			int padding = 6;
			int gap = 6;
			int buttonWidth = (cellRect.Width - padding * 2 - gap) / 2;
			int midX = cellRect.X + padding + buttonWidth + (gap / 2);

			string roomNumber = dgvRooms.Rows[e.RowIndex].Cells["colRoomNumber"].Value.ToString();
			Room room = controller.GetRoomByNumber(roomNumber);
			if (room == null) return;
			if (room.Status == "Deleted") return;

			// Occupied rooms are locked — both Edit and Delete are disabled
			if (room.Status == "Occupied")
			{
				MessageBox.Show(
					"Cannot modify an occupied room. Discharge the patient first.",
					"Room Occupied",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}

			if (mousePos.X < midX)
			{
				// Edit was clicked
				AddEditRoomForm dialog = new AddEditRoomForm(room);
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					LoadRooms();
				}
			}
			else
			{
				// Delete was clicked
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
}