using System;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
	public partial class EditAdmissionForm : Form
	{
		private readonly AdmissionController admissionController = new AdmissionController();
		private readonly PatientController patientController = new PatientController();
		private readonly RoomController roomController = new RoomController();

		private readonly Admission _admission;

		// Only set if the user picks a new room
		private string _newRoomNumber;

		public EditAdmissionForm(Admission admission)
		{
			InitializeComponent();
			_admission = admission;
		}

		private void EditAdmissionForm_Load(object sender, EventArgs e)
		{
			if (_admission == null)
			{
				MessageBox.Show("Admission not found.", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.Close();
				return;
			}

			lblTitle.Text = "Edit Admission — " + _admission.AdmissionCode;

			// Patient display
			Patient patient = patientController.GetPatientByCode(_admission.PatientCode);
			string patientName = patient != null ? patient.FullName : "(unknown)";
			txtPatient.Text = _admission.PatientCode + " — " + patientName;

			// Current room display
			Room currentRoom = roomController.GetRoomByNumber(_admission.RoomNumber);
			string currentRoomDisplay = currentRoom != null
				? _admission.RoomNumber + " — " + currentRoom.RoomType +
				  " — ₱" + _admission.LockedRate.ToString("N2") + "/day (locked)"
				: _admission.RoomNumber;
			txtCurrentRoom.Text = currentRoomDisplay;

			// Admission date
			txtAdmissionDate.Text = _admission.AdmissionDate.ToString("MM/dd/yyyy hh:mm tt");

			// Diagnosis (editable)
			txtDiagnosis.Text = _admission.Diagnosis;

			// New room is empty by default
			txtNewRoom.Text = "";
			_newRoomNumber = null;
		}

		private void btnFindRoom_Click(object sender, EventArgs e)
		{
			RoomPickerDialog picker = new RoomPickerDialog();
			if (picker.ShowDialog(this) == DialogResult.OK)
			{
				_newRoomNumber = picker.SelectedRoomNumber;
				txtNewRoom.Text = picker.SelectedRoomNumber + " — " +
								  picker.SelectedRoomType + " — ₱" +
								  picker.SelectedRoomRate.ToString("N2") + "/day";
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// If the user didn't pick a new room, keep the current one
			string targetRoom = string.IsNullOrWhiteSpace(_newRoomNumber)
				? _admission.RoomNumber
				: _newRoomNumber;

			string result = admissionController.UpdateAdmission(
				_admission.AdmissionCode,
				targetRoom,
				txtDiagnosis.Text);

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