namespace UI
{
	partial class PatientDetailsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelHeader = new System.Windows.Forms.Panel();
			this.lblHeader = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.panelBody = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();

			this.lblSectionPatient = new System.Windows.Forms.Label();

			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblFirstNameValue = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblLastNameValue = new System.Windows.Forms.Label();
			this.lblMiddleName = new System.Windows.Forms.Label();
			this.lblMiddleNameValue = new System.Windows.Forms.Label();
			this.lblDOB = new System.Windows.Forms.Label();
			this.lblDOBValue = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.lblGenderValue = new System.Windows.Forms.Label();
			this.lblAge = new System.Windows.Forms.Label();
			this.lblAgeValue = new System.Windows.Forms.Label();
			this.lblContact = new System.Windows.Forms.Label();
			this.lblContactValue = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblAddressValue = new System.Windows.Forms.Label();
			this.lblCivilStatus = new System.Windows.Forms.Label();
			this.lblCivilStatusValue = new System.Windows.Forms.Label();
			this.lblOccupation = new System.Windows.Forms.Label();
			this.lblOccupationValue = new System.Windows.Forms.Label();

			this.lblSectionGuardian = new System.Windows.Forms.Label();

			this.lblGuardianName = new System.Windows.Forms.Label();
			this.lblGuardianNameValue = new System.Windows.Forms.Label();
			this.lblRelationship = new System.Windows.Forms.Label();
			this.lblRelationshipValue = new System.Windows.Forms.Label();
			this.lblGuardianContact = new System.Windows.Forms.Label();
			this.lblGuardianContactValue = new System.Windows.Forms.Label();
			this.lblGuardianAddress = new System.Windows.Forms.Label();
			this.lblGuardianAddressValue = new System.Windows.Forms.Label();
			this.lblGuardianPresent = new System.Windows.Forms.Label();
			this.lblGuardianPresentValue = new System.Windows.Forms.Label();

			this.lblSectionSecondary = new System.Windows.Forms.Label();

			this.lblEmergencyName = new System.Windows.Forms.Label();
			this.lblEmergencyNameValue = new System.Windows.Forms.Label();
			this.lblEmergencyContact = new System.Windows.Forms.Label();
			this.lblEmergencyContactValue = new System.Windows.Forms.Label();

