using System;
using System.Windows.Forms;
using Model;

namespace UI
{
	public partial class PatientDetailsForm : Form
	{
		private readonly Patient _patient;

		public PatientDetailsForm(Patient patient)
		{
			InitializeComponent();
			_patient = patient;
		}

		private void PatientDetailsForm_Load(object sender, EventArgs e)
		{
			if (_patient == null) return;

			lblTitle.Text = "Patient Details — " + _patient.PatientCode;

			// Patient info
			lblFirstNameValue.Text = _patient.FirstName;
			lblMiddleNameValue.Text = string.IsNullOrWhiteSpace(_patient.MiddleName) ? "—" : _patient.MiddleName;
			lblLastNameValue.Text = _patient.LastName;
			lblDOBValue.Text = _patient.DateOfBirth.ToString("MM/dd/yyyy");
			lblGenderValue.Text = _patient.Gender;
			lblAgeValue.Text = _patient.Age.ToString();
			lblContactValue.Text = _patient.ContactNumber;
			lblAddressValue.Text = string.IsNullOrWhiteSpace(_patient.Address) ? "—" : _patient.Address;
			lblCivilStatusValue.Text = string.IsNullOrWhiteSpace(_patient.CivilStatus) ? "—" : _patient.CivilStatus;
			lblOccupationValue.Text = string.IsNullOrWhiteSpace(_patient.Occupation) ? "—" : _patient.Occupation;

			// Guardian info
			lblGuardianNameValue.Text = string.IsNullOrWhiteSpace(_patient.GuardianName) ? "—" : _patient.GuardianName;
			lblRelationshipValue.Text = string.IsNullOrWhiteSpace(_patient.GuardianRelationship) ? "—" : _patient.GuardianRelationship;
			lblGuardianContactValue.Text = string.IsNullOrWhiteSpace(_patient.GuardianContact) ? "—" : _patient.GuardianContact;
			lblGuardianAddressValue.Text = string.IsNullOrWhiteSpace(_patient.GuardianAddress) ? "—" : _patient.GuardianAddress;
			lblGuardianPresentValue.Text = _patient.GuardianPresent ? "Yes" : "No";

			// Secondary emergency contact
			lblEmergencyNameValue.Text = string.IsNullOrWhiteSpace(_patient.EmergencyContactName) ? "—" : _patient.EmergencyContactName;
			lblEmergencyContactValue.Text = string.IsNullOrWhiteSpace(_patient.EmergencyContactNumber) ? "—" : _patient.EmergencyContactNumber;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}