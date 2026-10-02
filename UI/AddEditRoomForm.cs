using System;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class AddEditRoomForm : Form
	{
		private readonly RoomController controller = new RoomController();
		private readonly Room _existingRoom;

		// Pass null to add, or an existing Room to edit
		public AddEditRoomForm(Room existingRoom)
		{
			InitializeComponent();
			_existingRoom = existingRoom;
		}

		private void AddEditRoomForm_Load(object sender, EventArgs e)
		{
			if (_existingRoom == null)
			{
				// ADD MODE
				this.Text = "Add Room";
				lblHeader.Text = "Room Management — Add Room";
				cmbStatus.SelectedItem = "Available";
			}
			else
			{
				// EDIT MODE
				this.Text = "Edit Room " + _existingRoom.RoomNumber;
				lblHeader.Text = "Room Management — Edit Room";
				txtRoomNumber.Text = _existingRoom.RoomNumber;
				txtRoomNumber.ReadOnly = true;
				cmbRoomType.Text = _existingRoom.RoomType;
				txtRate.Text = _existingRoom.Rate.ToString();
				cmbStatus.Text = _existingRoom.Status;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			decimal rate;
			if (!decimal.TryParse(txtRate.Text, out rate))
			{
				MessageBox.Show("Rate must be a number.");
				return;
			}

			string result;

			if (_existingRoom == null)
			{
				result = controller.AddRoom(
					txtRoomNumber.Text.Trim(),
					cmbRoomType.Text,
					rate,
					cmbStatus.Text);
			}
			else
			{
				result = controller.UpdateRoom(
					txtRoomNumber.Text.Trim(),
					cmbRoomType.Text,
					rate,
					cmbStatus.Text);
			}

			if (result == "OK")
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show(result, "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}