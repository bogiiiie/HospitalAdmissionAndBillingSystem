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
			btnNavPatientSearch.Click += (s, e) => MessageBox.Show("Patient Info Search module coming soon.");
			btnNavRoomSearch.Click += (s, e) => MessageBox.Show("Patient Room Search module coming soon.");
			btnNavAdmission.Click += (s, e) => MessageBox.Show("Admission module coming soon.");
			btnNavAdmissionLog.Click += (s, e) => MessageBox.Show("Admission Log module coming soon.");
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

			// Admission Log is Admin-only
			if (_role == "Admin")
				visibleButtons.Add(btnNavAdmissionLog);

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
					p.ContactNumber,
					""
				);
			}

			lblCount.Text = "Total Patients: " + patients.Count;
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
		// CELL PAINTING — Edit + (Delete or Deactivate)
		// =============================================================
		private void dgvPatients_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex < 0) return;
			if (dgvPatients.Columns[e.ColumnIndex].Name != "colActions") return;

			string patientCode = dgvPatients.Rows[e.RowIndex].Cells["colPatientCode"].Value.ToString();
			Patient patient = controller.GetPatientByCode(patientCode);
			if (patient == null) return;

			bool isAdmin = (_role == "Admin");
			bool isInactive = !patient.IsActive;

			e.PaintBackground(e.CellBounds, true);

			// Layout: two side-by-side buttons
			int padding = 6;
			int gap = 6;
			int buttonWidth = (e.CellBounds.Width - padding * 2 - gap) / 2;
			int buttonHeight = e.CellBounds.Height - padding * 2;

			Rectangle editRect = new Rectangle(
				e.CellBounds.X + padding,
				e.CellBounds.Y + padding,
				buttonWidth,
				buttonHeight);

			Rectangle secondRect = new Rectangle(
				e.CellBounds.X + padding + buttonWidth + gap,
				e.CellBounds.Y + padding,
				buttonWidth,
				buttonHeight);

			// First button: Edit (green) — or Reactivate (blue) when inactive
			Color firstColor = isInactive
				? Color.FromArgb(37, 99, 235)      // blue for Reactivate
				: Color.FromArgb(16, 185, 129);    // green for Edit

			string firstText = isInactive ? "Reactivate" : "Edit";

			// Second button:
			//   Active + Admin  → Delete (red)
			//   Active + Staff  → Deactivate (amber)
			//   Inactive        → (leave blank — no second action)
			bool drawSecond = !isInactive;

			Color secondColor = isAdmin
				? Color.FromArgb(239, 68, 68)      // red for Delete
				: Color.FromArgb(245, 158, 11);    // amber for Deactivate

			string secondText = isAdmin ? "Delete" : "Deactivate";

			// Draw first button
			using (var brush = new SolidBrush(firstColor))
			{
				e.Graphics.FillRectangle(brush, editRect);
			}
			TextRenderer.DrawText(
				e.Graphics,
				firstText,
				new Font("Segoe UI", 9F, FontStyle.Bold),
				editRect,
				Color.White,
				TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

			// Draw second button (if applicable)
			if (drawSecond)
			{
				using (var brush = new SolidBrush(secondColor))
				{
					e.Graphics.FillRectangle(brush, secondRect);
				}
				TextRenderer.DrawText(
					e.Graphics,
					secondText,
					new Font("Segoe UI", 9F, FontStyle.Bold),
					secondRect,
					Color.White,
					TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
			}

			e.Handled = true;
		}

		// =============================================================
		// CELL CLICK
		// =============================================================
		private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			if (dgvPatients.Columns[e.ColumnIndex].Name != "colActions") return;

			string patientCode = dgvPatients.Rows[e.RowIndex].Cells["colPatientCode"].Value.ToString();
			Patient patient = controller.GetPatientByCode(patientCode);
			if (patient == null) return;

			Rectangle cellRect = dgvPatients.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
			Point mousePos = dgvPatients.PointToClient(Cursor.Position);

			int padding = 6;
			int gap = 6;
			int buttonWidth = (cellRect.Width - padding * 2 - gap) / 2;
			int midX = cellRect.X + padding + buttonWidth + (gap / 2);

			bool isAdmin = (_role == "Admin");
			bool isInactive = !patient.IsActive;
			bool firstClicked = (mousePos.X < midX);

			if (isInactive)
			{
				// Only one action — Reactivate
				if (firstClicked)
				{
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
				return;
			}

			// Active patient — two buttons
			if (firstClicked)
			{
				// Edit
				AddEditPatientForm dialog = new AddEditPatientForm(patient);
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					LoadPatients();
				}
			}
			else
			{
				// Second button — Delete (Admin) or Deactivate (Staff)
				if (isAdmin)
				{
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
				else
				{
					// Staff — Deactivate
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