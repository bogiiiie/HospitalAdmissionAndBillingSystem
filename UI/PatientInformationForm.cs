using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class PatientInformationForm : Form
	{
		private readonly PatientController controller = new PatientController();
		private readonly LoginPage _loginPage;
		private readonly string _username;
		private readonly string _role;

		// Used by menu buttons to pass login context
		public PatientInformationForm(LoginPage loginPage, string username, string role)
		{
			InitializeComponent();
			_loginPage = loginPage;
			_username = username;
			_role = role;
		}

		// Used by the Designer
		public PatientInformationForm()
		{
			InitializeComponent();
		}

		private void PatientInformationForm_Load(object sender, EventArgs e)
		{
			dgvPatients.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvPatients.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvPatients.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvPatients.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			lblUserInfo.Text = "Logged in as: " + _username + "   |   Role: " + _role;

			// Filter dropdown
			cmbFilter.Items.Clear();
			cmbFilter.Items.Add("Active");
			cmbFilter.Items.Add("Inactive");
			cmbFilter.Items.Add("All");
			cmbFilter.SelectedIndex = 0;   // default to Active

			// Role note under the grid
			if (_role == "Admin")
				lblRoleNote.Text = "Admin can permanently delete only if no admission and billing history exist.";
			else
				lblRoleNote.Text = "Staff can add/edit and mark inactive, but cannot permanently delete records.";

			// Setup Buttons based on Role
			btnDeleteSelected.Visible = (_role == "Admin");
			btnDeactivateSelected.Visible = (_role != "Admin");

			WireSidebarEvents();
			ApplyRoleToSidebar();
			LoadPatients();
		}

		// =============================================================
		// SIDEBAR
		// =============================================================
		private void WireSidebarEvents()
		{
			// Current module — do nothing
			btnNavPatient.Click += (s, e) => { };

			// Other modules — placeholders for now
			btnNavRoom.Click += (s, e) =>
			{
				RoomManagementForm form = new RoomManagementForm(_loginPage, _username, _role);
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

			// Admission Log is Admin-only
			visibleButtons.Add(btnNavAdmissionLog);

			// Doctor / Nurse is Admin-only
			if (_role == "Admin")
			{
				visibleButtons.Add(btnNavDoctorNurse);
			}

			visibleButtons.Add(btnNavTreatment);
			visibleButtons.Add(btnNavBilling);
			visibleButtons.Add(btnNavDischarge);
			visibleButtons.Add(btnNavSummary);

			// Hide all first
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

			// Re-show visible ones and stack tightly
			int y = 48;
			foreach (var btn in visibleButtons)
			{
				btn.Visible = true;
				btn.Top = y;
				y += 44;
			}
		}

		// =============================================================
		// LOAD PATIENTS
		// =============================================================
		private void LoadPatients()
		{
			string filter = cmbFilter.SelectedItem != null ? cmbFilter.SelectedItem.ToString() : "Active";
			string keyword = txtSearch.Text.Trim();

			List<Patient> patients;

			if (string.IsNullOrWhiteSpace(keyword))
				patients = controller.GetAllPatients(filter);
			else
				patients = controller.SearchPatients(keyword, filter);

			dgvPatients.Rows.Clear();

			foreach (Patient p in patients)
			{
				dgvPatients.Rows.Add(
					p.PatientCode,
					p.FullName,
					p.DateOfBirth.ToString("MM/dd/yyyy"),
					p.ContactNumber
				);
			}

			lblCount.Text = "Total Patients: " + patients.Count;

			// Reset selection
			dgvPatients.ClearSelection();
			UpdateActionButtons();
		}

		// =============================================================
		// FILTER / SEARCH
		// =============================================================
		private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadPatients();
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			LoadPatients();
		}

		// =============================================================
		// SELECTION CHANGED — Enable/Disable buttons based on selected row
		// =============================================================
		private void dgvPatients_SelectionChanged(object sender, EventArgs e)
		{
			UpdateActionButtons();
		}

		private void UpdateActionButtons()
		{
			if (dgvPatients.CurrentRow == null)
			{
				btnEditSelected.Enabled = false;
				btnDeactivateSelected.Enabled = false;
				btnDeleteSelected.Enabled = false;
				btnReactivateSelected.Visible = false;
				return;
			}

			string patientCode = dgvPatients.CurrentRow.Cells["colPatientCode"].Value.ToString();
			Patient patient = controller.GetPatientByCode(patientCode);
			if (patient == null) return;

			bool isAdmin = (_role == "Admin");
			bool isInactive = !patient.IsActive;

			if (isInactive)
			{
				btnEditSelected.Visible = false;
				btnDeactivateSelected.Visible = false;
				btnDeleteSelected.Visible = false;

				if (isAdmin)
				{
					btnReactivateSelected.Visible = true;
					btnReactivateSelected.Enabled = true;
				}
			}
			else
			{
				btnReactivateSelected.Visible = false;
				btnEditSelected.Visible = true;
				btnEditSelected.Enabled = true;

				if (isAdmin)
				{
					btnDeleteSelected.Visible = true;
					btnDeleteSelected.Enabled = true;
					btnDeactivateSelected.Visible = false;
				}
				else
				{
					btnDeleteSelected.Visible = false;
					btnDeactivateSelected.Visible = true;
					btnDeactivateSelected.Enabled = true;
				}
			}
		}

		// =============================================================
		// BUTTON CLICKS
		// =============================================================
		private void btnEditSelected_Click(object sender, EventArgs e)
		{
			if (dgvPatients.CurrentRow == null) return;
			string patientCode = dgvPatients.CurrentRow.Cells["colPatientCode"].Value.ToString();
			Patient patient = controller.GetPatientByCode(patientCode);
			if (patient == null) return;

			AddEditPatientForm dialog = new AddEditPatientForm(patient);
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				LoadPatients();
			}
		}

		private void btnDeactivateSelected_Click(object sender, EventArgs e)
		{
			if (dgvPatients.CurrentRow == null) return;
			string patientCode = dgvPatients.CurrentRow.Cells["colPatientCode"].Value.ToString();
			Patient patient = controller.GetPatientByCode(patientCode);

			DialogResult confirm = MessageBox.Show(
				"Deactivate " + patient.FullName + "?\n\n" +
				"The record will be hidden but admission and billing history is kept.",
				"Confirm Deactivate",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (confirm == DialogResult.Yes)
			{
				string result = controller.DeactivatePatient(patientCode);
				if (result == "OK")
				{
					MessageBox.Show("Patient marked inactive.", "Success",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadPatients();
				}
				else
				{
					MessageBox.Show(result, "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void btnDeleteSelected_Click(object sender, EventArgs e)
		{
			if (dgvPatients.CurrentRow == null) return;
			string patientCode = dgvPatients.CurrentRow.Cells["colPatientCode"].Value.ToString();
			Patient patient = controller.GetPatientByCode(patientCode);

			DialogResult confirm = MessageBox.Show(
				"Permanently delete " + patient.FullName + "?\n\n" +
				"This will only succeed if the patient has no admission or billing history.",
				"Confirm Permanent Delete",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (confirm == DialogResult.Yes)
			{
				string result = controller.DeletePatient(patientCode);
				if (result == "OK")
				{
					MessageBox.Show("Patient permanently deleted.", "Success",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadPatients();
				}
				else
				{
					// If delete was blocked due to history, offer to deactivate instead
					DialogResult deact = MessageBox.Show(result + "\n\nMark as inactive instead?",
						"Delete Blocked",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Warning);

					if (deact == DialogResult.Yes)
					{
						string res2 = controller.DeactivatePatient(patientCode);
						if (res2 == "OK")
						{
							MessageBox.Show("Patient marked inactive.", "Success",
								MessageBoxButtons.OK, MessageBoxIcon.Information);
							LoadPatients();
						}
						else
						{
							MessageBox.Show(res2, "Error",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}
			}
		}

		private void btnReactivateSelected_Click(object sender, EventArgs e)
		{
			if (dgvPatients.CurrentRow == null) return;
			string patientCode = dgvPatients.CurrentRow.Cells["colPatientCode"].Value.ToString();
			Patient patient = controller.GetPatientByCode(patientCode);

			DialogResult confirm = MessageBox.Show(
				"Reactivate " + patient.FullName + "?",
				"Confirm Reactivate",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (confirm == DialogResult.Yes)
			{
				string result = controller.ReactivatePatient(patientCode);
				if (result == "OK")
				{
					MessageBox.Show("Patient reactivated.", "Success",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadPatients();
				}
				else
				{
					MessageBox.Show(result, "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		// =============================================================
		// ADD
		// =============================================================
		private void btnAdd_Click(object sender, EventArgs e)
		{
			AddEditPatientForm dialog = new AddEditPatientForm(null);
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				LoadPatients();
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