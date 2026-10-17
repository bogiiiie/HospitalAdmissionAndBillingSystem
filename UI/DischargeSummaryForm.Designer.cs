namespace UI
{
	partial class DischargeSummaryForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

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
			this.btnNavDoctorNurse = new System.Windows.Forms.Button();
			this.btnNavTreatment = new System.Windows.Forms.Button();
			this.btnNavAdmissionLog = new System.Windows.Forms.Button();
			this.btnNavAdmission = new System.Windows.Forms.Button();
			this.btnNavRoomSearch = new System.Windows.Forms.Button();
			this.btnNavPatientSearch = new System.Windows.Forms.Button();
			this.btnNavPatient = new System.Windows.Forms.Button();
			this.btnNavRoom = new System.Windows.Forms.Button();
			this.lblSidebarHeader = new System.Windows.Forms.Label();
			this.sidebarBorder = new System.Windows.Forms.Panel();
			this.panelBody = new System.Windows.Forms.Panel();
			this.btnPrint = new System.Windows.Forms.Button();
			this.lblTotalPaid = new System.Windows.Forms.Label();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.lblTreatmentCharges = new System.Windows.Forms.Label();
			this.lblRoomCharges = new System.Windows.Forms.Label();
			this.lblSectionBilling = new System.Windows.Forms.Label();
			this.dgvTreatments = new System.Windows.Forms.DataGridView();
			this.colService = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colUnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblSectionTreatments = new System.Windows.Forms.Label();
			this.lblNotes = new System.Windows.Forms.Label();
			this.lblNurse = new System.Windows.Forms.Label();
			this.lblDoctor = new System.Windows.Forms.Label();
			this.lblDiagnosis = new System.Windows.Forms.Label();
			this.lblDischargeDate = new System.Windows.Forms.Label();
			this.lblAdmitDate = new System.Windows.Forms.Label();
			this.lblRoom = new System.Windows.Forms.Label();
			this.lblAdmissionCode = new System.Windows.Forms.Label();
			this.lblSectionStay = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblContact = new System.Windows.Forms.Label();
			this.lblDob = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.lblPatientId = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblSectionPatient = new System.Windows.Forms.Label();
			this.toolbarPanel = new System.Windows.Forms.Panel();
			this.btnFind = new System.Windows.Forms.Button();
			this.txtPatient = new System.Windows.Forms.TextBox();
			this.lblPatient = new System.Windows.Forms.Label();
			this.headerPanel.SuspendLayout();
			this.sidebarPanel.SuspendLayout();
			this.panelBody.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
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
			this.sidebarPanel.Controls.Add(this.btnNavDoctorNurse);
			this.sidebarPanel.Controls.Add(this.btnNavTreatment);
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
			this.sidebarPanel.Size = new System.Drawing.Size(240, 742);
			this.sidebarPanel.TabIndex = 1;
			// 
			// btnNavSummary
			// 
			this.btnNavSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnNavSummary.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavSummary.FlatAppearance.BorderSize = 0;
			this.btnNavSummary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnNavSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnNavSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
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
			// btnNavAdmissionLog
			// 
			this.btnNavAdmissionLog.BackColor = System.Drawing.Color.White;
			this.btnNavAdmissionLog.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavAdmissionLog.FlatAppearance.BorderSize = 0;
			this.btnNavAdmissionLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			this.btnNavAdmissionLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavAdmissionLog.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavAdmissionLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
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
			this.sidebarBorder.Size = new System.Drawing.Size(1, 742);
			this.sidebarBorder.TabIndex = 4;
			// 
			// panelBody
			// 
			this.panelBody.AutoScroll = true;
			this.panelBody.BackColor = System.Drawing.Color.White;
			this.panelBody.Controls.Add(this.btnPrint);
			this.panelBody.Controls.Add(this.lblTotalPaid);
			this.panelBody.Controls.Add(this.lblDiscount);
			this.panelBody.Controls.Add(this.lblTreatmentCharges);
			this.panelBody.Controls.Add(this.lblRoomCharges);
			this.panelBody.Controls.Add(this.lblSectionBilling);
			this.panelBody.Controls.Add(this.dgvTreatments);
			this.panelBody.Controls.Add(this.lblSectionTreatments);
			this.panelBody.Controls.Add(this.lblNotes);
			this.panelBody.Controls.Add(this.lblNurse);
			this.panelBody.Controls.Add(this.lblDoctor);
			this.panelBody.Controls.Add(this.lblDiagnosis);
			this.panelBody.Controls.Add(this.lblDischargeDate);
			this.panelBody.Controls.Add(this.lblAdmitDate);
			this.panelBody.Controls.Add(this.lblRoom);
			this.panelBody.Controls.Add(this.lblAdmissionCode);
			this.panelBody.Controls.Add(this.lblSectionStay);
			this.panelBody.Controls.Add(this.lblAddress);
			this.panelBody.Controls.Add(this.lblContact);
			this.panelBody.Controls.Add(this.lblDob);
			this.panelBody.Controls.Add(this.lblGender);
			this.panelBody.Controls.Add(this.lblPatientId);
			this.panelBody.Controls.Add(this.lblName);
			this.panelBody.Controls.Add(this.lblSectionPatient);
			this.panelBody.Controls.Add(this.toolbarPanel);
			this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBody.Location = new System.Drawing.Point(241, 66);
			this.panelBody.Name = "panelBody";
			this.panelBody.Size = new System.Drawing.Size(1125, 742);
			this.panelBody.TabIndex = 2;
			this.panelBody.Visible = false;
			// 
			// btnPrint
			// 
			this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrint.FlatAppearance.BorderSize = 0;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnPrint.ForeColor = System.Drawing.Color.White;
			this.btnPrint.Location = new System.Drawing.Point(30, 790);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(150, 40);
			this.btnPrint.TabIndex = 24;
			this.btnPrint.Text = "🖨️ Print";
			this.btnPrint.UseVisualStyleBackColor = false;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// lblTotalPaid
			// 
			this.lblTotalPaid.AutoSize = true;
			this.lblTotalPaid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblTotalPaid.ForeColor = System.Drawing.Color.Green;
			this.lblTotalPaid.Location = new System.Drawing.Point(30, 740);
			this.lblTotalPaid.Name = "lblTotalPaid";
			this.lblTotalPaid.Size = new System.Drawing.Size(32, 28);
			this.lblTotalPaid.TabIndex = 23;
			this.lblTotalPaid.Text = "—";
			// 
			// lblDiscount
			// 
			this.lblDiscount.AutoSize = true;
			this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblDiscount.Location = new System.Drawing.Point(30, 710);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(27, 23);
			this.lblDiscount.TabIndex = 22;
			this.lblDiscount.Text = "—";
			// 
			// lblTreatmentCharges
			// 
			this.lblTreatmentCharges.AutoSize = true;
			this.lblTreatmentCharges.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblTreatmentCharges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblTreatmentCharges.Location = new System.Drawing.Point(30, 680);
			this.lblTreatmentCharges.Name = "lblTreatmentCharges";
			this.lblTreatmentCharges.Size = new System.Drawing.Size(27, 23);
			this.lblTreatmentCharges.TabIndex = 21;
			this.lblTreatmentCharges.Text = "—";
			// 
			// lblRoomCharges
			// 
			this.lblRoomCharges.AutoSize = true;
			this.lblRoomCharges.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblRoomCharges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblRoomCharges.Location = new System.Drawing.Point(30, 650);
			this.lblRoomCharges.Name = "lblRoomCharges";
			this.lblRoomCharges.Size = new System.Drawing.Size(27, 23);
			this.lblRoomCharges.TabIndex = 20;
			this.lblRoomCharges.Text = "—";
			// 
			// lblSectionBilling
			// 
			this.lblSectionBilling.AutoSize = true;
			this.lblSectionBilling.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblSectionBilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblSectionBilling.Location = new System.Drawing.Point(30, 620);
			this.lblSectionBilling.Name = "lblSectionBilling";
			this.lblSectionBilling.Size = new System.Drawing.Size(177, 23);
			this.lblSectionBilling.TabIndex = 19;
			this.lblSectionBilling.Text = "── FINAL BILLING ──";
			// 
			// dgvTreatments
			// 
			this.dgvTreatments.AllowUserToAddRows = false;
			this.dgvTreatments.AllowUserToDeleteRows = false;
			this.dgvTreatments.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.dgvTreatments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTreatments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTreatments.BackgroundColor = System.Drawing.Color.White;
			this.dgvTreatments.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvTreatments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvTreatments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			this.dgvTreatments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvTreatments.ColumnHeadersHeight = 35;
			this.dgvTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvTreatments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colService,
            this.colDate,
            this.colQty,
            this.colUnitCost,
            this.colTotalCost});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTreatments.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvTreatments.EnableHeadersVisualStyles = false;
			this.dgvTreatments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
			this.dgvTreatments.Location = new System.Drawing.Point(30, 450);
			this.dgvTreatments.MultiSelect = false;
			this.dgvTreatments.Name = "dgvTreatments";
			this.dgvTreatments.ReadOnly = true;
			this.dgvTreatments.RowHeadersVisible = false;
			this.dgvTreatments.RowHeadersWidth = 51;
			this.dgvTreatments.RowTemplate.Height = 35;
			this.dgvTreatments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTreatments.Size = new System.Drawing.Size(960, 150);
			this.dgvTreatments.TabIndex = 18;
			// 
			// colService
			// 
			this.colService.FillWeight = 40F;
			this.colService.HeaderText = "Service/Treatment";
			this.colService.MinimumWidth = 6;
			this.colService.Name = "colService";
			this.colService.ReadOnly = true;
			// 
			// colDate
			// 
			this.colDate.FillWeight = 20F;
			this.colDate.HeaderText = "Date";
			this.colDate.MinimumWidth = 6;
			this.colDate.Name = "colDate";
			this.colDate.ReadOnly = true;
			// 
			// colQty
			// 
			this.colQty.FillWeight = 10F;
			this.colQty.HeaderText = "Qty";
			this.colQty.MinimumWidth = 6;
			this.colQty.Name = "colQty";
			this.colQty.ReadOnly = true;
			// 
			// colUnitCost
			// 
			this.colUnitCost.FillWeight = 15F;
			this.colUnitCost.HeaderText = "Unit Cost";
			this.colUnitCost.MinimumWidth = 6;
			this.colUnitCost.Name = "colUnitCost";
			this.colUnitCost.ReadOnly = true;
			// 
			// colTotalCost
			// 
			this.colTotalCost.FillWeight = 15F;
			this.colTotalCost.HeaderText = "Total Cost";
			this.colTotalCost.MinimumWidth = 6;
			this.colTotalCost.Name = "colTotalCost";
			this.colTotalCost.ReadOnly = true;
			// 
			// lblSectionTreatments
			// 
			this.lblSectionTreatments.AutoSize = true;
			this.lblSectionTreatments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblSectionTreatments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblSectionTreatments.Location = new System.Drawing.Point(30, 420);
			this.lblSectionTreatments.Name = "lblSectionTreatments";
			this.lblSectionTreatments.Size = new System.Drawing.Size(255, 23);
			this.lblSectionTreatments.TabIndex = 17;
			this.lblSectionTreatments.Text = "── TREATMENTS & SERVICES ──";
			// 
			// lblNotes
			// 
			this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblNotes.Location = new System.Drawing.Point(30, 380);
			this.lblNotes.MaximumSize = new System.Drawing.Size(960, 40);
			this.lblNotes.Name = "lblNotes";
			this.lblNotes.Size = new System.Drawing.Size(960, 23);
			this.lblNotes.TabIndex = 16;
			this.lblNotes.Text = "—";
			// 
			// lblNurse
			// 
			this.lblNurse.AutoSize = true;
			this.lblNurse.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblNurse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblNurse.Location = new System.Drawing.Point(400, 350);
			this.lblNurse.Name = "lblNurse";
			this.lblNurse.Size = new System.Drawing.Size(27, 23);
			this.lblNurse.TabIndex = 15;
			this.lblNurse.Text = "—";
			// 
			// lblDoctor
			// 
			this.lblDoctor.AutoSize = true;
			this.lblDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblDoctor.Location = new System.Drawing.Point(30, 350);
			this.lblDoctor.Name = "lblDoctor";
			this.lblDoctor.Size = new System.Drawing.Size(27, 23);
			this.lblDoctor.TabIndex = 14;
			this.lblDoctor.Text = "—";
			// 
			// lblDiagnosis
			// 
			this.lblDiagnosis.AutoSize = true;
			this.lblDiagnosis.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblDiagnosis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblDiagnosis.Location = new System.Drawing.Point(30, 320);
			this.lblDiagnosis.Name = "lblDiagnosis";
			this.lblDiagnosis.Size = new System.Drawing.Size(27, 23);
			this.lblDiagnosis.TabIndex = 13;
			this.lblDiagnosis.Text = "—";
			// 
			// lblDischargeDate
			// 
			this.lblDischargeDate.AutoSize = true;
			this.lblDischargeDate.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblDischargeDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblDischargeDate.Location = new System.Drawing.Point(400, 290);
			this.lblDischargeDate.Name = "lblDischargeDate";
			this.lblDischargeDate.Size = new System.Drawing.Size(27, 23);
			this.lblDischargeDate.TabIndex = 12;
			this.lblDischargeDate.Text = "—";
			// 
			// lblAdmitDate
			// 
			this.lblAdmitDate.AutoSize = true;
			this.lblAdmitDate.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblAdmitDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblAdmitDate.Location = new System.Drawing.Point(30, 290);
			this.lblAdmitDate.Name = "lblAdmitDate";
			this.lblAdmitDate.Size = new System.Drawing.Size(27, 23);
			this.lblAdmitDate.TabIndex = 11;
			this.lblAdmitDate.Text = "—";
			// 
			// lblRoom
			// 
			this.lblRoom.AutoSize = true;
			this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblRoom.Location = new System.Drawing.Point(400, 260);
			this.lblRoom.Name = "lblRoom";
			this.lblRoom.Size = new System.Drawing.Size(27, 23);
			this.lblRoom.TabIndex = 10;
			this.lblRoom.Text = "—";
			// 
			// lblAdmissionCode
			// 
			this.lblAdmissionCode.AutoSize = true;
			this.lblAdmissionCode.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblAdmissionCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblAdmissionCode.Location = new System.Drawing.Point(30, 260);
			this.lblAdmissionCode.Name = "lblAdmissionCode";
			this.lblAdmissionCode.Size = new System.Drawing.Size(27, 23);
			this.lblAdmissionCode.TabIndex = 9;
			this.lblAdmissionCode.Text = "—";
			// 
			// lblSectionStay
			// 
			this.lblSectionStay.AutoSize = true;
			this.lblSectionStay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblSectionStay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblSectionStay.Location = new System.Drawing.Point(30, 230);
			this.lblSectionStay.Name = "lblSectionStay";
			this.lblSectionStay.Size = new System.Drawing.Size(172, 23);
			this.lblSectionStay.TabIndex = 8;
			this.lblSectionStay.Text = "── STAY DETAILS ──";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblAddress.Location = new System.Drawing.Point(400, 190);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(27, 23);
			this.lblAddress.TabIndex = 7;
			this.lblAddress.Text = "—";
			// 
			// lblContact
			// 
			this.lblContact.AutoSize = true;
			this.lblContact.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblContact.Location = new System.Drawing.Point(30, 190);
			this.lblContact.Name = "lblContact";
			this.lblContact.Size = new System.Drawing.Size(27, 23);
			this.lblContact.TabIndex = 6;
			this.lblContact.Text = "—";
			// 
			// lblDob
			// 
			this.lblDob.AutoSize = true;
			this.lblDob.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblDob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblDob.Location = new System.Drawing.Point(400, 160);
			this.lblDob.Name = "lblDob";
			this.lblDob.Size = new System.Drawing.Size(27, 23);
			this.lblDob.TabIndex = 5;
			this.lblDob.Text = "—";
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblGender.Location = new System.Drawing.Point(30, 160);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(27, 23);
			this.lblGender.TabIndex = 4;
			this.lblGender.Text = "—";
			// 
			// lblPatientId
			// 
			this.lblPatientId.AutoSize = true;
			this.lblPatientId.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblPatientId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblPatientId.Location = new System.Drawing.Point(400, 130);
			this.lblPatientId.Name = "lblPatientId";
			this.lblPatientId.Size = new System.Drawing.Size(27, 23);
			this.lblPatientId.TabIndex = 3;
			this.lblPatientId.Text = "—";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblName.Location = new System.Drawing.Point(30, 130);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(27, 23);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "—";
			// 
			// lblSectionPatient
			// 
			this.lblSectionPatient.AutoSize = true;
			this.lblSectionPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblSectionPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblSectionPatient.Location = new System.Drawing.Point(30, 100);
			this.lblSectionPatient.Name = "lblSectionPatient";
			this.lblSectionPatient.Size = new System.Drawing.Size(251, 23);
			this.lblSectionPatient.TabIndex = 1;
			this.lblSectionPatient.Text = "── PATIENT INFORMATION ──";
			// 
			// toolbarPanel
			// 
			this.toolbarPanel.BackColor = System.Drawing.Color.White;
			this.toolbarPanel.Controls.Add(this.btnFind);
			this.toolbarPanel.Controls.Add(this.txtPatient);
			this.toolbarPanel.Controls.Add(this.lblPatient);
			this.toolbarPanel.Location = new System.Drawing.Point(20, 20);
			this.toolbarPanel.Name = "toolbarPanel";
			this.toolbarPanel.Size = new System.Drawing.Size(1020, 60);
			this.toolbarPanel.TabIndex = 0;
			// 
			// btnFind
			// 
			this.btnFind.BackColor = System.Drawing.Color.White;
			this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFind.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnFind.Location = new System.Drawing.Point(840, 17);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(110, 34);
			this.btnFind.TabIndex = 2;
			this.btnFind.Text = "🔍  Find";
			this.btnFind.UseVisualStyleBackColor = false;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// txtPatient
			// 
			this.txtPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPatient.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPatient.Location = new System.Drawing.Point(230, 19);
			this.txtPatient.Name = "txtPatient";
			this.txtPatient.ReadOnly = true;
			this.txtPatient.Size = new System.Drawing.Size(600, 30);
			this.txtPatient.TabIndex = 1;
			// 
			// lblPatient
			// 
			this.lblPatient.AutoSize = true;
			this.lblPatient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblPatient.Location = new System.Drawing.Point(20, 22);
			this.lblPatient.Name = "lblPatient";
			this.lblPatient.Size = new System.Drawing.Size(175, 23);
			this.lblPatient.TabIndex = 0;
			this.lblPatient.Text = "Discharged Patient *";
			// 
			// DischargeSummaryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(1366, 768);
			this.Controls.Add(this.panelBody);
			this.Controls.Add(this.sidebarBorder);
			this.Controls.Add(this.sidebarPanel);
			this.Controls.Add(this.headerBorder);
			this.Controls.Add(this.headerPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.MinimumSize = new System.Drawing.Size(1200, 700);
			this.Name = "DischargeSummaryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Discharge Summary";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.DischargeSummaryForm_Load);
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.sidebarPanel.ResumeLayout(false);
			this.sidebarPanel.PerformLayout();
			this.panelBody.ResumeLayout(false);
			this.panelBody.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
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
		private System.Windows.Forms.Button btnNavTreatment;
		private System.Windows.Forms.Button btnNavDoctorNurse;
		private System.Windows.Forms.Button btnNavBilling;
		private System.Windows.Forms.Button btnNavDischarge;
		private System.Windows.Forms.Button btnNavSummary;
		private System.Windows.Forms.Panel sidebarBorder;
		private System.Windows.Forms.Panel panelBody, toolbarPanel;
		private System.Windows.Forms.Label lblPatient, lblSectionPatient, lblName, lblPatientId, lblGender, lblDob, lblContact, lblAddress;
		private System.Windows.Forms.Label lblSectionStay, lblAdmissionCode, lblRoom, lblAdmitDate, lblDischargeDate, lblDiagnosis, lblDoctor, lblNurse, lblNotes;
		private System.Windows.Forms.Label lblSectionTreatments;
		private System.Windows.Forms.DataGridView dgvTreatments;
		private System.Windows.Forms.DataGridViewTextBoxColumn colService, colDate, colQty, colUnitCost, colTotalCost;
		private System.Windows.Forms.Label lblSectionBilling, lblRoomCharges, lblTreatmentCharges, lblDiscount, lblTotalPaid;
		private System.Windows.Forms.Button btnFind, btnPrint;
		private System.Windows.Forms.TextBox txtPatient;
	}
}