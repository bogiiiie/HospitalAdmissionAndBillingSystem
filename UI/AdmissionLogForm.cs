using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class AdmissionLogForm : Form
	{
		private readonly AdmissionController admissionController = new AdmissionController();
		private readonly PatientController patientController = new PatientController();
		private readonly LoginPage _loginPage;
		private readonly string _username;
		private readonly string _role;

		public AdmissionLogForm(LoginPage loginPage, string username, string role)
		{
			InitializeComponent();
			_loginPage = loginPage;
			_username = username;
			_role = role;
		}

		public AdmissionLogForm()
		{
			InitializeComponent();
		}

		private void AdmissionLogForm_Load(object sender, EventArgs e)
		{
			// Uniform font across rows
			dgvAdmissions.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvAdmissions.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvAdmissions.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvAdmissions.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

			lblUserInfo.Text = "Logged in as: " + _username + "   |   Role: " + _role;

			// Status dropdown
			cmbStatus.Items.Clear();
			cmbStatus.Items.Add("All");
			cmbStatus.Items.Add("Admitted");
			cmbStatus.Items.Add("Discharged");
			cmbStatus.SelectedIndex = 0;

			// Date pickers — unchecked by default (no date filter)
			dtpFrom.Checked = false;
			dtpTo.Checked = false;
			dtpFrom.Value = DateTime.Today;
			dtpTo.Value = DateTime.Today;

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
			btnNavAdmissionLog.Click += (s, e) => { };

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
				btnNavAdmissionLog,   // now visible for both roles
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

			int y = 48;
			foreach (var btn in visibleButtons)
			{
				btn.Visible = true;
				btn.Top = y;
				y += 44;
			}
		}

		// =============================================================
		// SEARCH / FILTER
		// =============================================================
		private void RunSearch()
		{
			// Validate date range
			if (dtpFrom.Checked && dtpTo.Checked && dtpFrom.Value.Date > dtpTo.Value.Date)
			{
				MessageBox.Show(
					"From date cannot be later than To date.",
					"Invalid Date Range",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}

			// Fetch all admissions
			List<Admission> all = admissionController.GetAllAdmissions();

			// Preload patient names (cache so we don't query per row)
			var patientNames = new Dictionary<string, string>();
			foreach (Admission adm in all)
			{
				if (!patientNames.ContainsKey(adm.PatientCode))
				{
					Patient p = patientController.GetPatientByCode(adm.PatientCode);
					patientNames[adm.PatientCode] = p != null ? p.FullName : "(unknown)";
				}
			}

			string keyword = txtSearch.Text.Trim().ToLower();
			string statusFilter = cmbStatus.SelectedItem != null
				? cmbStatus.SelectedItem.ToString()
				: "All";

			// Filter
			var filtered = new List<Admission>();
			foreach (Admission adm in all)
			{
				// Date range
				if (dtpFrom.Checked && adm.AdmissionDate.Date < dtpFrom.Value.Date) continue;
				if (dtpTo.Checked && adm.AdmissionDate.Date > dtpTo.Value.Date) continue;

				// Status
				if (statusFilter != "All" && adm.Status != statusFilter) continue;

				// Search (patient name, patient code, admission code,
				//         room number, or performed-by username)
				if (!string.IsNullOrWhiteSpace(keyword))
				{
					string pName = patientNames[adm.PatientCode].ToLower();
					string pCode = adm.PatientCode.ToLower();
					string aCode = adm.AdmissionCode.ToLower();
					string room = adm.RoomNumber.ToLower();
					string by = adm.AdmittedBy.ToLower();

					if (!pName.Contains(keyword)
						&& !pCode.Contains(keyword)
						&& !aCode.Contains(keyword)
						&& !room.Contains(keyword)
						&& !by.Contains(keyword))
						continue;
				}

				filtered.Add(adm);
			}

			// Populate grid
			dgvAdmissions.Rows.Clear();
			foreach (Admission adm in filtered)
			{
				dgvAdmissions.Rows.Add(
					adm.AdmissionCode,
					adm.AdmissionDate.ToString("MM/dd/yyyy"),
					patientNames[adm.PatientCode],
					adm.RoomNumber,
					adm.Status,
					adm.AdmittedBy
				);
			}

			lblCount.Text = "Total Results: " + filtered.Count;
		}

		private void btnFilter_Click(object sender, EventArgs e)
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

		// =============================================================
		// ROW DOUBLE-CLICK — open details dialog
		// =============================================================
		private void dgvAdmissions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			string code = dgvAdmissions.Rows[e.RowIndex].Cells["colAdmissionCode"].Value.ToString();
			Admission adm = admissionController.GetAdmissionByCode(code);
			if (adm == null) return;

			new AdmissionDetailsDialog(adm).ShowDialog(this);
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