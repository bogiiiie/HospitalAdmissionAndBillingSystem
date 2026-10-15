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
			if (_existingPatient == null)
			{
				// ADD MODE
				this.Text = "Add Patient";
				lblHeader.Text = "Patient Maintenance — Add Patient";

				// Default guardian values — treat as self/alone initially
				txtGuardianName.Text = "Self — Patient arrived alone";
				cmbRelationship.Text = "Self";
				chkGuardianPresent.Checked = false;
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