namespace UI
{
	partial class RoomManagementForm
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
			this.btnMainMenu = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
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
			this.dgvRooms = new System.Windows.Forms.DataGridView();
			this.colRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colActions = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblCount = new System.Windows.Forms.Label();
			this.toolbarPanel = new System.Windows.Forms.Panel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
			this.lblStatusFilter = new System.Windows.Forms.Label();
			this.lblSubtitle = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.headerPanel.SuspendLayout();
			this.sidebarPanel.SuspendLayout();
			this.contentPanel.SuspendLayout();
			this.cardPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
			this.toolbarPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// headerPanel
			// 
			this.headerPanel.BackColor = System.Drawing.Color.White;
			this.headerPanel.Controls.Add(this.btnMainMenu);
			this.headerPanel.Controls.Add(this.btnLogout);
			this.headerPanel.Controls.Add(this.lblUserInfo);
			this.headerPanel.Controls.Add(this.lblBrand);
			this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerPanel.Location = new System.Drawing.Point(0, 0);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(1366, 65);
			this.headerPanel.TabIndex = 0;
			// 
			// btnMainMenu
			// 
			this.btnMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMainMenu.BackColor = System.Drawing.Color.White;
			this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
			this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnMainMenu.Location = new System.Drawing.Point(1104, 18);
			this.btnMainMenu.Name = "btnMainMenu";
			this.btnMainMenu.Size = new System.Drawing.Size(110, 32);
			this.btnMainMenu.TabIndex = 3;
			this.btnMainMenu.Text = "Main Menu";
			this.btnMainMenu.UseVisualStyleBackColor = false;
			this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
			this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogout.FlatAppearance.BorderSize = 0;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.ForeColor = System.Drawing.Color.White;
			this.btnLogout.Location = new System.Drawing.Point(1240, 18);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(106, 32);
			this.btnLogout.TabIndex = 2;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// lblUserInfo
			// 
			this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblUserInfo.AutoSize = true;
			this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblUserInfo.Location = new System.Drawing.Point(807, 23);
			this.lblUserInfo.Name = "lblUserInfo";
			this.lblUserInfo.Size = new System.Drawing.Size(271, 23);
			this.lblUserInfo.TabIndex = 1;
			this.lblUserInfo.Text = "Logged in as: [Name] | Role: [Role]";
			// 
			// lblBrand
			// 
			this.lblBrand.AutoSize = true;
			this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.btnNavSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.btnNavDischarge.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.btnNavBilling.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.btnNavTreatment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.btnNavDoctorNurse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.btnNavAdmissionLog.BackColor = System.Drawing.Color.White;
			this.btnNavAdmissionLog.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavAdmissionLog.FlatAppearance.BorderSize = 0;
			this.btnNavAdmissionLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			this.btnNavAdmissionLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavAdmissionLog.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.btnNavAdmission.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.btnNavRoomSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.btnNavPatientSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.btnNavPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.btnNavRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnNavRoom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavRoom.FlatAppearance.BorderSize = 0;
			this.btnNavRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnNavRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNavRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
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
			this.lblSidebarHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			// cardPanel
			// 
			this.cardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cardPanel.BackColor = System.Drawing.Color.White;
			this.cardPanel.Controls.Add(this.dgvRooms);
			this.cardPanel.Controls.Add(this.lblCount);
			this.cardPanel.Location = new System.Drawing.Point(35, 182);
			this.cardPanel.Name = "cardPanel";
			this.cardPanel.Size = new System.Drawing.Size(1060, 500);
			this.cardPanel.TabIndex = 3;
			// 
			// dgvRooms
			// 
			this.dgvRooms.AllowUserToAddRows = false;
			this.dgvRooms.AllowUserToDeleteRows = false;
			this.dgvRooms.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.dgvRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
			this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			this.dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvRooms.ColumnHeadersHeight = 55;
			this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomNumber,
            this.colType,
            this.colRate,
            this.colStatus,
            this.colActions});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvRooms.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvRooms.EnableHeadersVisualStyles = false;
			this.dgvRooms.GridColor = System.Drawing.Color.White;
			this.dgvRooms.Location = new System.Drawing.Point(0, 0);
			this.dgvRooms.MultiSelect = false;
			this.dgvRooms.Name = "dgvRooms";
			this.dgvRooms.ReadOnly = true;
			this.dgvRooms.RowHeadersVisible = false;
			this.dgvRooms.RowHeadersWidth = 51;
			this.dgvRooms.RowTemplate.Height = 50;
			this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRooms.Size = new System.Drawing.Size(1060, 455);
			this.dgvRooms.TabIndex = 0;
			this.dgvRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellClick);
			this.dgvRooms.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvRooms_CellPainting);
			// 
			// colRoomNumber
			// 
			this.colRoomNumber.DataPropertyName = "RoomNumber";
			this.colRoomNumber.FillWeight = 17F;
			this.colRoomNumber.HeaderText = "Room #";
			this.colRoomNumber.MinimumWidth = 6;
			this.colRoomNumber.Name = "colRoomNumber";
			this.colRoomNumber.ReadOnly = true;
			// 
			// colType
			// 
			this.colType.DataPropertyName = "RoomType";
			this.colType.FillWeight = 27F;
			this.colType.HeaderText = "Type";
			this.colType.MinimumWidth = 6;
			this.colType.Name = "colType";
			this.colType.ReadOnly = true;
			// 
			// colRate
			// 
			this.colRate.DataPropertyName = "Rate";
			this.colRate.FillWeight = 22F;
			this.colRate.HeaderText = "Rate / Day";
			this.colRate.MinimumWidth = 6;
			this.colRate.Name = "colRate";
			this.colRate.ReadOnly = true;
			// 
			// colStatus
			// 
			this.colStatus.DataPropertyName = "Status";
			this.colStatus.FillWeight = 22F;
			this.colStatus.HeaderText = "Status";
			this.colStatus.MinimumWidth = 6;
			this.colStatus.Name = "colStatus";
			this.colStatus.ReadOnly = true;
			// 
			// colActions
			// 
			this.colActions.FillWeight = 15F;
			this.colActions.HeaderText = "Actions";
			this.colActions.MinimumWidth = 6;
			this.colActions.Name = "colActions";
			this.colActions.ReadOnly = true;
			// 
			// lblCount
			// 
			this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblCount.AutoSize = true;
			this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			this.lblCount.Location = new System.Drawing.Point(20, 466);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(128, 23);
			this.lblCount.TabIndex = 1;
			this.lblCount.Text = "Total Rooms: 0";
			// 
			// toolbarPanel
			// 
			this.toolbarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.toolbarPanel.BackColor = System.Drawing.Color.White;
			this.toolbarPanel.Controls.Add(this.btnAdd);
			this.toolbarPanel.Controls.Add(this.cmbStatusFilter);
			this.toolbarPanel.Controls.Add(this.lblStatusFilter);
			this.toolbarPanel.Location = new System.Drawing.Point(35, 110);
			this.toolbarPanel.Name = "toolbarPanel";
			this.toolbarPanel.Size = new System.Drawing.Size(1060, 60);
			this.toolbarPanel.TabIndex = 2;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(860, 14);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(180, 36);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "+  Add New Room";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// cmbStatusFilter
			// 
			this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStatusFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbStatusFilter.FormattingEnabled = true;
			this.cmbStatusFilter.Location = new System.Drawing.Point(148, 17);
			this.cmbStatusFilter.Name = "cmbStatusFilter";
			this.cmbStatusFilter.Size = new System.Drawing.Size(180, 31);
			this.cmbStatusFilter.TabIndex = 1;
			this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
			// 
			// lblStatusFilter
			// 
			this.lblStatusFilter.AutoSize = true;
			this.lblStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatusFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblStatusFilter.Location = new System.Drawing.Point(20, 20);
			this.lblStatusFilter.Name = "lblStatusFilter";
			this.lblStatusFilter.Size = new System.Drawing.Size(137, 23);
			this.lblStatusFilter.TabIndex = 0;
			this.lblStatusFilter.Text = "Filter by Status:";
			// 
			// lblSubtitle
			// 
			this.lblSubtitle.AutoSize = true;
			this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			this.lblSubtitle.Location = new System.Drawing.Point(38, 68);
			this.lblSubtitle.Name = "lblSubtitle";
			this.lblSubtitle.Size = new System.Drawing.Size(407, 23);
			this.lblSubtitle.TabIndex = 1;
			this.lblSubtitle.Text = "Manage hospital rooms, types, rates, and availability";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
			this.lblTitle.Location = new System.Drawing.Point(35, 25);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(295, 41);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Room Management";
			// 
			// RoomManagementForm
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
			this.Name = "RoomManagementForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Room Management";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.RoomManagementForm_Load);
			this.Shown += new System.EventHandler(this.RoomManagementForm_Shown);
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.sidebarPanel.ResumeLayout(false);
			this.sidebarPanel.PerformLayout();
			this.contentPanel.ResumeLayout(false);
			this.contentPanel.PerformLayout();
			this.cardPanel.ResumeLayout(false);
			this.cardPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
			this.toolbarPanel.ResumeLayout(false);
			this.toolbarPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.Label lblBrand;
		private System.Windows.Forms.Label lblUserInfo;
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
		private System.Windows.Forms.Label lblStatusFilter;
		private System.Windows.Forms.ComboBox cmbStatusFilter;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Panel cardPanel;
		private System.Windows.Forms.DataGridView dgvRooms;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRoomNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn colType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn colActions;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.Button btnMainMenu;
	}
}