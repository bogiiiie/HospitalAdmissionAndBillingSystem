namespace UI
{
	partial class DoctorNurseAssignmentForm
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
			this.contentPanel = new System.Windows.Forms.Panel();
			this.cardPanel = new System.Windows.Forms.Panel();
			this.dgvHistory = new System.Windows.Forms.DataGridView();
			this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblHistoryTitle = new System.Windows.Forms.Label();
			this.panelUpdate = new System.Windows.Forms.Panel();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.txtReason = new System.Windows.Forms.TextBox();
			this.lblReason = new System.Windows.Forms.Label();
			this.txtNewNurse = new System.Windows.Forms.TextBox();
			this.lblNewNurse = new System.Windows.Forms.Label();
			this.txtNewDoctor = new System.Windows.Forms.TextBox();
			this.lblNewDoctor = new System.Windows.Forms.Label();
			this.lblCurrentNurseValue = new System.Windows.Forms.Label();
			this.lblCurrentDoctorValue = new System.Windows.Forms.Label();
			this.lblCurrentNurse = new System.Windows.Forms.Label();
			this.lblCurrentDoctor = new System.Windows.Forms.Label();
			this.lblCurrentTitle = new System.Windows.Forms.Label();
			this.lblNoResults = new System.Windows.Forms.Label();
			this.toolbarPanel = new System.Windows.Forms.Panel();
			this.btnFindAdmission = new System.Windows.Forms.Button();
			this.txtSelectedAdmission = new System.Windows.Forms.TextBox();
			this.lblAdmission = new System.Windows.Forms.Label();
			this.lblSubtitle = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.headerPanel.SuspendLayout();
			this.sidebarPanel.SuspendLayout();
			this.contentPanel.SuspendLayout();
			this.cardPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
			this.panelUpdate.SuspendLayout();
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
			// btnNavDoctorNurse
			// 
			this.btnNavDoctorNurse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnNavDoctorNurse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavDoctorNurse.FlatAppearance.BorderSize = 0;
			this.btnNavDoctorNurse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnNavDoctorNurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavDoctorNurse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnNavDoctorNurse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
			this.btnNavDoctorNurse.Location = new System.Drawing.Point(12, 356);
			this.btnNavDoctorNurse.Name = "btnNavDoctorNurse";
			this.btnNavDoctorNurse.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavDoctorNurse.Size = new System.Drawing.Size(216, 42);
			this.btnNavDoctorNurse.TabIndex = 8;
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
			this.btnNavTreatment.Location = new System.Drawing.Point(12, 312);
			this.btnNavTreatment.Name = "btnNavTreatment";
			this.btnNavTreatment.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavTreatment.Size = new System.Drawing.Size(216, 42);
			this.btnNavTreatment.TabIndex = 7;
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
			this.cardPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cardPanel.BackColor = System.Drawing.Color.White;
			this.cardPanel.Controls.Add(this.dgvHistory);
			this.cardPanel.Controls.Add(this.lblHistoryTitle);
			this.cardPanel.Controls.Add(this.panelUpdate);
			this.cardPanel.Controls.Add(this.lblNoResults);
			this.cardPanel.Location = new System.Drawing.Point(35, 190);
			this.cardPanel.Name = "cardPanel";
			this.cardPanel.Size = new System.Drawing.Size(1060, 480);
			this.cardPanel.TabIndex = 3;
			// 
			// dgvHistory
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.dgvHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
			this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvHistory.ColumnHeadersHeight = 45;
			this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colDate, this.colRole, this.colStaffName, this.colReason });
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.dgvHistory.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvHistory.EnableHeadersVisualStyles = false;
			this.dgvHistory.Location = new System.Drawing.Point(20, 255);
			this.dgvHistory.MultiSelect = false;
			this.dgvHistory.Name = "dgvHistory";
			this.dgvHistory.ReadOnly = true;
			this.dgvHistory.RowHeadersVisible = false;
			this.dgvHistory.RowTemplate.Height = 45;
			this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHistory.Size = new System.Drawing.Size(1020, 205);
			this.dgvHistory.TabIndex = 3;
			this.dgvHistory.Visible = false;
			// 
			// colDate
			// 
			this.colDate.FillWeight = 20F;
			this.colDate.HeaderText = "Date";
			this.colDate.Name = "colDate";
			this.colDate.ReadOnly = true;
			// 
			// colRole
			// 
			this.colRole.FillWeight = 15F;
			this.colRole.HeaderText = "Role";
			this.colRole.Name = "colRole";
			this.colRole.ReadOnly = true;
			// 
			// colStaffName
			// 
			this.colStaffName.FillWeight = 25F;
			this.colStaffName.HeaderText = "Staff Name";
			this.colStaffName.Name = "colStaffName";
			this.colStaffName.ReadOnly = true;
			// 
			// colReason
			// 
			this.colReason.FillWeight = 40F;
			this.colReason.HeaderText = "Reason";
			this.colReason.Name = "colReason";
			this.colReason.ReadOnly = true;
			// 
			// lblHistoryTitle
			// 
			this.lblHistoryTitle.AutoSize = true;
			this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblHistoryTitle.Location = new System.Drawing.Point(20, 225);
			this.lblHistoryTitle.Name = "lblHistoryTitle";
			this.lblHistoryTitle.Size = new System.Drawing.Size(220, 23);
			this.lblHistoryTitle.TabIndex = 2;
			this.lblHistoryTitle.Text = "ASSIGNMENT HISTORY";
			this.lblHistoryTitle.Visible = false;
			// 
			// panelUpdate
			// 
			this.panelUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.panelUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelUpdate.Controls.Add(this.btnUpdate);
			this.panelUpdate.Controls.Add(this.txtReason);
			this.panelUpdate.Controls.Add(this.lblReason);
			this.panelUpdate.Controls.Add(this.txtNewNurse);
			this.panelUpdate.Controls.Add(this.lblNewNurse);
			this.panelUpdate.Controls.Add(this.txtNewDoctor);
			this.panelUpdate.Controls.Add(this.lblNewDoctor);
			this.panelUpdate.Controls.Add(this.lblCurrentNurseValue);
			this.panelUpdate.Controls.Add(this.lblCurrentDoctorValue);
			this.panelUpdate.Controls.Add(this.lblCurrentNurse);
			this.panelUpdate.Controls.Add(this.lblCurrentDoctor);
			this.panelUpdate.Controls.Add(this.lblCurrentTitle);
			this.panelUpdate.Location = new System.Drawing.Point(20, 20);
			this.panelUpdate.Name = "panelUpdate";
			this.panelUpdate.Size = new System.Drawing.Size(1020, 190);
			this.panelUpdate.TabIndex = 1;
			this.panelUpdate.Visible = false;
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(15, 150);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(180, 30);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.Text = "Update Assignment";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// txtReason
			// 
			this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtReason.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtReason.Location = new System.Drawing.Point(720, 108);
			this.txtReason.Name = "txtReason";
			this.txtReason.Size = new System.Drawing.Size(200, 30);
			this.txtReason.TabIndex = 10;
			// 
			// lblReason
			// 
			this.lblReason.AutoSize = true;
			this.lblReason.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblReason.Location = new System.Drawing.Point(660, 110);
			this.lblReason.Name = "lblReason";
			this.lblReason.Size = new System.Drawing.Size(62, 20);
			this.lblReason.TabIndex = 9;
			this.lblReason.Text = "Reason:";
			// 
			// txtNewNurse
			// 
			this.txtNewNurse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNewNurse.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtNewNurse.Location = new System.Drawing.Point(440, 108);
			this.txtNewNurse.Name = "txtNewNurse";
			this.txtNewNurse.Size = new System.Drawing.Size(200, 30);
			this.txtNewNurse.TabIndex = 8;
			// 
			// lblNewNurse
			// 
			this.lblNewNurse.AutoSize = true;
			this.lblNewNurse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblNewNurse.Location = new System.Drawing.Point(340, 110);
			this.lblNewNurse.Name = "lblNewNurse";
			this.lblNewNurse.Size = new System.Drawing.Size(84, 20);
			this.lblNewNurse.TabIndex = 7;
			this.lblNewNurse.Text = "New Nurse:";
			// 
			// txtNewDoctor
			// 
			this.txtNewDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNewDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtNewDoctor.Location = new System.Drawing.Point(120, 108);
			this.txtNewDoctor.Name = "txtNewDoctor";
			this.txtNewDoctor.Size = new System.Drawing.Size(200, 30);
			this.txtNewDoctor.TabIndex = 6;
			// 
			// lblNewDoctor
			// 
			this.lblNewDoctor.AutoSize = true;
			this.lblNewDoctor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblNewDoctor.Location = new System.Drawing.Point(15, 110);
			this.lblNewDoctor.Name = "lblNewDoctor";
			this.lblNewDoctor.Size = new System.Drawing.Size(92, 20);
			this.lblNewDoctor.TabIndex = 5;
			this.lblNewDoctor.Text = "New Doctor:";
			// 
			// lblCurrentNurseValue
			// 
			this.lblCurrentNurseValue.AutoSize = true;
			this.lblCurrentNurseValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblCurrentNurseValue.Location = new System.Drawing.Point(90, 69);
			this.lblCurrentNurseValue.Name = "lblCurrentNurseValue";
			this.lblCurrentNurseValue.Size = new System.Drawing.Size(50, 23);
			this.lblCurrentNurseValue.TabIndex = 4;
			this.lblCurrentNurseValue.Text = "None";
			// 
			// lblCurrentDoctorValue
			// 
			this.lblCurrentDoctorValue.AutoSize = true;
			this.lblCurrentDoctorValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblCurrentDoctorValue.Location = new System.Drawing.Point(90, 39);
			this.lblCurrentDoctorValue.Name = "lblCurrentDoctorValue";
			this.lblCurrentDoctorValue.Size = new System.Drawing.Size(50, 23);
			this.lblCurrentDoctorValue.TabIndex = 3;
			this.lblCurrentDoctorValue.Text = "None";
			// 
			// lblCurrentNurse
			// 
			this.lblCurrentNurse.AutoSize = true;
			this.lblCurrentNurse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblCurrentNurse.Location = new System.Drawing.Point(15, 70);
			this.lblCurrentNurse.Name = "lblCurrentNurse";
			this.lblCurrentNurse.Size = new System.Drawing.Size(59, 20);
			this.lblCurrentNurse.TabIndex = 2;
			this.lblCurrentNurse.Text = "Nurse:";
			// 
			// lblCurrentDoctor
			// 
			this.lblCurrentDoctor.AutoSize = true;
			this.lblCurrentDoctor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblCurrentDoctor.Location = new System.Drawing.Point(15, 40);
			this.lblCurrentDoctor.Name = "lblCurrentDoctor";
			this.lblCurrentDoctor.Size = new System.Drawing.Size(67, 20);
			this.lblCurrentDoctor.TabIndex = 1;
			this.lblCurrentDoctor.Text = "Doctor:";
			// 
			// lblCurrentTitle
			// 
			this.lblCurrentTitle.AutoSize = true;
			this.lblCurrentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblCurrentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblCurrentTitle.Location = new System.Drawing.Point(15, 10);
			this.lblCurrentTitle.Name = "lblCurrentTitle";
			this.lblCurrentTitle.Size = new System.Drawing.Size(240, 23);
			this.lblCurrentTitle.TabIndex = 0;
			this.lblCurrentTitle.Text = "── CURRENT ASSIGNMENT ──";
			// 
			// lblNoResults
			// 
			this.lblNoResults.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNoResults.AutoSize = true;
			this.lblNoResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
			this.lblNoResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
			this.lblNoResults.Location = new System.Drawing.Point(350, 200);
			this.lblNoResults.Name = "lblNoResults";
			this.lblNoResults.Size = new System.Drawing.Size(355, 28);
			this.lblNoResults.TabIndex = 0;
			this.lblNoResults.Text = "Select an active admission to begin.";
			// 
			// toolbarPanel
			// 
			this.toolbarPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.toolbarPanel.BackColor = System.Drawing.Color.White;
			this.toolbarPanel.Controls.Add(this.btnFindAdmission);
			this.toolbarPanel.Controls.Add(this.txtSelectedAdmission);
			this.toolbarPanel.Controls.Add(this.lblAdmission);
			this.toolbarPanel.Location = new System.Drawing.Point(35, 110);
			this.toolbarPanel.Name = "toolbarPanel";
			this.toolbarPanel.Size = new System.Drawing.Size(1060, 70);
			this.toolbarPanel.TabIndex = 2;
			// 
			// btnFindAdmission
			// 
			this.btnFindAdmission.BackColor = System.Drawing.Color.White;
			this.btnFindAdmission.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFindAdmission.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnFindAdmission.FlatAppearance.BorderSize = 1;
			this.btnFindAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFindAdmission.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnFindAdmission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnFindAdmission.Location = new System.Drawing.Point(840, 17);
			this.btnFindAdmission.Name = "btnFindAdmission";
			this.btnFindAdmission.Size = new System.Drawing.Size(110, 34);
			this.btnFindAdmission.TabIndex = 2;
			this.btnFindAdmission.Text = "🔍  Find";
			this.btnFindAdmission.UseVisualStyleBackColor = false;
			this.btnFindAdmission.Click += new System.EventHandler(this.btnFindAdmission_Click);
			// 
			// txtSelectedAdmission
			// 
			this.txtSelectedAdmission.BackColor = System.Drawing.Color.White;
			this.txtSelectedAdmission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSelectedAdmission.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtSelectedAdmission.Location = new System.Drawing.Point(230, 19);
			this.txtSelectedAdmission.Name = "txtSelectedAdmission";
			this.txtSelectedAdmission.ReadOnly = true;
			this.txtSelectedAdmission.Size = new System.Drawing.Size(600, 30);
			this.txtSelectedAdmission.TabIndex = 1;
			// 
			// lblAdmission
			// 
			this.lblAdmission.AutoSize = true;
			this.lblAdmission.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblAdmission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblAdmission.Location = new System.Drawing.Point(20, 22);
			this.lblAdmission.Name = "lblAdmission";
			this.lblAdmission.Size = new System.Drawing.Size(165, 23);
			this.lblAdmission.TabIndex = 0;
			this.lblAdmission.Text = "Active Admission *";
			// 
			// lblSubtitle
			// 
			this.lblSubtitle.AutoSize = true;
			this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			this.lblSubtitle.Location = new System.Drawing.Point(38, 68);
			this.lblSubtitle.Name = "lblSubtitle";
			this.lblSubtitle.Size = new System.Drawing.Size(413, 23);
			this.lblSubtitle.TabIndex = 1;
			this.lblSubtitle.Text = "Update the attending staff for an admitted patient";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
			this.lblTitle.Location = new System.Drawing.Point(35, 25);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(376, 41);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Doctor / Nurse Assignment";
			// 
			// DoctorNurseAssignmentForm
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
			this.Name = "DoctorNurseAssignmentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Doctor / Nurse Assignment";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.DoctorNurseAssignmentForm_Load);
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.sidebarPanel.ResumeLayout(false);
			this.sidebarPanel.PerformLayout();
			this.contentPanel.ResumeLayout(false);
			this.contentPanel.PerformLayout();
			this.cardPanel.ResumeLayout(false);
			this.cardPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
			this.panelUpdate.ResumeLayout(false);
			this.panelUpdate.PerformLayout();
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
		private System.Windows.Forms.Panel contentPanel;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblSubtitle;
		private System.Windows.Forms.Panel toolbarPanel;
		private System.Windows.Forms.Label lblAdmission;
		private System.Windows.Forms.TextBox txtSelectedAdmission;
		private System.Windows.Forms.Button btnFindAdmission;
		private System.Windows.Forms.Panel cardPanel;
		private System.Windows.Forms.Label lblNoResults;
		private System.Windows.Forms.Panel panelUpdate;
		private System.Windows.Forms.Label lblCurrentTitle;
		private System.Windows.Forms.Label lblCurrentDoctor;
		private System.Windows.Forms.Label lblCurrentDoctorValue;
		private System.Windows.Forms.Label lblCurrentNurse;
		private System.Windows.Forms.Label lblCurrentNurseValue;
		private System.Windows.Forms.Label lblNewDoctor;
		private System.Windows.Forms.TextBox txtNewDoctor;
		private System.Windows.Forms.Label lblNewNurse;
		private System.Windows.Forms.TextBox txtNewNurse;
		private System.Windows.Forms.Label lblReason;
		private System.Windows.Forms.TextBox txtReason;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label lblHistoryTitle;
		private System.Windows.Forms.DataGridView dgvHistory;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStaffName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
	}
}