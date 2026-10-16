namespace UI
{
	partial class EditAdmissionForm
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
			this.panelBody = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblPatientLabel = new System.Windows.Forms.Label();
			this.txtPatient = new System.Windows.Forms.TextBox();
			this.lblCurrentRoomLabel = new System.Windows.Forms.Label();
			this.txtCurrentRoom = new System.Windows.Forms.TextBox();
			this.lblDateLabel = new System.Windows.Forms.Label();
			this.txtAdmissionDate = new System.Windows.Forms.TextBox();
			this.lblDiagnosisLabel = new System.Windows.Forms.Label();
			this.txtDiagnosis = new System.Windows.Forms.TextBox();
			this.lblSectionRoom = new System.Windows.Forms.Label();
			this.lblNewRoomLabel = new System.Windows.Forms.Label();
			this.txtNewRoom = new System.Windows.Forms.TextBox();
			this.btnFindRoom = new System.Windows.Forms.Button();
			this.lblHelperNote = new System.Windows.Forms.Label();
			this.panelFooter = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.panelHeader.SuspendLayout();
			this.panelBody.SuspendLayout();
			this.panelFooter.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.White;
			this.panelHeader.Controls.Add(this.lblHeader);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(900, 65);
			this.panelHeader.TabIndex = 0;
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
			this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblHeader.Location = new System.Drawing.Point(24, 18);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(418, 30);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "🏥  Hospital Admission System";
			// 
			// panelBody
			// 
			this.panelBody.AutoScroll = true;
			this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.panelBody.Controls.Add(this.btnFindRoom);
			this.panelBody.Controls.Add(this.txtNewRoom);
			this.panelBody.Controls.Add(this.lblNewRoomLabel);
			this.panelBody.Controls.Add(this.lblSectionRoom);
			this.panelBody.Controls.Add(this.txtDiagnosis);
			this.panelBody.Controls.Add(this.lblDiagnosisLabel);
			this.panelBody.Controls.Add(this.txtAdmissionDate);
			this.panelBody.Controls.Add(this.lblDateLabel);
			this.panelBody.Controls.Add(this.txtCurrentRoom);
			this.panelBody.Controls.Add(this.lblCurrentRoomLabel);
			this.panelBody.Controls.Add(this.txtPatient);
			this.panelBody.Controls.Add(this.lblPatientLabel);
			this.panelBody.Controls.Add(this.lblHelperNote);
			this.panelBody.Controls.Add(this.lblTitle);
			this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBody.Location = new System.Drawing.Point(0, 65);
			this.panelBody.Name = "panelBody";
			this.panelBody.Size = new System.Drawing.Size(900, 635);
			this.panelBody.TabIndex = 1;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
			this.lblTitle.Location = new System.Drawing.Point(40, 30);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(280, 37);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Edit Admission — ADM-0001";
			// 
			// lblPatientLabel
			// 
			this.lblPatientLabel.AutoSize = true;
			this.lblPatientLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblPatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblPatientLabel.Location = new System.Drawing.Point(40, 95);
			this.lblPatientLabel.Name = "lblPatientLabel";
			this.lblPatientLabel.Size = new System.Drawing.Size(190, 23);
			this.lblPatientLabel.TabIndex = 1;
			this.lblPatientLabel.Text = "Patient (read-only)";
			// 
			// txtPatient
			// 
			this.txtPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			this.txtPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPatient.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPatient.Location = new System.Drawing.Point(40, 122);
			this.txtPatient.Name = "txtPatient";
			this.txtPatient.ReadOnly = true;
			this.txtPatient.Size = new System.Drawing.Size(500, 30);
			this.txtPatient.TabIndex = 2;
			// 
			// lblCurrentRoomLabel
			// 
			this.lblCurrentRoomLabel.AutoSize = true;
			this.lblCurrentRoomLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblCurrentRoomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblCurrentRoomLabel.Location = new System.Drawing.Point(40, 175);
			this.lblCurrentRoomLabel.Name = "lblCurrentRoomLabel";
			this.lblCurrentRoomLabel.Size = new System.Drawing.Size(220, 23);
			this.lblCurrentRoomLabel.TabIndex = 3;
			this.lblCurrentRoomLabel.Text = "Current Room (read-only)";
			// 
			// txtCurrentRoom
			// 
			this.txtCurrentRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			this.txtCurrentRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCurrentRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtCurrentRoom.Location = new System.Drawing.Point(40, 202);
			this.txtCurrentRoom.Name = "txtCurrentRoom";
			this.txtCurrentRoom.ReadOnly = true;
			this.txtCurrentRoom.Size = new System.Drawing.Size(500, 30);
			this.txtCurrentRoom.TabIndex = 4;
			// 
			// lblDateLabel
			// 
			this.lblDateLabel.AutoSize = true;
			this.lblDateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblDateLabel.Location = new System.Drawing.Point(40, 255);
			this.lblDateLabel.Name = "lblDateLabel";
			this.lblDateLabel.Size = new System.Drawing.Size(220, 23);
			this.lblDateLabel.TabIndex = 5;
			this.lblDateLabel.Text = "Admission Date (read-only)";
			// 
			// txtAdmissionDate
			// 
			this.txtAdmissionDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			this.txtAdmissionDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAdmissionDate.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtAdmissionDate.Location = new System.Drawing.Point(40, 282);
			this.txtAdmissionDate.Name = "txtAdmissionDate";
			this.txtAdmissionDate.ReadOnly = true;
			this.txtAdmissionDate.Size = new System.Drawing.Size(500, 30);
			this.txtAdmissionDate.TabIndex = 6;
			// 
			// lblDiagnosisLabel
			// 
			this.lblDiagnosisLabel.AutoSize = true;
			this.lblDiagnosisLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblDiagnosisLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblDiagnosisLabel.Location = new System.Drawing.Point(40, 335);
			this.lblDiagnosisLabel.Name = "lblDiagnosisLabel";
			this.lblDiagnosisLabel.Size = new System.Drawing.Size(200, 23);
			this.lblDiagnosisLabel.TabIndex = 7;
			this.lblDiagnosisLabel.Text = "Diagnosis (editable) *";
			// 
			// txtDiagnosis
			// 
			this.txtDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDiagnosis.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtDiagnosis.Location = new System.Drawing.Point(40, 362);
			this.txtDiagnosis.Multiline = true;
			this.txtDiagnosis.Name = "txtDiagnosis";
			this.txtDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDiagnosis.Size = new System.Drawing.Size(820, 70);
			this.txtDiagnosis.TabIndex = 8;
			// 
			// lblSectionRoom
			// 
			this.lblSectionRoom.AutoSize = true;
			this.lblSectionRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblSectionRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblSectionRoom.Location = new System.Drawing.Point(40, 460);
			this.lblSectionRoom.Name = "lblSectionRoom";
			this.lblSectionRoom.Size = new System.Drawing.Size(320, 23);
			this.lblSectionRoom.TabIndex = 9;
			this.lblSectionRoom.Text = "── CHANGE ROOM ASSIGNMENT ──";
			// 
			// lblNewRoomLabel
			// 
			this.lblNewRoomLabel.AutoSize = true;
			this.lblNewRoomLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblNewRoomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblNewRoomLabel.Location = new System.Drawing.Point(40, 500);
			this.lblNewRoomLabel.Name = "lblNewRoomLabel";
			this.lblNewRoomLabel.Size = new System.Drawing.Size(320, 23);
			this.lblNewRoomLabel.TabIndex = 10;
			this.lblNewRoomLabel.Text = "New Room (leave blank to keep current)";
			// 
			// txtNewRoom
			// 
			this.txtNewRoom.BackColor = System.Drawing.Color.White;
			this.txtNewRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNewRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtNewRoom.Location = new System.Drawing.Point(40, 527);
			this.txtNewRoom.Name = "txtNewRoom";
			this.txtNewRoom.ReadOnly = true;
			this.txtNewRoom.Size = new System.Drawing.Size(600, 30);
			this.txtNewRoom.TabIndex = 11;
			// 
			// btnFindRoom
			// 
			this.btnFindRoom.BackColor = System.Drawing.Color.White;
			this.btnFindRoom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFindRoom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnFindRoom.FlatAppearance.BorderSize = 1;
			this.btnFindRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFindRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnFindRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnFindRoom.Location = new System.Drawing.Point(650, 525);
			this.btnFindRoom.Name = "btnFindRoom";
			this.btnFindRoom.Size = new System.Drawing.Size(210, 34);
			this.btnFindRoom.TabIndex = 12;
			this.btnFindRoom.Text = "🔍  Find Room";
			this.btnFindRoom.UseVisualStyleBackColor = false;
			this.btnFindRoom.Click += new System.EventHandler(this.btnFindRoom_Click);
			// 
			// lblHelperNote
			// 
			this.lblHelperNote.AutoSize = true;
			this.lblHelperNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
			this.lblHelperNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			this.lblHelperNote.Location = new System.Drawing.Point(40, 570);
			this.lblHelperNote.Name = "lblHelperNote";
			this.lblHelperNote.Size = new System.Drawing.Size(700, 20);
			this.lblHelperNote.TabIndex = 13;
			this.lblHelperNote.Text = "Old room becomes Available, new room becomes Occupied, and the new rate is locked in.";
			// 
			// panelFooter
			// 
			this.panelFooter.BackColor = System.Drawing.Color.White;
			this.panelFooter.Controls.Add(this.btnCancel);
			this.panelFooter.Controls.Add(this.btnSave);
			this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelFooter.Location = new System.Drawing.Point(0, 635);
			this.panelFooter.Name = "panelFooter";
			this.panelFooter.Size = new System.Drawing.Size(900, 65);
			this.panelFooter.TabIndex = 2;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(40, 15);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(200, 40);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save Changes";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.White;
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
			this.btnCancel.FlatAppearance.BorderSize = 1;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnCancel.Location = new System.Drawing.Point(260, 15);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(160, 40);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// EditAdmissionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(900, 700);
			this.Controls.Add(this.panelBody);
			this.Controls.Add(this.panelFooter);
			this.Controls.Add(this.panelHeader);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(916, 739);
			this.Name = "EditAdmissionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Admission";
			this.Load += new System.EventHandler(this.EditAdmissionForm_Load);
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.panelBody.ResumeLayout(false);
			this.panelBody.PerformLayout();
			this.panelFooter.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.Panel panelBody;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblPatientLabel;
		private System.Windows.Forms.TextBox txtPatient;
		private System.Windows.Forms.Label lblCurrentRoomLabel;
		private System.Windows.Forms.TextBox txtCurrentRoom;
		private System.Windows.Forms.Label lblDateLabel;
		private System.Windows.Forms.TextBox txtAdmissionDate;
		private System.Windows.Forms.Label lblDiagnosisLabel;
		private System.Windows.Forms.TextBox txtDiagnosis;
		private System.Windows.Forms.Label lblSectionRoom;
		private System.Windows.Forms.Label lblNewRoomLabel;
		private System.Windows.Forms.TextBox txtNewRoom;
		private System.Windows.Forms.Button btnFindRoom;
		private System.Windows.Forms.Label lblHelperNote;
		private System.Windows.Forms.Panel panelFooter;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
	}
}