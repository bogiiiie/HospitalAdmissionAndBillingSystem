using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class AdmissionForm : Form
	{
		private readonly AdmissionController controller = new AdmissionController();
		private readonly LoginPage _loginPage;
		private readonly string _username;
		private readonly string _role;

		// Currently selected patient and room for the admission
		private string _selectedPatientCode;
		private string _selectedPatientDisplay;
		private string _selectedRoomNumber;
		private string _selectedRoomDisplay;

		public AdmissionForm(LoginPage loginPage, string username, string role)
		{
			InitializeComponent();
			_loginPage = loginPage;
			_username = username;
			_role = role;
		}

		public AdmissionForm()
		{
			InitializeComponent();
		}

		private void AdmissionForm_Load(object sender, EventArgs e)
		{
			lblUserInfo.Text = "Logged in as: " + _username + "   |   Role: " + _role;

			// Auto-fill admission date/time
			txtAdmissionDate.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");

			// Admin-only section
			panelAdminOverride.Visible = (_role == "Admin");

			WireSidebarEvents();
			ApplyRoleToSidebar();

			if (_role == "Admin")
				LoadActiveAdmissions();
		}

		// =============================================================
		// SIDEBAR
		// =============================================================
		private void WireSidebarEvents()
		{
			// Current module — do nothing
			btnNavAdmission.Click += (s, e) => { };

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
			btnNavAdmissionLog.Click += (s, e) =>
			{
				AdmissionLogForm form = new AdmissionLogForm(_loginPage, _username, _role);
				form.Show();
				this.Close();
			};
			btnNavTreatment.Click += (s, e) => MessageBox.Show("Treatment / Billing module coming soon.");
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
			};

			visibleButtons.Add(btnNavAdmissionLog);
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
		// FIND PATIENT
		// =============================================================
		private void btnFindPatient_Click(object sender, EventArgs e)
		{
			PatientPickerDialog picker = new PatientPickerDialog();
			if (picker.ShowDialog(this) == DialogResult.OK)
			{
				_selectedPatientCode = picker.SelectedPatientCode;
				_selectedPatientDisplay = picker.SelectedPatientCode + " — " + picker.SelectedPatientName;
				txtSelectedPatient.Text = _selectedPatientDisplay;
			}
		}

		// =============================================================
		// FIND ROOM
		// =============================================================
		private void btnFindRoom_Click(object sender, EventArgs e)
		{
			RoomPickerDialog picker = new RoomPickerDialog();
			if (picker.ShowDialog(this) == DialogResult.OK)
			{
				_selectedRoomNumber = picker.SelectedRoomNumber;
				_selectedRoomDisplay = picker.SelectedRoomNumber + " — " +
									   picker.SelectedRoomType + " — ₱" +
									   picker.SelectedRoomRate.ToString("N2") + "/day";
				txtSelectedRoom.Text = _selectedRoomDisplay;
			}
		}

		// =============================================================
		// CONFIRM ADMISSION
		// =============================================================
		private void btnConfirmAdmission_Click(object sender, EventArgs e)
		{
			string result = controller.AddAdmission(
				_selectedPatientCode,
				_selectedRoomNumber,
				txtDiagnosis.Text,
				_username);

			if (result == "OK")
			{
				MessageBox.Show(
					"Patient admitted successfully.\n\n" +
					"Room " + _selectedRoomNumber + " is now Occupied.",
					"Success",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);

				ResetForm();
			}
			else
			{
				MessageBox.Show(result, "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void ResetForm()
		{
			_selectedPatientCode = null;
			_selectedPatientDisplay = null;
			_selectedRoomNumber = null;
			_selectedRoomDisplay = null;

			txtSelectedPatient.Text = "";
			txtSelectedRoom.Text = "";
			txtDiagnosis.Text = "";
			txtAdmissionDate.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");

			if (_role == "Admin")
				LoadActiveAdmissions();
		}

		// =============================================================
		// ADMIN OVERRIDE — load active admissions
		// =============================================================
		private void LoadActiveAdmissions()
		{
			cmbExistingAdmission.Items.Clear();

			List<Admission> activeAdmissions = controller.GetActiveAdmissions();

			if (activeAdmissions.Count == 0)
			{
				cmbExistingAdmission.Items.Add("(No active admissions)");
				cmbExistingAdmission.SelectedIndex = 0;
				cmbExistingAdmission.Enabled = false;
				btnEditAdmission.Enabled = false;
				return;
			}

			cmbExistingAdmission.Enabled = true;
			btnEditAdmission.Enabled = true;

			foreach (Admission adm in activeAdmissions)
			{
				cmbExistingAdmission.Items.Add(
					adm.AdmissionCode + " — " + adm.PatientCode + " (Room " + adm.RoomNumber + ")");
			}

			cmbExistingAdmission.SelectedIndex = 0;
		}

		// =============================================================
		// ADMIN OVERRIDE — edit existing admission
		// =============================================================
		private void btnEditAdmission_Click(object sender, EventArgs e)
		{
			if (cmbExistingAdmission.SelectedItem == null) return;

			string selected = cmbExistingAdmission.SelectedItem.ToString();

			// Extract the admission code (format: "ADM-0001 — P-0001 (Room 204)")
			string admissionCode = selected.Split(new string[] { " — " }, StringSplitOptions.None)[0];

			Admission adm = controller.GetAdmissionByCode(admissionCode);
			if (adm == null)
			{
				MessageBox.Show("Admission not found.", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			EditAdmissionForm form = new EditAdmissionForm(adm);
			if (form.ShowDialog(this) == DialogResult.OK)
			{
				MessageBox.Show("Admission updated.", "Success",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadActiveAdmissions();
			}
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