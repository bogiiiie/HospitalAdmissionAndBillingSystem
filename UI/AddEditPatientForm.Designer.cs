namespace UI
{
	partial class AddEditPatientForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.panelHeader = new System.Windows.Forms.Panel();
			this.lblHeader = new System.Windows.Forms.Label();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblSectionPatient = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.lblLastName = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.lblMiddleName = new System.Windows.Forms.Label();
			this.txtMiddleName = new System.Windows.Forms.TextBox();
			this.lblDOB = new System.Windows.Forms.Label();
			this.dtpDOB = new System.Windows.Forms.DateTimePicker();
			this.lblGender = new System.Windows.Forms.Label();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.lblContact = new System.Windows.Forms.Label();
			this.txtContact = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.lblCivilStatus = new System.Windows.Forms.Label();
			this.cmbCivilStatus = new System.Windows.Forms.ComboBox();
			this.lblOccupation = new System.Windows.Forms.Label();
			this.txtOccupation = new System.Windows.Forms.TextBox();
			this.lblSectionGuardian = new System.Windows.Forms.Label();
			this.chkMinor = new System.Windows.Forms.CheckBox();
			this.chkUnable = new System.Windows.Forms.CheckBox();
			this.lblGuardianName = new System.Windows.Forms.Label();
			this.txtGuardianName = new System.Windows.Forms.TextBox();
			this.lblRelationship = new System.Windows.Forms.Label();
			this.cmbRelationship = new System.Windows.Forms.ComboBox();
			this.lblGuardianContact = new System.Windows.Forms.Label();
			this.txtGuardianContact = new System.Windows.Forms.TextBox();
			this.lblGuardianAddress = new System.Windows.Forms.Label();
			this.txtGuardianAddress = new System.Windows.Forms.TextBox();
			this.chkGuardianPresent = new System.Windows.Forms.CheckBox();
			this.lblSectionSecondary = new System.Windows.Forms.Label();
			this.lblEmergencyName = new System.Windows.Forms.Label();
			this.txtEmergencyName = new System.Windows.Forms.TextBox();
			this.lblEmergencyContact = new System.Windows.Forms.Label();
			this.txtEmergencyContact = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panelHeader.SuspendLayout();
			this.tableLayoutPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.White;
			this.panelHeader.Controls.Add(this.lblHeader);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(1366, 65);
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
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.tableLayoutPanel.ColumnCount = 3;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.Controls.Add(this.panel1, 1, 1);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 65);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 3;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(1366, 703);
			this.tableLayoutPanel.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.lblSectionSecondary);
			this.panel1.Controls.Add(this.lblEmergencyName);
			this.panel1.Controls.Add(this.txtEmergencyName);
			this.panel1.Controls.Add(this.lblEmergencyContact);
			this.panel1.Controls.Add(this.txtEmergencyContact);
			this.panel1.Controls.Add(this.lblSectionGuardian);
			this.panel1.Controls.Add(this.chkMinor);
			this.panel1.Controls.Add(this.chkUnable);
			this.panel1.Controls.Add(this.lblGuardianName);
			this.panel1.Controls.Add(this.txtGuardianName);
			this.panel1.Controls.Add(this.lblRelationship);
			this.panel1.Controls.Add(this.cmbRelationship);
			this.panel1.Controls.Add(this.lblGuardianContact);
			this.panel1.Controls.Add(this.txtGuardianContact);
			this.panel1.Controls.Add(this.lblGuardianAddress);
			this.panel1.Controls.Add(this.txtGuardianAddress);
			this.panel1.Controls.Add(this.chkGuardianPresent);
			this.panel1.Controls.Add(this.lblSectionPatient);
			this.panel1.Controls.Add(this.lblFirstName);
			this.panel1.Controls.Add(this.txtFirstName);
			this.panel1.Controls.Add(this.lblLastName);
			this.panel1.Controls.Add(this.txtLastName);
			this.panel1.Controls.Add(this.lblMiddleName);
			this.panel1.Controls.Add(this.txtMiddleName);
			this.panel1.Controls.Add(this.lblDOB);
			this.panel1.Controls.Add(this.dtpDOB);
			this.panel1.Controls.Add(this.lblGender);
			this.panel1.Controls.Add(this.cmbGender);
			this.panel1.Controls.Add(this.lblContact);
			this.panel1.Controls.Add(this.txtContact);
			this.panel1.Controls.Add(this.lblAddress);
			this.panel1.Controls.Add(this.txtAddress);
			this.panel1.Controls.Add(this.lblCivilStatus);
			this.panel1.Controls.Add(this.cmbCivilStatus);
			this.panel1.Controls.Add(this.lblOccupation);
			this.panel1.Controls.Add(this.txtOccupation);
			this.panel1.Location = new System.Drawing.Point(333, 20);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(700, 660);
			this.panel1.TabIndex = 0;
			// 
			// lblSectionPatient
			// 
			this.lblSectionPatient.AutoSize = true;
			this.lblSectionPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSectionPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblSectionPatient.Location = new System.Drawing.Point(30, 15);
			this.lblSectionPatient.Name = "lblSectionPatient";
			this.lblSectionPatient.Size = new System.Drawing.Size(200, 19);
			this.lblSectionPatient.TabIndex = 0;
			this.lblSectionPatient.Text = "── PATIENT INFORMATION ──";
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblFirstName.Location = new System.Drawing.Point(30, 45);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(80, 15);
			this.lblFirstName.TabIndex = 1;
			this.lblFirstName.Text = "First Name *";
			// 
			// txtFirstName
			// 
			this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstName.Location = new System.Drawing.Point(30, 65);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(300, 24);
			this.txtFirstName.TabIndex = 2;
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblLastName.Location = new System.Drawing.Point(360, 45);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(79, 15);
			this.lblLastName.TabIndex = 3;
			this.lblLastName.Text = "Last Name *";
			// 
			// txtLastName
			// 
			this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLastName.Location = new System.Drawing.Point(360, 65);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(310, 24);
			this.txtLastName.TabIndex = 4;
			// 
			// lblMiddleName
			// 
			this.lblMiddleName.AutoSize = true;
			this.lblMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblMiddleName.Location = new System.Drawing.Point(30, 100);
			this.lblMiddleName.Name = "lblMiddleName";
			this.lblMiddleName.Size = new System.Drawing.Size(83, 15);
			this.lblMiddleName.TabIndex = 5;
			this.lblMiddleName.Text = "Middle Name";
			// 
			// txtMiddleName
			// 
			this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMiddleName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMiddleName.Location = new System.Drawing.Point(30, 120);
			this.txtMiddleName.Name = "txtMiddleName";
			this.txtMiddleName.Size = new System.Drawing.Size(300, 24);
			this.txtMiddleName.TabIndex = 6;
			// 
			// lblDOB
			// 
			this.lblDOB.AutoSize = true;
			this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblDOB.Location = new System.Drawing.Point(360, 100);
			this.lblDOB.Name = "lblDOB";
			this.lblDOB.Size = new System.Drawing.Size(85, 15);
			this.lblDOB.TabIndex = 7;
			this.lblDOB.Text = "Date of Birth *";
			// 
			// dtpDOB
			// 
			this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDOB.Location = new System.Drawing.Point(360, 120);
			this.dtpDOB.Name = "dtpDOB";
			this.dtpDOB.Size = new System.Drawing.Size(310, 24);
			this.dtpDOB.TabIndex = 8;
			this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblGender.Location = new System.Drawing.Point(30, 155);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(55, 15);
			this.lblGender.TabIndex = 9;
			this.lblGender.Text = "Gender *";
			// 
			// cmbGender
			// 
			this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
			this.cmbGender.Location = new System.Drawing.Point(30, 175);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(300, 25);
			this.cmbGender.TabIndex = 10;
			// 
			// lblContact
			// 
			this.lblContact.AutoSize = true;
			this.lblContact.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblContact.Location = new System.Drawing.Point(360, 155);
			this.lblContact.Name = "lblContact";
			this.lblContact.Size = new System.Drawing.Size(100, 15);
			this.lblContact.TabIndex = 11;
			this.lblContact.Text = "Contact Number *";
			// 
			// txtContact
			// 
			this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContact.Location = new System.Drawing.Point(360, 175);
			this.txtContact.Name = "txtContact";
			this.txtContact.Size = new System.Drawing.Size(310, 24);
			this.txtContact.TabIndex = 12;
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblAddress.Location = new System.Drawing.Point(30, 210);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(53, 15);
			this.lblAddress.TabIndex = 13;
			this.lblAddress.Text = "Address";
			// 
			// txtAddress
			// 
			this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.Location = new System.Drawing.Point(30, 230);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(640, 24);
			this.txtAddress.TabIndex = 14;
			// 
			// lblCivilStatus
			// 
			this.lblCivilStatus.AutoSize = true;
			this.lblCivilStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCivilStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblCivilStatus.Location = new System.Drawing.Point(30, 265);
			this.lblCivilStatus.Name = "lblCivilStatus";
			this.lblCivilStatus.Size = new System.Drawing.Size(73, 15);
			this.lblCivilStatus.TabIndex = 15;
			this.lblCivilStatus.Text = "Civil Status";
			// 
			// cmbCivilStatus
			// 
			this.cmbCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCivilStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbCivilStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbCivilStatus.FormattingEnabled = true;
			this.cmbCivilStatus.Items.AddRange(new object[] { "", "Single", "Married", "Widowed", "Separated" });
			this.cmbCivilStatus.Location = new System.Drawing.Point(30, 285);
			this.cmbCivilStatus.Name = "cmbCivilStatus";
			this.cmbCivilStatus.Size = new System.Drawing.Size(300, 25);
			this.cmbCivilStatus.TabIndex = 16;
			// 
			// lblOccupation
			// 
			this.lblOccupation.AutoSize = true;
			this.lblOccupation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOccupation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblOccupation.Location = new System.Drawing.Point(360, 265);
			this.lblOccupation.Name = "lblOccupation";
			this.lblOccupation.Size = new System.Drawing.Size(71, 15);
			this.lblOccupation.TabIndex = 17;
			this.lblOccupation.Text = "Occupation";
			// 
			// txtOccupation
			// 
			this.txtOccupation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtOccupation.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOccupation.Location = new System.Drawing.Point(360, 285);
			this.txtOccupation.Name = "txtOccupation";
			this.txtOccupation.Size = new System.Drawing.Size(310, 24);
			this.txtOccupation.TabIndex = 18;
			// 
			// lblSectionGuardian
			// 
			this.lblSectionGuardian.AutoSize = true;
			this.lblSectionGuardian.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSectionGuardian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblSectionGuardian.Location = new System.Drawing.Point(30, 325);
			this.lblSectionGuardian.Name = "lblSectionGuardian";
			this.lblSectionGuardian.Size = new System.Drawing.Size(300, 19);
			this.lblSectionGuardian.TabIndex = 19;
			this.lblSectionGuardian.Text = "── GUARDIAN / EMERGENCY CONTACT ──";
			// 
			// chkMinor
			// 
			this.chkMinor.AutoSize = true;
			this.chkMinor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkMinor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.chkMinor.Location = new System.Drawing.Point(30, 350);
			this.chkMinor.Name = "chkMinor";
			this.chkMinor.Size = new System.Drawing.Size(180, 19);
			this.chkMinor.TabIndex = 20;
			this.chkMinor.Text = "Patient is a minor (under 18)";
			// 
			// chkUnable
			// 
			this.chkUnable.AutoSize = true;
			this.chkUnable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkUnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.chkUnable.Location = new System.Drawing.Point(240, 350);
			this.chkUnable.Name = "chkUnable";
			this.chkUnable.Size = new System.Drawing.Size(240, 19);
			this.chkUnable.TabIndex = 21;
			this.chkUnable.Text = "Patient is unable to provide information";
			// 
			// lblGuardianName
			// 
			this.lblGuardianName.AutoSize = true;
			this.lblGuardianName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGuardianName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblGuardianName.Location = new System.Drawing.Point(30, 380);
			this.lblGuardianName.Name = "lblGuardianName";
			this.lblGuardianName.Size = new System.Drawing.Size(120, 15);
			this.lblGuardianName.TabIndex = 22;
			this.lblGuardianName.Text = "Guardian Full Name *";
			// 
			// txtGuardianName
			// 
			this.txtGuardianName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtGuardianName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGuardianName.Location = new System.Drawing.Point(30, 400);
			this.txtGuardianName.Name = "txtGuardianName";
			this.txtGuardianName.Size = new System.Drawing.Size(300, 24);
			this.txtGuardianName.TabIndex = 23;
			// 
			// lblRelationship
			// 
			this.lblRelationship.AutoSize = true;
			this.lblRelationship.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRelationship.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblRelationship.Location = new System.Drawing.Point(360, 380);
			this.lblRelationship.Name = "lblRelationship";
			this.lblRelationship.Size = new System.Drawing.Size(85, 15);
			this.lblRelationship.TabIndex = 24;
			this.lblRelationship.Text = "Relationship *";
			// 
			// cmbRelationship
			// 
			this.cmbRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRelationship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbRelationship.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbRelationship.FormattingEnabled = true;
			this.cmbRelationship.Items.AddRange(new object[] {
			"Self", "Parent", "Spouse", "Sibling", "Child", "Relative", "Friend", "Social Worker", "Other"});
			this.cmbRelationship.Location = new System.Drawing.Point(360, 400);
			this.cmbRelationship.Name = "cmbRelationship";
			this.cmbRelationship.Size = new System.Drawing.Size(310, 25);
			this.cmbRelationship.TabIndex = 25;
			// 
			// lblGuardianContact
			// 
			this.lblGuardianContact.AutoSize = true;
			this.lblGuardianContact.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGuardianContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblGuardianContact.Location = new System.Drawing.Point(30, 435);
			this.lblGuardianContact.Name = "lblGuardianContact";
			this.lblGuardianContact.Size = new System.Drawing.Size(140, 15);
			this.lblGuardianContact.TabIndex = 26;
			this.lblGuardianContact.Text = "Guardian Contact Number *";
			// 
			// txtGuardianContact
			// 
			this.txtGuardianContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtGuardianContact.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGuardianContact.Location = new System.Drawing.Point(30, 455);
			this.txtGuardianContact.Name = "txtGuardianContact";
			this.txtGuardianContact.Size = new System.Drawing.Size(300, 24);
			this.txtGuardianContact.TabIndex = 27;
			// 
			// lblGuardianAddress
			// 
			this.lblGuardianAddress.AutoSize = true;
			this.lblGuardianAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGuardianAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblGuardianAddress.Location = new System.Drawing.Point(360, 435);
			this.lblGuardianAddress.Name = "lblGuardianAddress";
			this.lblGuardianAddress.Size = new System.Drawing.Size(100, 15);
			this.lblGuardianAddress.TabIndex = 28;
			this.lblGuardianAddress.Text = "Guardian Address";
			// 
			// txtGuardianAddress
			// 
			this.txtGuardianAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtGuardianAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGuardianAddress.Location = new System.Drawing.Point(360, 455);
			this.txtGuardianAddress.Name = "txtGuardianAddress";
			this.txtGuardianAddress.Size = new System.Drawing.Size(310, 24);
			this.txtGuardianAddress.TabIndex = 29;
			// 
			// chkGuardianPresent
			// 
			this.chkGuardianPresent.AutoSize = true;
			this.chkGuardianPresent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkGuardianPresent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.chkGuardianPresent.Location = new System.Drawing.Point(30, 485);
			this.chkGuardianPresent.Name = "chkGuardianPresent";
			this.chkGuardianPresent.Size = new System.Drawing.Size(220, 19);
			this.chkGuardianPresent.TabIndex = 30;
			this.chkGuardianPresent.Text = "Guardian is present with patient";
			// 
			// lblSectionSecondary
			// 
			this.lblSectionSecondary.AutoSize = true;
			this.lblSectionSecondary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSectionSecondary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblSectionSecondary.Location = new System.Drawing.Point(30, 515);
			this.lblSectionSecondary.Name = "lblSectionSecondary";
			this.lblSectionSecondary.Size = new System.Drawing.Size(350, 19);
			this.lblSectionSecondary.TabIndex = 31;
			this.lblSectionSecondary.Text = "── SECONDARY EMERGENCY CONTACT (Optional) ──";
			// 
			// lblEmergencyName
			// 
			this.lblEmergencyName.AutoSize = true;
			this.lblEmergencyName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmergencyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblEmergencyName.Location = new System.Drawing.Point(30, 540);
			this.lblEmergencyName.Name = "lblEmergencyName";
			this.lblEmergencyName.Size = new System.Drawing.Size(100, 15);
			this.lblEmergencyName.TabIndex = 32;
			this.lblEmergencyName.Text = "Emergency Name";
			// 
			// txtEmergencyName
			// 
			this.txtEmergencyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEmergencyName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmergencyName.Location = new System.Drawing.Point(30, 560);
			this.txtEmergencyName.Name = "txtEmergencyName";
			this.txtEmergencyName.Size = new System.Drawing.Size(300, 24);
			this.txtEmergencyName.TabIndex = 33;
			// 
			// lblEmergencyContact
			// 
			this.lblEmergencyContact.AutoSize = true;
			this.lblEmergencyContact.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmergencyContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblEmergencyContact.Location = new System.Drawing.Point(360, 540);
			this.lblEmergencyContact.Name = "lblEmergencyContact";
			this.lblEmergencyContact.Size = new System.Drawing.Size(110, 15);
			this.lblEmergencyContact.TabIndex = 34;
			this.lblEmergencyContact.Text = "Emergency Contact";
			// 
			// txtEmergencyContact
			// 
			this.txtEmergencyContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEmergencyContact.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmergencyContact.Location = new System.Drawing.Point(360, 560);
			this.txtEmergencyContact.Name = "txtEmergencyContact";
			this.txtEmergencyContact.Size = new System.Drawing.Size(310, 24);
			this.txtEmergencyContact.TabIndex = 35;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(30, 605);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(200, 40);
			this.btnSave.TabIndex = 36;
			this.btnSave.Text = "Save";
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
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnCancel.Location = new System.Drawing.Point(250, 605);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(200, 40);
			this.btnCancel.TabIndex = 37;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// AddEditPatientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(1366, 768);
			this.Controls.Add(this.tableLayoutPanel);
			this.Controls.Add(this.panelHeader);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.MinimumSize = new System.Drawing.Size(1000, 700);
			this.Name = "AddEditPatientForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Patient";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.AddEditPatientForm_Load);
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.tableLayoutPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Panel panel1;

		private System.Windows.Forms.Label lblSectionPatient;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label lblMiddleName;
		private System.Windows.Forms.TextBox txtMiddleName;
		private System.Windows.Forms.Label lblDOB;
		private System.Windows.Forms.DateTimePicker dtpDOB;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.ComboBox cmbGender;
		private System.Windows.Forms.Label lblContact;
		private System.Windows.Forms.TextBox txtContact;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label lblCivilStatus;
		private System.Windows.Forms.ComboBox cmbCivilStatus;
		private System.Windows.Forms.Label lblOccupation;
		private System.Windows.Forms.TextBox txtOccupation;

		private System.Windows.Forms.Label lblSectionGuardian;
		private System.Windows.Forms.CheckBox chkMinor;
		private System.Windows.Forms.CheckBox chkUnable;
		private System.Windows.Forms.Label lblGuardianName;
		private System.Windows.Forms.TextBox txtGuardianName;
		private System.Windows.Forms.Label lblRelationship;
		private System.Windows.Forms.ComboBox cmbRelationship;
		private System.Windows.Forms.Label lblGuardianContact;
		private System.Windows.Forms.TextBox txtGuardianContact;
		private System.Windows.Forms.Label lblGuardianAddress;
		private System.Windows.Forms.TextBox txtGuardianAddress;
		private System.Windows.Forms.CheckBox chkGuardianPresent;

		private System.Windows.Forms.Label lblSectionSecondary;
		private System.Windows.Forms.Label lblEmergencyName;
		private System.Windows.Forms.TextBox txtEmergencyName;
		private System.Windows.Forms.Label lblEmergencyContact;
		private System.Windows.Forms.TextBox txtEmergencyContact;

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
	}
}