using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class TreatmentBillingForm : Form
	{
		private readonly TreatmentController treatmentController = new TreatmentController();
		private readonly LoginPage _loginPage;
		private readonly string _username;
		private readonly string _role;

		private string _selectedAdmissionCode;

		public TreatmentBillingForm(LoginPage loginPage, string username, string role)
		{
			InitializeComponent();
			_loginPage = loginPage;
			_username = username;
			_role = role;
		}

		public TreatmentBillingForm()
		{
			InitializeComponent();
		}

		private void TreatmentBillingForm_Load(object sender, EventArgs e)
		{
			// Uniform fonts
			dgvTreatments.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvTreatments.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvTreatments.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
			dgvTreatments.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

			lblUserInfo.Text = "Logged in as: " + _username + "   |   Role: " + _role;

			// Role-based UI
			if (_role == "Admin")
			{
				lblAddTitle.Text = "── ADD TREATMENT (View-only for Admin) ──";
				txtServiceName.Enabled = false;
				numQuantity.Enabled = false;
				txtUnitCost.Enabled = false;
				btnAddItem.Enabled = false;
			}

			WireSidebarEvents();
			ApplyRoleToSidebar();
			SetAdmissionState(false);
		}

		private void SetAdmissionState(bool hasAdmission)
		{
			if (!hasAdmission)
			{
				_selectedAdmissionCode = null;
				txtSelectedAdmission.Text = "";
				dgvTreatments.Rows.Clear();
				lblNoResults.Visible = true;
				dgvTreatments.Visible = false;
				lblSubtotal.Text = "Subtotal: ₱0.00";
			}
			else
			{
				lblNoResults.Visible = false;
				dgvTreatments.Visible = true;
			}
		}

		private void btnFindAdmission_Click(object sender, EventArgs e)
		{
			AdmissionPickerDialog picker = new AdmissionPickerDialog();
			if (picker.ShowDialog(this) == DialogResult.OK)
			{
				_selectedAdmissionCode = picker.SelectedAdmissionCode;
				txtSelectedAdmission.Text = picker.SelectedDisplayText;
				LoadTreatments();
			}
		}

		private void LoadTreatments()
		{
			if (string.IsNullOrEmpty(_selectedAdmissionCode)) return;

			List<Treatment> list = treatmentController.GetTreatments(_selectedAdmissionCode);
			dgvTreatments.Rows.Clear();

			decimal subtotal = 0m;

			foreach (Treatment t in list)
			{
				dgvTreatments.Rows.Add(
					t.ServiceName,
					t.TreatmentDate.ToString("MM/dd/yyyy"),
					t.Quantity,
					"₱" + t.UnitCost.ToString("N2"),
					"₱" + t.TotalCost.ToString("N2")
				);
				subtotal += t.TotalCost;
			}

			lblSubtotal.Text = "Subtotal: ₱" + subtotal.ToString("N2");
			SetAdmissionState(true);
		}

		private void btnAddItem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_selectedAdmissionCode))
			{
				MessageBox.Show("Please select an active admission first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			decimal cost;
			if (!decimal.TryParse(txtUnitCost.Text, out cost))
			{
				MessageBox.Show("Unit cost must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string result = treatmentController.AddTreatment(
				_selectedAdmissionCode,
				txtServiceName.Text,
				(int)numQuantity.Value,
				cost,
				_username
			);

			if (result == "OK")
			{
				txtServiceName.Text = "";
				numQuantity.Value = 1;
				txtUnitCost.Text = "";
				LoadTreatments();
			}
			else
			{
				MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		// =============================================================
		// SIDEBAR
		// =============================================================
		private void WireSidebarEvents()
		{
			btnNavTreatment.Click += (s, e) => { };
			btnNavRoom.Click += (s, e) => { new RoomManagementForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavPatient.Click += (s, e) => { new PatientInformationForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavPatientSearch.Click += (s, e) => { new PatientInfoSearchForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavRoomSearch.Click += (s, e) => { new PatientRoomSearchForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavAdmission.Click += (s, e) => { new AdmissionForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavAdmissionLog.Click += (s, e) => { new AdmissionLogForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavBilling.Click += (s, e) => MessageBox.Show("Billing module coming soon.");
			btnNavDischarge.Click += (s, e) => MessageBox.Show("Discharge module coming soon.");
			btnNavSummary.Click += (s, e) => MessageBox.Show("Discharge Summary module coming soon.");
		}

		private void ApplyRoleToSidebar()
		{
			var visibleButtons = new List<Button>
			{
				btnNavRoom, btnNavPatient, btnNavPatientSearch, btnNavRoomSearch,
				btnNavAdmission, btnNavAdmissionLog, btnNavTreatment, btnNavBilling,
				btnNavDischarge, btnNavSummary
			};

			btnNavRoom.Visible = false; btnNavPatient.Visible = false; btnNavPatientSearch.Visible = false;
			btnNavRoomSearch.Visible = false; btnNavAdmission.Visible = false; btnNavAdmissionLog.Visible = false;
			btnNavTreatment.Visible = false; btnNavBilling.Visible = false; btnNavDischarge.Visible = false;
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
		// HEADER
		// =============================================================
		private void btnMainMenu_Click(object sender, EventArgs e)
		{
			if (_role == "Admin") new AdminMenuForm(_loginPage, _username, _role).Show();
			else new HospitalStaffMenuForm(_loginPage, _username, _role).Show();
			this.Close();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (_loginPage != null) _loginPage.Show();
				this.Close();
			}
		}
	}
}