			this.panelHeader.SuspendLayout();
			this.panelBody.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.White;
			this.panelHeader.Controls.Add(this.lblHeader);
			this.panelHeader.Controls.Add(this.btnClose);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(1000, 65);
			this.panelHeader.TabIndex = 0;
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblHeader.Location = new System.Drawing.Point(24, 18);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(398, 30);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "🏥  Hospital Admission System";
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
			this.btnClose.FlatAppearance.BorderSize = 1;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnClose.Location = new System.Drawing.Point(880, 18);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 32);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panelBody
			// 
			this.panelBody.AutoScroll = true;
			this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.panelBody.Controls.Add(this.lblEmergencyContactValue);
			this.panelBody.Controls.Add(this.lblEmergencyContact);
			this.panelBody.Controls.Add(this.lblEmergencyNameValue);
			this.panelBody.Controls.Add(this.lblEmergencyName);
			this.panelBody.Controls.Add(this.lblSectionSecondary);
			this.panelBody.Controls.Add(this.lblGuardianPresentValue);
			this.panelBody.Controls.Add(this.lblGuardianPresent);
			this.panelBody.Controls.Add(this.lblGuardianAddressValue);
			this.panelBody.Controls.Add(this.lblGuardianAddress);
			this.panelBody.Controls.Add(this.lblGuardianContactValue);
			this.panelBody.Controls.Add(this.lblGuardianContact);
			this.panelBody.Controls.Add(this.lblRelationshipValue);
			this.panelBody.Controls.Add(this.lblRelationship);
			this.panelBody.Controls.Add(this.lblGuardianNameValue);
			this.panelBody.Controls.Add(this.lblGuardianName);
			this.panelBody.Controls.Add(this.lblSectionGuardian);
			this.panelBody.Controls.Add(this.lblOccupationValue);
			this.panelBody.Controls.Add(this.lblOccupation);
			this.panelBody.Controls.Add(this.lblCivilStatusValue);
			this.panelBody.Controls.Add(this.lblCivilStatus);
			this.panelBody.Controls.Add(this.lblAddressValue);
			this.panelBody.Controls.Add(this.lblAddress);
			this.panelBody.Controls.Add(this.lblContactValue);
			this.panelBody.Controls.Add(this.lblContact);
			this.panelBody.Controls.Add(this.lblAgeValue);
			this.panelBody.Controls.Add(this.lblAge);
			this.panelBody.Controls.Add(this.lblGenderValue);
			this.panelBody.Controls.Add(this.lblGender);
			this.panelBody.Controls.Add(this.lblDOBValue);
			this.panelBody.Controls.Add(this.lblDOB);
			this.panelBody.Controls.Add(this.lblMiddleNameValue);
			this.panelBody.Controls.Add(this.lblMiddleName);
			this.panelBody.Controls.Add(this.lblLastNameValue);
			this.panelBody.Controls.Add(this.lblLastName);
			this.panelBody.Controls.Add(this.lblFirstNameValue);
			this.panelBody.Controls.Add(this.lblFirstName);
			this.panelBody.Controls.Add(this.lblSectionPatient);
			this.panelBody.Controls.Add(this.lblTitle);
			this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBody.Location = new System.Drawing.Point(0, 65);
			this.panelBody.Name = "panelBody";
			this.panelBody.Size = new System.Drawing.Size(1000, 635);
			this.panelBody.TabIndex = 1;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
			this.lblTitle.Location = new System.Drawing.Point(40, 30);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(300, 37);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Patient Details";

			// ===== Section: Patient =====
			this.lblSectionPatient.AutoSize = true;
			this.lblSectionPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblSectionPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblSectionPatient.Location = new System.Drawing.Point(40, 85);
			this.lblSectionPatient.Name = "lblSectionPatient";
			this.lblSectionPatient.Size = new System.Drawing.Size(220, 19);
			this.lblSectionPatient.Text = "── PATIENT INFORMATION ──";

			AddLabelRow(this.lblFirstName, this.lblFirstNameValue, "First Name:", 40, 130);
			AddLabelRow(this.lblLastName, this.lblLastNameValue, "Last Name:", 500, 130);
			AddLabelRow(this.lblMiddleName, this.lblMiddleNameValue, "Middle Name:", 40, 170);
			AddLabelRow(this.lblDOB, this.lblDOBValue, "Date of Birth:", 500, 170);
			AddLabelRow(this.lblGender, this.lblGenderValue, "Gender:", 40, 210);
			AddLabelRow(this.lblAge, this.lblAgeValue, "Age:", 500, 210);
			AddLabelRow(this.lblContact, this.lblContactValue, "Contact Number:", 40, 250);
			AddLabelRow(this.lblAddress, this.lblAddressValue, "Address:", 500, 250);
			AddLabelRow(this.lblCivilStatus, this.lblCivilStatusValue, "Civil Status:", 40, 290);
			AddLabelRow(this.lblOccupation, this.lblOccupationValue, "Occupation:", 500, 290);

			// ===== Section: Guardian =====
			this.lblSectionGuardian.AutoSize = true;
			this.lblSectionGuardian.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblSectionGuardian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblSectionGuardian.Location = new System.Drawing.Point(40, 340);
			this.lblSectionGuardian.Name = "lblSectionGuardian";
			this.lblSectionGuardian.Size = new System.Drawing.Size(330, 19);
			this.lblSectionGuardian.Text = "── GUARDIAN / EMERGENCY CONTACT ──";

			AddLabelRow(this.lblGuardianName, this.lblGuardianNameValue, "Guardian Name:", 40, 385);
			AddLabelRow(this.lblRelationship, this.lblRelationshipValue, "Relationship:", 500, 385);
			AddLabelRow(this.lblGuardianContact, this.lblGuardianContactValue, "Guardian Contact:", 40, 425);
			AddLabelRow(this.lblGuardianAddress, this.lblGuardianAddressValue, "Guardian Address:", 500, 425);
			AddLabelRow(this.lblGuardianPresent, this.lblGuardianPresentValue, "Guardian Present:", 40, 465);

			// ===== Section: Secondary =====
			this.lblSectionSecondary.AutoSize = true;
			this.lblSectionSecondary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblSectionSecondary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblSectionSecondary.Location = new System.Drawing.Point(40, 515);
			this.lblSectionSecondary.Name = "lblSectionSecondary";
			this.lblSectionSecondary.Size = new System.Drawing.Size(350, 19);
			this.lblSectionSecondary.Text = "── SECONDARY EMERGENCY CONTACT ──";

			AddLabelRow(this.lblEmergencyName, this.lblEmergencyNameValue, "Emergency Name:", 40, 560);
			AddLabelRow(this.lblEmergencyContact, this.lblEmergencyContactValue, "Emergency Contact:", 500, 560);

			// 
			// PatientDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(1000, 700);
			this.Controls.Add(this.panelBody);
			this.Controls.Add(this.panelHeader);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1000, 700);
			this.Name = "PatientDetailsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Patient Details";
			this.Load += new System.EventHandler(this.PatientDetailsForm_Load);
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.panelBody.ResumeLayout(false);
			this.panelBody.PerformLayout();
			this.ResumeLayout(false);

		}

		// Helper to reduce repetition when building the label/value pairs
		private void AddLabelRow(System.Windows.Forms.Label label, System.Windows.Forms.Label value,
			string labelText, int x, int y)
		{
			label.AutoSize = true;
			label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			label.Location = new System.Drawing.Point(x, y);
			label.Name = "lblAuto";
			label.Size = new System.Drawing.Size(100, 15);
			label.Text = labelText;

			value.AutoSize = true;
			value.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
			value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			value.Location = new System.Drawing.Point(x + 160, y);
			value.Name = "lblAutoValue";
			value.Size = new System.Drawing.Size(100, 19);
			value.Text = "—";
		}

		#endregion

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel panelBody;
		private System.Windows.Forms.Label lblTitle;

		private System.Windows.Forms.Label lblSectionPatient;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lblFirstNameValue;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblLastNameValue;
		private System.Windows.Forms.Label lblMiddleName;
		private System.Windows.Forms.Label lblMiddleNameValue;
		private System.Windows.Forms.Label lblDOB;
		private System.Windows.Forms.Label lblDOBValue;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.Label lblGenderValue;
		private System.Windows.Forms.Label lblAge;
		private System.Windows.Forms.Label lblAgeValue;
		private System.Windows.Forms.Label lblContact;
		private System.Windows.Forms.Label lblContactValue;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblAddressValue;
		private System.Windows.Forms.Label lblCivilStatus;
		private System.Windows.Forms.Label lblCivilStatusValue;
		private System.Windows.Forms.Label lblOccupation;
		private System.Windows.Forms.Label lblOccupationValue;

		private System.Windows.Forms.Label lblSectionGuardian;
		private System.Windows.Forms.Label lblGuardianName;
		private System.Windows.Forms.Label lblGuardianNameValue;
		private System.Windows.Forms.Label lblRelationship;
		private System.Windows.Forms.Label lblRelationshipValue;
		private System.Windows.Forms.Label lblGuardianContact;
		private System.Windows.Forms.Label lblGuardianContactValue;
		private System.Windows.Forms.Label lblGuardianAddress;
		private System.Windows.Forms.Label lblGuardianAddressValue;
		private System.Windows.Forms.Label lblGuardianPresent;
		private System.Windows.Forms.Label lblGuardianPresentValue;

		private System.Windows.Forms.Label lblSectionSecondary;
		private System.Windows.Forms.Label lblEmergencyName;
		private System.Windows.Forms.Label lblEmergencyNameValue;
		private System.Windows.Forms.Label lblEmergencyContact;
		private System.Windows.Forms.Label lblEmergencyContactValue;
	}
}