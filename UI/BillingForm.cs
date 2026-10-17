using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class BillingForm : Form
	{
		private readonly BillController billController = new BillController();
		private readonly LoginPage _loginPage;
		private readonly string _username;
		private readonly string _role;

		private string _selectedAdmissionCode;
		private decimal _currentTotalDue = 0m;
		private Bill _existingBill = null;
		private bool _isReadOnly = false;

		public BillingForm(LoginPage loginPage, string username, string role)
		{
			InitializeComponent();
			_loginPage = loginPage;
			_username = username;
			_role = role;
		}

		public BillingForm()
		{
			InitializeComponent();
		}

		private void BillingForm_Load(object sender, EventArgs e)
		{
			lblUserInfo.Text = "Logged in as: " + _username + "   |   Role: " + _role;

			// Role-based setup
			if (_role == "Admin")
			{
				cmbDiscountType.Visible = true;
				txtDiscountValue.Visible = true;
				cmbDiscountReason.Visible = true;
				lblDiscountType.Visible = true;
				lblDiscountReason.Visible = true;
				lblDiscountDisplay.Visible = false;
				btnSaveDraft.Visible = true;

				cmbDiscountType.SelectedIndex = 1; // Default to Amount
			}
			else
			{
				cmbDiscountType.Visible = false;
				txtDiscountValue.Visible = false;
				cmbDiscountReason.Visible = false;
				lblDiscountType.Visible = false;
				lblDiscountReason.Visible = false;
				lblDiscountDisplay.Visible = true;
				btnSaveDraft.Visible = false;
			}

			WireSidebarEvents();
			ApplyRoleToSidebar();
			SetBillingState(false);
		}

		private void SetBillingState(bool hasAdmission)
		{
			panelBreakdown.Visible = hasAdmission;
			panelPayment.Visible = hasAdmission;
			lblNoResults.Visible = !hasAdmission;

			if (!hasAdmission)
			{
				_selectedAdmissionCode = null;
				txtSelectedAdmission.Text = "";
				_existingBill = null;
				_isReadOnly = false;
			}
		}

		private void btnFindAdmission_Click(object sender, EventArgs e)
		{
			AdmissionPickerDialog picker = new AdmissionPickerDialog();
			if (picker.ShowDialog(this) == DialogResult.OK)
			{
				_selectedAdmissionCode = picker.SelectedAdmissionCode;
				txtSelectedAdmission.Text = picker.SelectedDisplayText;
				LoadBillingData();
			}
		}

		private void LoadBillingData()
		{
			SetBillingState(true);
			_existingBill = billController.GetBill(_selectedAdmissionCode);

			if (_existingBill != null)
			{
				// Existing Bill Found
				lblRoomCharges.Text = "₱" + _existingBill.RoomCharges.ToString("N2");
				lblTreatmentCharges.Text = "₱" + _existingBill.TreatmentCharges.ToString("N2");
				lblTotalDue.Text = "₱" + _existingBill.TotalDue.ToString("N2");
				_currentTotalDue = _existingBill.TotalDue;

				if (_existingBill.Status == "Paid")
				{
					_isReadOnly = true;
					txtSelectedAdmission.ReadOnly = true;
					btnFindAdmission.Enabled = false;
					btnSaveDraft.Enabled = false;
					btnFinalize.Enabled = false;
					txtAmountPaid.ReadOnly = true;

					txtAmountPaid.Text = _existingBill.AmountPaid.ToString("N2");
					lblChangeValue.Text = "₱" + _existingBill.Change.ToString("N2");

					if (_role == "Admin")
					{
						txtDiscountValue.Text = _existingBill.DiscountValue.ToString("N2");
						cmbDiscountType.Text = _existingBill.DiscountType;
						cmbDiscountReason.Text = _existingBill.DiscountReason;
						txtDiscountValue.ReadOnly = true;
						cmbDiscountType.Enabled = false;
						cmbDiscountReason.Enabled = false;
					}
					else
					{
						lblDiscountDisplay.Text = $"Discount Applied: ₱{_existingBill.DiscountComputed:N2} ({_existingBill.DiscountReason})";
					}

					MessageBox.Show("This bill has already been finalized and paid.", "Read-Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					// Draft Bill
					if (_role == "Admin")
					{
						txtDiscountValue.Text = _existingBill.DiscountValue.ToString("N2");
						cmbDiscountType.Text = _existingBill.DiscountType;
						cmbDiscountReason.Text = _existingBill.DiscountReason;
					}
					else
					{
						lblDiscountDisplay.Text = $"Discount Applied: ₱{_existingBill.DiscountComputed:N2} ({_existingBill.DiscountReason})";
					}
				}
			}
			else
			{
				// No bill yet. Calculate base charges.
				_isReadOnly = false;
				btnFindAdmission.Enabled = true;
				txtSelectedAdmission.ReadOnly = true;
				btnSaveDraft.Enabled = true;
				btnFinalize.Enabled = true;
				txtAmountPaid.ReadOnly = false;
				txtAmountPaid.Text = "";
				lblChangeValue.Text = "₱0.00";

				if (_role == "Admin")
				{
					txtDiscountValue.Text = "0.00";
					cmbDiscountReason.Text = "";
					txtDiscountValue.ReadOnly = false;
					cmbDiscountType.Enabled = true;
					cmbDiscountReason.Enabled = true;
					DiscountChanged(null, null);
				}
				else
				{
					lblDiscountDisplay.Text = "Discount Applied: ₱0.00";
					RecalculateTotal(0);
				}
			}
		}

		private void DiscountChanged(object sender, EventArgs e)
		{
			if (_role != "Admin" || _isReadOnly) return;

			decimal discountVal = 0m;
			decimal.TryParse(txtDiscountValue.Text, out discountVal);

			string result = billController.CalculateTotals(_selectedAdmissionCode, cmbDiscountType.Text, discountVal,
				out decimal room, out decimal treat, out decimal discComp, out decimal total);

			if (result != "OK")
			{
				// Ignore error while typing, just don't update total
				return;
			}

			lblRoomCharges.Text = "₱" + room.ToString("N2");
			lblTreatmentCharges.Text = "₱" + treat.ToString("N2");
			lblTotalDue.Text = "₱" + total.ToString("N2");
			_currentTotalDue = total;

			CalculateChange();
		}

		private void RecalculateTotal(decimal discount)
		{
			string result = billController.CalculateTotals(_selectedAdmissionCode, "Amount", discount,
				out decimal room, out decimal treat, out decimal discComp, out decimal total);

			lblRoomCharges.Text = "₱" + room.ToString("N2");
			lblTreatmentCharges.Text = "₱" + treat.ToString("N2");
			lblTotalDue.Text = "₱" + total.ToString("N2");
			_currentTotalDue = total;
		}

		private void txtAmountPaid_TextChanged(object sender, EventArgs e)
		{
			CalculateChange();
		}

		private void CalculateChange()
		{
			decimal paid = 0m;
			decimal.TryParse(txtAmountPaid.Text, out paid);

			decimal change = paid - _currentTotalDue;
			if (change < 0) change = 0;
			lblChangeValue.Text = "₱" + change.ToString("N2");
		}

		private void btnSaveDraft_Click(object sender, EventArgs e)
		{
			decimal discVal = 0m;
			decimal.TryParse(txtDiscountValue.Text, out discVal);

			Bill b = new Bill
			{
				BillCode = _existingBill != null ? _existingBill.BillCode : "",
				AdmissionCode = _selectedAdmissionCode,
				RoomCharges = decimal.Parse(lblRoomCharges.Text.Replace("₱", "").Replace(",", "")),
				TreatmentCharges = decimal.Parse(lblTreatmentCharges.Text.Replace("₱", "").Replace(",", "")),
				DiscountType = cmbDiscountType.Text,
				DiscountValue = discVal,
				DiscountReason = cmbDiscountReason.Text,
				DiscountComputed = (decimal.Parse(lblRoomCharges.Text.Replace("₱", "").Replace(",", "").Trim()) + decimal.Parse(lblTreatmentCharges.Text.Replace("₱", "").Replace(",", "").Trim())) - _currentTotalDue,
				TotalDue = _currentTotalDue,
				ProcessedBy = _username
			};

			string result = billController.ProcessBill(b, false, 0);
			if (result == "OK")
			{
				MessageBox.Show("Bill saved as Draft. Cashier can finalize this later.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadBillingData();
			}
			else
			{
				MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnFinalize_Click(object sender, EventArgs e)
		{
			decimal paid = 0m;
			if (!decimal.TryParse(txtAmountPaid.Text, out paid))
			{
				MessageBox.Show("Please enter a valid payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (MessageBox.Show($"Confirm processing payment of ₱{paid:N2} for a total due of ₱{_currentTotalDue:N2}? This cannot be undone.", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
				return;

			decimal discVal = 0m;
			decimal.TryParse(txtDiscountValue.Text, out discVal);

			Bill b = new Bill
			{
				BillCode = _existingBill != null ? _existingBill.BillCode : "",
				AdmissionCode = _selectedAdmissionCode,
				RoomCharges = decimal.Parse(lblRoomCharges.Text.Replace("₱", "").Replace(",", "")),
				TreatmentCharges = decimal.Parse(lblTreatmentCharges.Text.Replace("₱", "").Replace(",", "")),
				DiscountType = _role == "Admin" ? cmbDiscountType.Text : (_existingBill != null ? _existingBill.DiscountType : "Amount"),
				DiscountValue = _role == "Admin" ? discVal : (_existingBill != null ? _existingBill.DiscountValue : 0),
				DiscountReason = _role == "Admin" ? cmbDiscountReason.Text : (_existingBill != null ? _existingBill.DiscountReason : ""),
				DiscountComputed = _existingBill != null ? _existingBill.DiscountComputed : 0, // If no existing bill, discount is 0
				TotalDue = _currentTotalDue,
				ProcessedBy = _username
			};

			if (_existingBill == null && _role == "Admin")
			{
				b.DiscountComputed = b.RoomCharges + b.TreatmentCharges - b.TotalDue;
			}

			string result = billController.ProcessBill(b, true, paid);
			if (result == "OK")
			{
				MessageBox.Show("Payment finalized. The patient is now cleared for discharge.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadBillingData(); // Reloads as Read-Only
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
			btnNavBilling.Click += (s, e) => { };
			btnNavRoom.Click += (s, e) => { new RoomManagementForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavPatient.Click += (s, e) => { new PatientInformationForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavPatientSearch.Click += (s, e) => { new PatientInfoSearchForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavRoomSearch.Click += (s, e) => { new PatientRoomSearchForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavAdmission.Click += (s, e) => { new AdmissionForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavAdmissionLog.Click += (s, e) => { new AdmissionLogForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavTreatment.Click += (s, e) => { new TreatmentBillingForm(_loginPage, _username, _role).Show(); this.Close(); };
			btnNavDoctorNurse.Click += (s, e) => { new DoctorNurseAssignmentForm(_loginPage, _username, _role).Show(); this.Close(); };
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

			if (_role == "Admin")
			{
				visibleButtons.Insert(7, btnNavDoctorNurse);
			}

			btnNavRoom.Visible = false; btnNavPatient.Visible = false; btnNavPatientSearch.Visible = false;
			btnNavRoomSearch.Visible = false; btnNavAdmission.Visible = false; btnNavAdmissionLog.Visible = false;
			btnNavTreatment.Visible = false; btnNavDoctorNurse.Visible = false; btnNavBilling.Visible = false;
			btnNavDischarge.Visible = false; btnNavSummary.Visible = false;

			int y = 48;
			foreach (var btn in visibleButtons)
			{
				btn.Visible = true;
				btn.Top = y;
				y += 44;
			}
		}

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