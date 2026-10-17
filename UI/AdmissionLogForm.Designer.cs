namespace UI
{
	partial class AdmissionLogForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.headerPanel = new System.Windows.Forms.Panel();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnMainMenu = new System.Windows.Forms.Button();
			this.lblUserInfo = new System.Windows.Forms.Label();
			this.lblBrand = new System.Windows.Forms.Label();
			this.headerBorder = new System.Windows.Forms.Panel();
			this.sidebarPanel = new System.Windows.Forms.Panel();
			this.btnNavSummary = new System.Windows.Forms.Button();
			this.btnNavDischarge = new System.Windows.Forms.Button();
			this.btnNavBilling = new System.Windows.Forms.Button();
			this.btnNavTreatment = new System.Windows.Forms.Button();
			this.btnNavDoctorNurse = new System.Windows.Forms.Button();
			this.btnNavAdmissionLog = new System.Windows.Forms.Button();
			this.btnNavAdmission = new System.Windows.Forms.Button();
			this.btnNavRoomSearch = new System.Windows.Forms.Button();
			this.btnNavPatientSearch = new System.Windows.Forms.Button();
			this.btnNavPatient = new System.Windows.Forms.Button();
			this.btnNavRoom = new System.Windows.Forms.Button();
			this.lblSidebarHeader = new System.Windows.Forms.Label();
			this.sidebarBorder = new System.Windows.Forms.Panel();
			this.contentPanel = new System.Windows.Forms.Panel();
			this.cardPanel = new System.Windows.Forms.Panel();
			this.dgvAdmissions = new System.Windows.Forms.DataGridView();
			this.colAdmissionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAdmitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPerformedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblCount = new System.Windows.Forms.Label();
			this.toolbarPanel = new System.Windows.Forms.Panel();
			this.btnFilter = new System.Windows.Forms.Button();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.lblTo = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.lblFrom = new System.Windows.Forms.Label();
			this.lblSubtitle = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.headerPanel.SuspendLayout();
			this.sidebarPanel.SuspendLayout();
			this.contentPanel.SuspendLayout();
			this.cardPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAdmissions)).BeginInit();
			this.toolbarPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// headerPanel
			// 
			this.headerPanel.BackColor = System.Drawing.Color.White;
			this.headerPanel.Controls.Add(this.btnLogout);
			this.headerPanel.Controls.Add(this.btnMainMenu);
			this.headerPanel.Controls.Add(this.lblUserInfo);
			this.headerPanel.Controls.Add(this.lblBrand);
			this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerPanel.Location = new System.Drawing.Point(0, 0);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(1366, 65);
			this.headerPanel.TabIndex = 0;
			// 
			// btnLogout
			// 
			this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
			this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogout.FlatAppearance.BorderSize = 0;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnLogout.ForeColor = System.Drawing.Color.White;
			this.btnLogout.Location = new System.Drawing.Point(1240, 18);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(106, 32);
			this.btnLogout.TabIndex = 3;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnMainMenu
			// 
			this.btnMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMainMenu.BackColor = System.Drawing.Color.White;
			this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
			this.btnMainMenu.FlatAppearance.BorderSize = 1;
			this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnMainMenu.Location = new System.Drawing.Point(1120, 18);
			this.btnMainMenu.Name = "btnMainMenu";
			this.btnMainMenu.Size = new System.Drawing.Size(110, 32);
			this.btnMainMenu.TabIndex = 2;
			this.btnMainMenu.Text = "Main Menu";
			this.btnMainMenu.UseVisualStyleBackColor = false;
			this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
			// 
			// lblUserInfo
			// 
			this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblUserInfo.AutoSize = true;
			this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblUserInfo.Location = new System.Drawing.Point(843, 23);
			this.lblUserInfo.Name = "lblUserInfo";
			this.lblUserInfo.Size = new System.Drawing.Size(271, 23);
			this.lblUserInfo.TabIndex = 1;
			this.lblUserInfo.Text = "Logged in as: [Name] | Role: [Role]";
			// 
			// lblBrand
			// 
			this.lblBrand.AutoSize = true;
			this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
			this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblBrand.Location = new System.Drawing.Point(24, 18);
			this.lblBrand.Name = "lblBrand";
			this.lblBrand.Size = new System.Drawing.Size(418, 37);
			this.lblBrand.TabIndex = 0;
			this.lblBrand.Text = "🏥  Hospital Admission System";
			// 
			// headerBorder
			// 
			this.headerBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
			this.headerBorder.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerBorder.Location = new System.Drawing.Point(0, 65);
			this.headerBorder.Name = "headerBorder";
			this.headerBorder.Size = new System.Drawing.Size(1366, 1);
			this.headerBorder.TabIndex = 3;
			// 
			// sidebarPanel
			// 
			this.sidebarPanel.BackColor = System.Drawing.Color.White;
			this.sidebarPanel.Controls.Add(this.btnNavSummary);
			this.sidebarPanel.Controls.Add(this.btnNavDischarge);
			this.sidebarPanel.Controls.Add(this.btnNavBilling);
			this.sidebarPanel.Controls.Add(this.btnNavTreatment);
			this.sidebarPanel.Controls.Add(this.btnNavDoctorNurse);
			this.sidebarPanel.Controls.Add(this.btnNavAdmissionLog);
			this.sidebarPanel.Controls.Add(this.btnNavAdmission);
			this.sidebarPanel.Controls.Add(this.btnNavRoomSearch);
			this.sidebarPanel.Controls.Add(this.btnNavPatientSearch);
			this.sidebarPanel.Controls.Add(this.btnNavPatient);
			this.sidebarPanel.Controls.Add(this.btnNavRoom);
			this.sidebarPanel.Controls.Add(this.lblSidebarHeader);
			this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.sidebarPanel.Location = new System.Drawing.Point(0, 66);
			this.sidebarPanel.Name = "sidebarPanel";
			this.sidebarPanel.Size = new System.Drawing.Size(240, 702);
			this.sidebarPanel.TabIndex = 1;
			// 
			// btnNavSummary
			// 
			this.btnNavSummary.BackColor = System.Drawing.Color.White;
			this.btnNavSummary.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavSummary.FlatAppearance.BorderSize = 0;
			this.btnNavSummary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			this.btnNavSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavSummary.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnNavSummary.Location = new System.Drawing.Point(12, 488);
			this.btnNavSummary.Name = "btnNavSummary";
			this.btnNavSummary.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavSummary.Size = new System.Drawing.Size(216, 42);
			this.btnNavSummary.TabIndex = 11;
			this.btnNavSummary.Text = "Discharge Summary";
			this.btnNavSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNavSummary.UseVisualStyleBackColor = false;
			// 
			// btnNavDischarge
			// 
			this.btnNavDischarge.BackColor = System.Drawing.Color.White;
			this.btnNavDischarge.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavDischarge.FlatAppearance.BorderSize = 0;
			this.btnNavDischarge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			this.btnNavDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavDischarge.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavDischarge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnNavDischarge.Location = new System.Drawing.Point(12, 444);
			this.btnNavDischarge.Name = "btnNavDischarge";
			this.btnNavDischarge.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavDischarge.Size = new System.Drawing.Size(216, 42);
			this.btnNavDischarge.TabIndex = 10;
			this.btnNavDischarge.Text = "Discharge";
			this.btnNavDischarge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNavDischarge.UseVisualStyleBackColor = false;
			// 
			// btnNavBilling
			// 
			this.btnNavBilling.BackColor = System.Drawing.Color.White;
			this.btnNavBilling.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavBilling.FlatAppearance.BorderSize = 0;
			this.btnNavBilling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			this.btnNavBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavBilling.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavBilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnNavBilling.Location = new System.Drawing.Point(12, 400);
			this.btnNavBilling.Name = "btnNavBilling";
			this.btnNavBilling.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavBilling.Size = new System.Drawing.Size(216, 42);
			this.btnNavBilling.TabIndex = 9;
			this.btnNavBilling.Text = "Billing";
			this.btnNavBilling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNavBilling.UseVisualStyleBackColor = false;
			// 
			// btnNavTreatment
			// 
			this.btnNavTreatment.BackColor = System.Drawing.Color.White;
			this.btnNavTreatment.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavTreatment.FlatAppearance.BorderSize = 0;
			this.btnNavTreatment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			this.btnNavTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavTreatment.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavTreatment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnNavTreatment.Location = new System.Drawing.Point(12, 356);
			this.btnNavTreatment.Name = "btnNavTreatment";
			this.btnNavTreatment.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavTreatment.Size = new System.Drawing.Size(216, 42);
			this.btnNavTreatment.TabIndex = 8;
			this.btnNavTreatment.Text = "Treatment / Billing";
			this.btnNavTreatment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNavTreatment.UseVisualStyleBackColor = false;
			// 
			// btnNavDoctorNurse
			// 
			this.btnNavDoctorNurse.BackColor = System.Drawing.Color.White;
			this.btnNavDoctorNurse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavDoctorNurse.FlatAppearance.BorderSize = 0;
			this.btnNavDoctorNurse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			this.btnNavDoctorNurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavDoctorNurse.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavDoctorNurse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnNavDoctorNurse.Location = new System.Drawing.Point(12, 312);
			this.btnNavDoctorNurse.Name = "btnNavDoctorNurse";
			this.btnNavDoctorNurse.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavDoctorNurse.Size = new System.Drawing.Size(216, 42);
			this.btnNavDoctorNurse.TabIndex = 7;
			this.btnNavDoctorNurse.Text = "Doctor / Nurse";
			this.btnNavDoctorNurse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNavDoctorNurse.UseVisualStyleBackColor = false;
			// 
			// btnNavAdmissionLog
			// 
			this.btnNavAdmissionLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnNavAdmissionLog.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavAdmissionLog.FlatAppearance.BorderSize = 0;
			this.btnNavAdmissionLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnNavAdmissionLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavAdmissionLog.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnNavAdmissionLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
			this.btnNavAdmissionLog.Location = new System.Drawing.Point(12, 268);
			this.btnNavAdmissionLog.Name = "btnNavAdmissionLog";
			this.btnNavAdmissionLog.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavAdmissionLog.Size = new System.Drawing.Size(216, 42);
			this.btnNavAdmissionLog.TabIndex = 6;
			this.btnNavAdmissionLog.Text = "Admission Log";
			this.btnNavAdmissionLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNavAdmissionLog.UseVisualStyleBackColor = false;
			// 
			// btnNavAdmission
			// 
			this.btnNavAdmission.BackColor = System.Drawing.Color.White;
			this.btnNavAdmission.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavAdmission.FlatAppearance.BorderSize = 0;
			this.btnNavAdmission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			this.btnNavAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavAdmission.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavAdmission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnNavAdmission.Location = new System.Drawing.Point(12, 224);
			this.btnNavAdmission.Name = "btnNavAdmission";
			this.btnNavAdmission.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavAdmission.Size = new System.Drawing.Size(216, 42);
			this.btnNavAdmission.TabIndex = 5;
			this.btnNavAdmission.Text = "Admission";
			this.btnNavAdmission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNavAdmission.UseVisualStyleBackColor = false;
			// 
			// btnNavRoomSearch
			// 
			this.btnNavRoomSearch.BackColor = System.Drawing.Color.White;
			this.btnNavRoomSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavRoomSearch.FlatAppearance.BorderSize = 0;
			this.btnNavRoomSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			this.btnNavRoomSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavRoomSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavRoomSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnNavRoomSearch.Location = new System.Drawing.Point(12, 180);
			this.btnNavRoomSearch.Name = "btnNavRoomSearch";
			this.btnNavRoomSearch.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavRoomSearch.Size = new System.Drawing.Size(216, 42);
			this.btnNavRoomSearch.TabIndex = 4;
			this.btnNavRoomSearch.Text = "Patient Room Search";
			this.btnNavRoomSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNavRoomSearch.UseVisualStyleBackColor = false;
			// 
			// btnNavPatientSearch
			// 
			this.btnNavPatientSearch.BackColor = System.Drawing.Color.White;
			this.btnNavPatientSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavPatientSearch.FlatAppearance.BorderSize = 0;
			this.btnNavPatientSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			this.btnNavPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavPatientSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavPatientSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnNavPatientSearch.Location = new System.Drawing.Point(12, 136);
			this.btnNavPatientSearch.Name = "btnNavPatientSearch";
			this.btnNavPatientSearch.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavPatientSearch.Size = new System.Drawing.Size(216, 42);
			this.btnNavPatientSearch.TabIndex = 3;
			this.btnNavPatientSearch.Text = "Patient Info Search";
			this.btnNavPatientSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNavPatientSearch.UseVisualStyleBackColor = false;
			// 
			// btnNavPatient
			// 
			this.btnNavPatient.BackColor = System.Drawing.Color.White;
			this.btnNavPatient.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavPatient.FlatAppearance.BorderSize = 0;
			this.btnNavPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			this.btnNavPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavPatient.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnNavPatient.Location = new System.Drawing.Point(12, 92);
			this.btnNavPatient.Name = "btnNavPatient";
			this.btnNavPatient.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavPatient.Size = new System.Drawing.Size(216, 42);
			this.btnNavPatient.TabIndex = 2;
			this.btnNavPatient.Text = "Patient Information";
			this.btnNavPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNavPatient.UseVisualStyleBackColor = false;
			// 
			// btnNavRoom
			// 
			this.btnNavRoom.BackColor = System.Drawing.Color.White;
			this.btnNavRoom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavRoom.FlatAppearance.BorderSize = 0;
			this.btnNavRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			this.btnNavRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnNavRoom.Location = new System.Drawing.Point(12, 48);
			this.btnNavRoom.Name = "btnNavRoom";
			this.btnNavRoom.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavRoom.Size = new System.Drawing.Size(216, 42);
			this.btnNavRoom.TabIndex = 1;
			this.btnNavRoom.Text = "Room Management";
			this.btnNavRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNavRoom.UseVisualStyleBackColor = false;
			// 
			// lblSidebarHeader
			// 
			this.lblSidebarHeader.AutoSize = true;
			this.lblSidebarHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblSidebarHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
			this.lblSidebarHeader.Location = new System.Drawing.Point(22, 18);
			this.lblSidebarHeader.Name = "lblSidebarHeader";
			this.lblSidebarHeader.Size = new System.Drawing.Size(80, 20);
			this.lblSidebarHeader.TabIndex = 0;
			this.lblSidebarHeader.Text = "MODULES";
			// 
			// sidebarBorder
			// 
			this.sidebarBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
			this.sidebarBorder.Dock = System.Windows.Forms.DockStyle.Left;
			this.sidebarBorder.Location = new System.Drawing.Point(240, 66);
			this.sidebarBorder.Name = "sidebarBorder";
			this.sidebarBorder.Size = new System.Drawing.Size(1, 702);
			this.sidebarBorder.TabIndex = 4;
			// 
			// contentPanel
			// 
			this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.contentPanel.Controls.Add(this.cardPanel);
			this.contentPanel.Controls.Add(this.toolbarPanel);
			this.contentPanel.Controls.Add(this.lblSubtitle);
			this.contentPanel.Controls.Add(this.lblTitle);
			this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentPanel.Location = new System.Drawing.Point(241, 66);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Size = new System.Drawing.Size(1125, 702);
			this.contentPanel.TabIndex = 2;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
			this.lblTitle.Location = new System.Drawing.Point(35, 25);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(320, 41);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Admission Log History";
			// 
			// lblSubtitle
			// 
			this.lblSubtitle.AutoSize = true;
			this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			this.lblSubtitle.Location = new System.Drawing.Point(38, 68);
			this.lblSubtitle.Name = "lblSubtitle";
			this.lblSubtitle.Size = new System.Drawing.Size(420, 23);
			this.lblSubtitle.TabIndex = 1;
			this.lblSubtitle.Text = "View the complete history of all admissions";
			// 
			// toolbarPanel
			// 
			this.toolbarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.toolbarPanel.BackColor = System.Drawing.Color.White;
			this.toolbarPanel.Controls.Add(this.btnFilter);
			this.toolbarPanel.Controls.Add(this.cmbStatus);
			this.toolbarPanel.Controls.Add(this.lblStatus);
			this.toolbarPanel.Controls.Add(this.txtSearch);
			this.toolbarPanel.Controls.Add(this.lblSearch);
			this.toolbarPanel.Controls.Add(this.dtpTo);
			this.toolbarPanel.Controls.Add(this.lblTo);
			this.toolbarPanel.Controls.Add(this.dtpFrom);
			this.toolbarPanel.Controls.Add(this.lblFrom);
			this.toolbarPanel.Location = new System.Drawing.Point(35, 110);
			this.toolbarPanel.Name = "toolbarPanel";
			this.toolbarPanel.Size = new System.Drawing.Size(1060, 70);
			this.toolbarPanel.TabIndex = 2;
			// 
			// lblFrom
			// 
			this.lblFrom.AutoSize = true;
			this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblFrom.Location = new System.Drawing.Point(20, 22);
			this.lblFrom.Name = "lblFrom";
			this.lblFrom.Size = new System.Drawing.Size(55, 23);
			this.lblFrom.TabIndex = 0;
			this.lblFrom.Text = "From:";
			// 
			// dtpFrom
			// 
			this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFrom.Location = new System.Drawing.Point(80, 19);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.ShowCheckBox = true;
			this.dtpFrom.Size = new System.Drawing.Size(140, 30);
			this.dtpFrom.TabIndex = 1;
			// 
			// lblTo
			// 
			this.lblTo.AutoSize = true;
			this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblTo.Location = new System.Drawing.Point(235, 22);
			this.lblTo.Name = "lblTo";
			this.lblTo.Size = new System.Drawing.Size(33, 23);
			this.lblTo.TabIndex = 2;
			this.lblTo.Text = "To:";
			// 
			// dtpTo
			// 
			this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpTo.Location = new System.Drawing.Point(275, 19);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.ShowCheckBox = true;
			this.dtpTo.Size = new System.Drawing.Size(140, 30);
			this.dtpTo.TabIndex = 3;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblSearch.Location = new System.Drawing.Point(430, 22);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(63, 23);
			this.lblSearch.TabIndex = 4;
			this.lblSearch.Text = "Search:";
			// 
			// txtSearch
			// 
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtSearch.Location = new System.Drawing.Point(500, 19);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(180, 30);
			this.txtSearch.TabIndex = 5;
			this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblStatus.Location = new System.Drawing.Point(695, 22);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(66, 23);
			this.lblStatus.TabIndex = 6;
			this.lblStatus.Text = "Status:";
			// 
			// cmbStatus
			// 
			this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Location = new System.Drawing.Point(765, 19);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(130, 31);
			this.cmbStatus.TabIndex = 7;
			// 
			// btnFilter
			// 
			this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFilter.FlatAppearance.BorderSize = 0;
			this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnFilter.ForeColor = System.Drawing.Color.White;
			this.btnFilter.Location = new System.Drawing.Point(910, 19);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(120, 32);
			this.btnFilter.TabIndex = 8;
			this.btnFilter.Text = "🔍  Filter";
			this.btnFilter.UseVisualStyleBackColor = false;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// cardPanel
			// 
			this.cardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.cardPanel.BackColor = System.Drawing.Color.White;
			this.cardPanel.Controls.Add(this.dgvAdmissions);
			this.cardPanel.Controls.Add(this.lblCount);
			this.cardPanel.Location = new System.Drawing.Point(35, 190);
			this.cardPanel.Name = "cardPanel";
			this.cardPanel.Size = new System.Drawing.Size(1060, 480);
			this.cardPanel.TabIndex = 3;
			// 
			// dgvAdmissions
			// 
			this.dgvAdmissions.AllowUserToAddRows = false;
			this.dgvAdmissions.AllowUserToDeleteRows = false;
			this.dgvAdmissions.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.dgvAdmissions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAdmissions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAdmissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAdmissions.BackgroundColor = System.Drawing.Color.White;
			this.dgvAdmissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvAdmissions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvAdmissions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			this.dgvAdmissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvAdmissions.ColumnHeadersHeight = 55;
			this.dgvAdmissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvAdmissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colAdmissionCode,
			this.colAdmitDate,
			this.colPatient,
			this.colRoom,
			this.colStatus,
			this.colPerformedBy});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAdmissions.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvAdmissions.EnableHeadersVisualStyles = false;
			this.dgvAdmissions.GridColor = System.Drawing.Color.White;
			this.dgvAdmissions.Location = new System.Drawing.Point(0, 0);
			this.dgvAdmissions.MultiSelect = false;
			this.dgvAdmissions.Name = "dgvAdmissions";
			this.dgvAdmissions.ReadOnly = true;
			this.dgvAdmissions.RowHeadersVisible = false;
			this.dgvAdmissions.RowHeadersWidth = 51;
			this.dgvAdmissions.RowTemplate.Height = 50;
			this.dgvAdmissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAdmissions.Size = new System.Drawing.Size(1060, 435);
			this.dgvAdmissions.TabIndex = 0;
			this.dgvAdmissions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmissions_CellDoubleClick);
			// 
			// colAdmissionCode
			// 
			this.colAdmissionCode.FillWeight = 12F;
			this.colAdmissionCode.HeaderText = "Admission Code";
			this.colAdmissionCode.MinimumWidth = 6;
			this.colAdmissionCode.Name = "colAdmissionCode";
			this.colAdmissionCode.ReadOnly = true;
			// 
			// colAdmitDate
			// 
			this.colAdmitDate.FillWeight = 15F;
			this.colAdmitDate.HeaderText = "Admit Date";
			this.colAdmitDate.MinimumWidth = 6;
			this.colAdmitDate.Name = "colAdmitDate";
			this.colAdmitDate.ReadOnly = true;
			// 
			// colPatient
			// 
			this.colPatient.FillWeight = 33F;
			this.colPatient.HeaderText = "Patient";
			this.colPatient.MinimumWidth = 6;
			this.colPatient.Name = "colPatient";
			this.colPatient.ReadOnly = true;
			// 
			// colRoom
			// 
			this.colRoom.FillWeight = 8F;
			this.colRoom.HeaderText = "Room";
			this.colRoom.MinimumWidth = 6;
			this.colRoom.Name = "colRoom";
			this.colRoom.ReadOnly = true;
			// 
			// colStatus
			// 
			this.colStatus.FillWeight = 12F;
			this.colStatus.HeaderText = "Status";
			this.colStatus.MinimumWidth = 6;
			this.colStatus.Name = "colStatus";
			this.colStatus.ReadOnly = true;
			// 
			// colPerformedBy
			// 
			this.colPerformedBy.FillWeight = 20F;
			this.colPerformedBy.HeaderText = "Performed By";
			this.colPerformedBy.MinimumWidth = 6;
			this.colPerformedBy.Name = "colPerformedBy";
			this.colPerformedBy.ReadOnly = true;
			// 
			// lblCount
			// 
			this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblCount.AutoSize = true;
			this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			this.lblCount.Location = new System.Drawing.Point(20, 445);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(134, 23);
			this.lblCount.TabIndex = 1;
			this.lblCount.Text = "Total Results: 0";
			// 
			// AdmissionLogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(1366, 768);
			this.Controls.Add(this.contentPanel);
			this.Controls.Add(this.sidebarBorder);
			this.Controls.Add(this.sidebarPanel);
			this.Controls.Add(this.headerBorder);
			this.Controls.Add(this.headerPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.MinimumSize = new System.Drawing.Size(1200, 700);
			this.Name = "AdmissionLogForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admission Log History";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.AdmissionLogForm_Load);
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.sidebarPanel.ResumeLayout(false);
			this.sidebarPanel.PerformLayout();
			this.contentPanel.ResumeLayout(false);
			this.contentPanel.PerformLayout();
			this.cardPanel.ResumeLayout(false);
			this.cardPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAdmissions)).EndInit();
			this.toolbarPanel.ResumeLayout(false);
			this.toolbarPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.Label lblBrand;
		private System.Windows.Forms.Label lblUserInfo;
		private System.Windows.Forms.Button btnMainMenu;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Panel headerBorder;
		private System.Windows.Forms.Panel sidebarPanel;
		private System.Windows.Forms.Label lblSidebarHeader;
		private System.Windows.Forms.Button btnNavRoom;
		private System.Windows.Forms.Button btnNavPatient;
		private System.Windows.Forms.Button btnNavPatientSearch;
		private System.Windows.Forms.Button btnNavRoomSearch;
		private System.Windows.Forms.Button btnNavAdmission;
		private System.Windows.Forms.Button btnNavAdmissionLog;
		private System.Windows.Forms.Button btnNavDoctorNurse;
		private System.Windows.Forms.Button btnNavTreatment;
		private System.Windows.Forms.Button btnNavBilling;
		private System.Windows.Forms.Button btnNavDischarge;
		private System.Windows.Forms.Button btnNavSummary;
		private System.Windows.Forms.Panel sidebarBorder;
		private System.Windows.Forms.Panel contentPanel;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblSubtitle;
		private System.Windows.Forms.Panel toolbarPanel;
		private System.Windows.Forms.Label lblFrom;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.Label lblTo;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Button btnFilter;
		private System.Windows.Forms.Panel cardPanel;
		private System.Windows.Forms.DataGridView dgvAdmissions;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAdmissionCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAdmitDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPatient;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPerformedBy;
		private System.Windows.Forms.Label lblCount;
	}
}