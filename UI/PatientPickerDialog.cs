using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class PatientPickerDialog : Form
	{
		private readonly PatientController patientController = new PatientController();
		private readonly AdmissionController admissionController = new AdmissionController();

		// The selected patient code (null if cancelled)
		public string SelectedPatientCode { get; private set; }
		public string SelectedPatientName { get; private set; }

		public PatientPickerDialog()
		{
			InitializeComponent();
		}

		private void PatientPickerDialog_Load(object sender, EventArgs e)
		{
			// Force uniform font size across all rows (odd and even)
			dgvPatients.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
			dgvPatients.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
			dgvPatients.AlternatingRowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
			dgvPatients.RowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);

			RunSearch();
		}

		private void RunSearch()
		{
			string keyword = txtSearch.Text.Trim();

			// Fetch active patients
			List<Patient> patients = patientController.SearchPatients(keyword, "Active");

			// Build a set of patient codes who currently have an active admission
			HashSet<string> admittedCodes = new HashSet<string>();
			foreach (Admission adm in admissionController.GetActiveAdmissions())
			{
				admittedCodes.Add(adm.PatientCode);
			}

			// Exclude patients already admitted
			patients = patients.FindAll(p => !admittedCodes.Contains(p.PatientCode));

			// Populate grid
			dgvPatients.Rows.Clear();
			foreach (Patient p in patients)
			{
				dgvPatients.Rows.Add(p.PatientCode, p.FullName, p.Gender, p.ContactNumber);
			}

			lblCount.Text = "Total Results: " + patients.Count;
			lblNoResults.Visible = (patients.Count == 0);
			dgvPatients.Visible = (patients.Count > 0);
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

		private void dgvPatients_SelectionChanged(object sender, EventArgs e)
		{
			btnSelect.Enabled = (dgvPatients.CurrentRow != null);
		}

		private void dgvPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
			if (dgvPatients.CurrentRow == null) return;

			SelectedPatientCode = dgvPatients.CurrentRow.Cells["colPatientCode"].Value.ToString();
			SelectedPatientName = dgvPatients.CurrentRow.Cells["colFullName"].Value.ToString();

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