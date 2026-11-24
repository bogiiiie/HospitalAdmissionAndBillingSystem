using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class AddEditPatientForm : Form
	{
		private readonly PatientController controller = new PatientController();
		private readonly Patient _existingPatient;

		// Pass null to add, or an existing Patient to edit
		public AddEditPatientForm(Patient existingPatient)
		{
			InitializeComponent();
			_existingPatient = existingPatient;
		}

		private void AddEditPatientForm_Load(object sender, EventArgs e)
		{
			// Wire up the new event handler for the checkbox
			chkNotFullyRegistered.CheckedChanged += chkNotFullyRegistered_CheckedChanged;

			if (_existingPatient == null)
			{
				// ADD MODE
				this.Text = "Add Patient";
				lblHeader.Text = "Patient Maintenance — Add Patient";

				// Default guardian values — treat as self/alone initially
				txtGuardianName.Text = "Self — Patient arrived alone";
				cmbRelationship.Text = "Self";
				chkGuardianPresent.Checked = false;
				chkNotFullyRegistered.Checked = false;
			}
			else
			{
				// EDIT MODE
				this.Text = "Edit Patient " + _existingPatient.PatientCode;
				lblHeader.Text = "Patient Maintenance — Edit Patient";

				txtFirstName.Text = _existingPatient.FirstName;
				txtMiddleName.Text = _existingPatient.MiddleName;
				txtLastName.Text = _existingPatient.LastName;
				dtpDOB.Value = _existingPatient.DateOfBirth;
				cmbGender.Text = _existingPatient.Gender;
				txtContact.Text = _existingPatient.ContactNumber;
				txtAddress.Text = _existingPatient.Address;
				cmbCivilStatus.Text = _existingPatient.CivilStatus;
				txtOccupation.Text = _existingPatient.Occupation;

				txtGuardianName.Text = _existingPatient.GuardianName;
				cmbRelationship.Text = _existingPatient.GuardianRelationship;
				txtGuardianContact.Text = _existingPatient.GuardianContact;
				txtGuardianAddress.Text = _existingPatient.GuardianAddress;
				chkGuardianPresent.Checked = _existingPatient.GuardianPresent;

				txtEmergencyName.Text = _existingPatient.EmergencyContactName;
				txtEmergencyContact.Text = _existingPatient.EmergencyContactNumber;

				// Auto-tick minor based on age
				chkMinor.Checked = _existingPatient.Age < 18;

				// Load fully registered status
				chkNotFullyRegistered.Checked = !_existingPatient.IsFullyRegistered;
			}
		}

		// =============================================================
		// Auto-fill logic when "Not Fully Registered" is checked
		// =============================================================
		private void chkNotFullyRegistered_CheckedChanged(object sender, EventArgs e)
		{
			if (chkNotFullyRegistered.Checked)
			{
				// The patient is unconscious/unable to speak.
				// Auto-fill required fields with defaults so validation passes.

				// 1. Patient Info
				if (string.IsNullOrWhiteSpace(txtFirstName.Text)) txtFirstName.Text = "Unknown";
				if (string.IsNullOrWhiteSpace(txtMiddleName.Text)) txtMiddleName.Text = "Unknown";
				if (string.IsNullOrWhiteSpace(txtLastName.Text)) txtLastName.Text = "Unknown";

				// NEW: Set default Date of Birth to 1900-01-01 (Placeholder)
				dtpDOB.Value = new DateTime(1900, 1, 1);

				// Use a 7-digit dummy number to pass minimum length validation
				if (string.IsNullOrWhiteSpace(txtContact.Text)) txtContact.Text = "000-0000";

				if (string.IsNullOrWhiteSpace(txtAddress.Text)) txtAddress.Text = "Unknown";
				if (string.IsNullOrWhiteSpace(cmbGender.Text)) cmbGender.SelectedIndex = 2; // "Other"
				if (string.IsNullOrWhiteSpace(txtOccupation.Text)) txtOccupation.Text = "Unknown";

				// 2. Guardian Info (since they are alone/unconscious)
				if (string.IsNullOrWhiteSpace(txtGuardianName.Text) || txtGuardianName.Text == "Self — Patient arrived alone")
					txtGuardianName.Text = "Unknown";

				if (string.IsNullOrWhiteSpace(cmbRelationship.Text))
					cmbRelationship.SelectedIndex = 8; // "Other" or whatever is closest

				// Use a 7-digit dummy number for guardian contact
				if (string.IsNullOrWhiteSpace(txtGuardianContact.Text))
					txtGuardianContact.Text = "000-0000";

				// 3. Automatically tick the "Unable to provide information" box
				chkUnable.Checked = true;
			}
			else
			{
				// Unchecking the box clears the default "Unknown" values 
				// so the user can type the real information.
				if (txtFirstName.Text == "Unknown") txtFirstName.Text = "";
				if (txtMiddleName.Text == "Unknown") txtMiddleName.Text = "";
				if (txtLastName.Text == "Unknown") txtLastName.Text = "";

				// Reset the date to today's date if they uncheck it
				if (dtpDOB.Value.Year == 1900) dtpDOB.Value = DateTime.Today;

				if (txtContact.Text == "000-0000") txtContact.Text = ""; // Clear dummy number
				if (txtAddress.Text == "Unknown") txtAddress.Text = "";
				if (txtOccupation.Text == "Unknown") txtOccupation.Text = "";

				if (txtGuardianName.Text == "Unknown")
					txtGuardianName.Text = "Self — Patient arrived alone";

				if (txtGuardianContact.Text == "000-0000") txtGuardianContact.Text = ""; // Clear dummy number

				chkUnable.Checked = false;
			}
		}

		// Auto-tick the "minor" checkbox as DOB changes
		private void dtpDOB_ValueChanged(object sender, EventArgs e)
		{
			var today = DateTime.Today;
			int age = today.Year - dtpDOB.Value.Year;
			if (dtpDOB.Value.Date > today.AddYears(-age)) age--;

			if (age < 18)
				chkMinor.Checked = true;
			else
				chkMinor.Checked = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Build the Patient object from the form
			Patient p = new Patient
			{
				PatientCode = _existingPatient != null ? _existingPatient.PatientCode : null,
				FirstName = txtFirstName.Text.Trim(),
				MiddleName = txtMiddleName.Text.Trim(),
				LastName = txtLastName.Text.Trim(),
				DateOfBirth = dtpDOB.Value.Date,
				Gender = cmbGender.Text,
				ContactNumber = txtContact.Text.Trim(),
				Address = txtAddress.Text.Trim(),
				CivilStatus = cmbCivilStatus.Text,
				Occupation = txtOccupation.Text.Trim(),
				GuardianName = txtGuardianName.Text.Trim(),
				GuardianRelationship = cmbRelationship.Text,
				GuardianContact = txtGuardianContact.Text.Trim(),
				GuardianAddress = txtGuardianAddress.Text.Trim(),
				GuardianPresent = chkGuardianPresent.Checked,
				EmergencyContactName = txtEmergencyName.Text.Trim(),
				EmergencyContactNumber = txtEmergencyContact.Text.Trim(),
				IsFullyRegistered = !chkNotFullyRegistered.Checked, // NEW
				IsActive = true
			};

			string result;

			if (_existingPatient == null)
				result = controller.AddPatient(p);
			else
				result = controller.UpdatePatient(p);

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