using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class DischargedPatientPickerDialog : Form
	{
		private readonly AdmissionController admissionController = new AdmissionController();
		private readonly PatientController patientController = new PatientController();

		public string SelectedAdmissionCode { get; private set; }
		public string SelectedDisplayText { get; private set; }

		public DischargedPatientPickerDialog() { InitializeComponent(); }

		private void DischargedPatientPickerDialog_Load(object sender, EventArgs e)
		{
			dgvAdmissions.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvAdmissions.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvAdmissions.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvAdmissions.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			RunSearch();
		}

		private void RunSearch()
		{
			string keyword = txtSearch.Text.Trim().ToLower();
			List<Admission> list = admissionController.GetDischargedAdmissions();

			dgvAdmissions.Rows.Clear();
			foreach (Admission adm in list)
			{
				Patient p = patientController.GetPatientByCode(adm.PatientCode);
				string patientName = p != null ? p.FullName : "(unknown)";

				if (!string.IsNullOrWhiteSpace(keyword))
				{
					if (!adm.AdmissionCode.ToLower().Contains(keyword) &&
						!adm.PatientCode.ToLower().Contains(keyword) &&
						!patientName.ToLower().Contains(keyword)) continue;
				}

				dgvAdmissions.Rows.Add(adm.AdmissionCode, patientName, adm.RoomNumber, adm.DischargeDate?.ToString("MM/dd/yyyy hh:mm tt") ?? "—");
			}

			lblCount.Text = "Total Results: " + dgvAdmissions.Rows.Count;
			lblNoResults.Visible = (dgvAdmissions.Rows.Count == 0);
			dgvAdmissions.Visible = (dgvAdmissions.Rows.Count > 0);
			btnSelect.Enabled = false;
		}

		private void btnSearch_Click(object sender, EventArgs e) => RunSearch();
		private void txtSearch_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) { RunSearch(); e.SuppressKeyPress = true; } }
		private void dgvAdmissions_SelectionChanged(object sender, EventArgs e) => btnSelect.Enabled = (dgvAdmissions.CurrentRow != null);
		private void dgvAdmissions_CellDoubleClick(object sender, DataGridViewCellEventArgs e) { if (e.RowIndex >= 0) ConfirmSelection(); }
		private void btnSelect_Click(object sender, EventArgs e) => ConfirmSelection();

		private void ConfirmSelection()
		{
			if (dgvAdmissions.CurrentRow == null) return;
			SelectedAdmissionCode = dgvAdmissions.CurrentRow.Cells["colAdmissionCode"].Value.ToString();
			string name = dgvAdmissions.CurrentRow.Cells["colPatientName"].Value.ToString();
			SelectedDisplayText = SelectedAdmissionCode + " — " + name;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; this.Close(); }
	}
}