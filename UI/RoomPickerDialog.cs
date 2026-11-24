using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Controller;
using BusinessLogic.Repository;
using Model;

namespace UI
{
	public partial class RoomPickerDialog : Form
	{
		private readonly RoomController roomController = new RoomController();
		private readonly BedRepository bedRepo = new BedRepository();

		// The selected values (null if cancelled)
		public string SelectedRoomNumber { get; private set; }
		public string SelectedBedName { get; private set; } // NEW
		public decimal SelectedRoomRate { get; private set; }
		public string SelectedRoomType { get; private set; }

		public RoomPickerDialog()
		{
			InitializeComponent();
		}

		private void RoomPickerDialog_Load(object sender, EventArgs e)
		{
			// Force uniform font size across all rows (odd and even)
			dgvRooms.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
			dgvRooms.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
			dgvRooms.AlternatingRowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
			dgvRooms.RowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);

			RunSearch();
		}

		private void RunSearch()
		{
			string keyword = txtSearch.Text.Trim();

			// Fetch all available beds from the repository
			List<Bed> beds = bedRepo.GetAvailableBeds();

			// Filter by keyword (room number or bed name)
			if (!string.IsNullOrWhiteSpace(keyword))
			{
				beds = beds.FindAll(b => b.RoomNumber.Contains(keyword) || b.BedName.Contains(keyword));
			}

			// Populate grid
			dgvRooms.Rows.Clear();
			foreach (Bed b in beds)
			{
				Room r = roomController.GetRoomByNumber(b.RoomNumber);
				if (r == null) continue;

				dgvRooms.Rows.Add(
					b.RoomNumber,
					b.BedName, // NEW
					r.RoomType,
					"₱" + r.Rate.ToString("N2") + "/day",
					b.Status
				);
			}

			lblCount.Text = "Total Results: " + beds.Count;
			lblNoResults.Visible = (beds.Count == 0);
			dgvRooms.Visible = (beds.Count > 0);
			btnSelect.Enabled = false;
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

		private void dgvRooms_SelectionChanged(object sender, EventArgs e)
		{
			btnSelect.Enabled = (dgvRooms.CurrentRow != null);
		}

		private void dgvRooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			ConfirmSelection();
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			ConfirmSelection();
		}

		private void ConfirmSelection()
		{
			if (dgvRooms.CurrentRow == null) return;

			SelectedRoomNumber = dgvRooms.CurrentRow.Cells["colRoomNumber"].Value.ToString();
			SelectedBedName = dgvRooms.CurrentRow.Cells["colBedName"].Value.ToString(); // NEW
			SelectedRoomType = dgvRooms.CurrentRow.Cells["colRoomType"].Value.ToString();

			// Parse the rate back from the display format ("₱1,500.00/day")
			string rateText = dgvRooms.CurrentRow.Cells["colRate"].Value.ToString();
			rateText = rateText.Replace("₱", "").Replace("/day", "").Replace(",", "").Trim();
			decimal rate;
			if (decimal.TryParse(rateText, out rate))
				SelectedRoomRate = rate;

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}