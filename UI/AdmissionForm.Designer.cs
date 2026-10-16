namespace UI
{
	partial class AdmissionForm
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
			this.btnNavAdmissionLog = new System.Windows.Forms.Button();
			this.btnNavAdmission = new System.Windows.Forms.Button();
			this.btnNavRoomSearch = new System.Windows.Forms.Button();
			this.btnNavPatientSearch = new System.Windows.Forms.Button();
			this.btnNavPatient = new System.Windows.Forms.Button();
			this.btnNavRoom = new System.Windows.Forms.Button();
			this.lblSidebarHeader = new System.Windows.Forms.Label();
			this.sidebarBorder = new System.Windows.Forms.Panel();
			this.contentPanel = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblSubtitle = new System.Windows.Forms.Label();
			this.cardPanel = new System.Windows.Forms.Panel();
			this.lblPatientLabel = new System.Windows.Forms.Label();
			this.txtSelectedPatient = new System.Windows.Forms.TextBox();
			this.btnFindPatient = new System.Windows.Forms.Button();
			this.lblRoomLabel = new System.Windows.Forms.Label();
			this.txtSelectedRoom = new System.Windows.Forms.TextBox();
			this.btnFindRoom = new System.Windows.Forms.Button();
			this.lblDateLabel = new System.Windows.Forms.Label();
			this.txtAdmissionDate = new System.Windows.Forms.TextBox();
			this.lblDiagnosisLabel = new System.Windows.Forms.Label();
			this.txtDiagnosis = new System.Windows.Forms.TextBox();
			this.btnConfirmAdmission = new System.Windows.Forms.Button();
			this.lblHelperNote = new System.Windows.Forms.Label();
			this.panelAdminOverride = new System.Windows.Forms.Panel();
			this.lblAdminOverrideTitle = new System.Windows.Forms.Label();
			this.lblExistingAdmission = new System.Windows.Forms.Label();
			this.cmbExistingAdmission = new System.Windows.Forms.ComboBox();
			this.btnEditAdmission = new System.Windows.Forms.Button();
			this.headerPanel.SuspendLayout();
			this.sidebarPanel.SuspendLayout();
			this.contentPanel.SuspendLayout();
			this.cardPanel.SuspendLayout();
			this.panelAdminOverride.SuspendLayout();
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
			this.btnNavSummary.Location = new System.Drawing.Point(12, 444);
			this.btnNavSummary.Name = "btnNavSummary";
			this.btnNavSummary.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavSummary.Size = new System.Drawing.Size(216, 42);
			this.btnNavSummary.TabIndex = 10;
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
			this.btnNavDischarge.Location = new System.Drawing.Point(12, 400);
			this.btnNavDischarge.Name = "btnNavDischarge";
			this.btnNavDischarge.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavDischarge.Size = new System.Drawing.Size(216, 42);
			this.btnNavDischarge.TabIndex = 9;
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
			this.btnNavBilling.Location = new System.Drawing.Point(12, 356);
			this.btnNavBilling.Name = "btnNavBilling";
			this.btnNavBilling.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavBilling.Size = new System.Drawing.Size(216, 42);
			this.btnNavBilling.TabIndex = 8;
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
			this.btnNavAdmission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnNavAdmission.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavAdmission.FlatAppearance.BorderSize = 0;
			this.btnNavAdmission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnNavAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavAdmission.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnNavAdmission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
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
			this.lblTitle.Size = new System.Drawing.Size(168, 41);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Admission";
			// 
			// lblSubtitle
			// 
			this.lblSubtitle.AutoSize = true;
			this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			this.lblSubtitle.Location = new System.Drawing.Point(38, 68);
			this.lblSubtitle.Name = "lblSubtitle";
			this.lblSubtitle.Size = new System.Drawing.Size(380, 23);
			this.lblSubtitle.TabIndex = 1;
			this.lblSubtitle.Text = "Admit a patient to an available room";
			// 
			// cardPanel
			// 
			this.cardPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cardPanel.BackColor = System.Drawing.Color.White;
			this.cardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cardPanel.Controls.Add(this.panelAdminOverride);
			this.cardPanel.Controls.Add(this.lblHelperNote);
			this.cardPanel.Controls.Add(this.btnConfirmAdmission);
			this.cardPanel.Controls.Add(this.txtDiagnosis);
			this.cardPanel.Controls.Add(this.lblDiagnosisLabel);
			this.cardPanel.Controls.Add(this.txtAdmissionDate);
			this.cardPanel.Controls.Add(this.lblDateLabel);
			this.cardPanel.Controls.Add(this.btnFindRoom);
			this.cardPanel.Controls.Add(this.txtSelectedRoom);
			this.cardPanel.Controls.Add(this.lblRoomLabel);
			this.cardPanel.Controls.Add(this.btnFindPatient);
			this.cardPanel.Controls.Add(this.txtSelectedPatient);
			this.cardPanel.Controls.Add(this.lblPatientLabel);
			this.cardPanel.Location = new System.Drawing.Point(212, 95);
			this.cardPanel.Name = "cardPanel";
			this.cardPanel.Size = new System.Drawing.Size(700, 575);
			this.cardPanel.TabIndex = 2;
			// 
			// lblPatientLabel
			// 
			this.lblPatientLabel.AutoSize = true;
			this.lblPatientLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblPatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblPatientLabel.Location = new System.Drawing.Point(30, 18);
			this.lblPatientLabel.Name = "lblPatientLabel";
			this.lblPatientLabel.Size = new System.Drawing.Size(220, 23);
			this.lblPatientLabel.TabIndex = 0;
			this.lblPatientLabel.Text = "Patient (search/select) *";
			// 
			// txtSelectedPatient
			// 
			this.txtSelectedPatient.BackColor = System.Drawing.Color.White;
			this.txtSelectedPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSelectedPatient.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtSelectedPatient.Location = new System.Drawing.Point(30, 43);
			this.txtSelectedPatient.Name = "txtSelectedPatient";
			this.txtSelectedPatient.ReadOnly = true;
			this.txtSelectedPatient.Size = new System.Drawing.Size(520, 30);
			this.txtSelectedPatient.TabIndex = 1;
			// 
			// btnFindPatient
			// 
			this.btnFindPatient.BackColor = System.Drawing.Color.White;
			this.btnFindPatient.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFindPatient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnFindPatient.FlatAppearance.BorderSize = 1;
			this.btnFindPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFindPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnFindPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnFindPatient.Location = new System.Drawing.Point(560, 41);
			this.btnFindPatient.Name = "btnFindPatient";
			this.btnFindPatient.Size = new System.Drawing.Size(110, 34);
			this.btnFindPatient.TabIndex = 2;
			this.btnFindPatient.Text = "🔍  Find";
			this.btnFindPatient.UseVisualStyleBackColor = false;
			this.btnFindPatient.Click += new System.EventHandler(this.btnFindPatient_Click);
			// 
			// lblRoomLabel
			// 
			this.lblRoomLabel.AutoSize = true;
			this.lblRoomLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblRoomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblRoomLabel.Location = new System.Drawing.Point(30, 84);
			this.lblRoomLabel.Name = "lblRoomLabel";
			this.lblRoomLabel.Size = new System.Drawing.Size(210, 23);
			this.lblRoomLabel.TabIndex = 3;
			this.lblRoomLabel.Text = "Room (available only) *";
			// 
			// txtSelectedRoom
			// 
			this.txtSelectedRoom.BackColor = System.Drawing.Color.White;
			this.txtSelectedRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSelectedRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtSelectedRoom.Location = new System.Drawing.Point(30, 109);
			this.txtSelectedRoom.Name = "txtSelectedRoom";
			this.txtSelectedRoom.ReadOnly = true;
			this.txtSelectedRoom.Size = new System.Drawing.Size(520, 30);
			this.txtSelectedRoom.TabIndex = 4;
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
			this.btnFindRoom.Location = new System.Drawing.Point(560, 107);
			this.btnFindRoom.Name = "btnFindRoom";
			this.btnFindRoom.Size = new System.Drawing.Size(110, 34);
			this.btnFindRoom.TabIndex = 5;
			this.btnFindRoom.Text = "🔍  Find";
			this.btnFindRoom.UseVisualStyleBackColor = false;
			this.btnFindRoom.Click += new System.EventHandler(this.btnFindRoom_Click);
			// 
			// lblDateLabel
			// 
			this.lblDateLabel.AutoSize = true;
			this.lblDateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblDateLabel.Location = new System.Drawing.Point(30, 150);
			this.lblDateLabel.Name = "lblDateLabel";
			this.lblDateLabel.Size = new System.Drawing.Size(190, 23);
			this.lblDateLabel.TabIndex = 6;
			this.lblDateLabel.Text = "Admission Date/Time";
			// 
			// txtAdmissionDate
			// 
			this.txtAdmissionDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.txtAdmissionDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAdmissionDate.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtAdmissionDate.Location = new System.Drawing.Point(30, 175);
			this.txtAdmissionDate.Name = "txtAdmissionDate";
			this.txtAdmissionDate.ReadOnly = true;
			this.txtAdmissionDate.Size = new System.Drawing.Size(640, 30);
			this.txtAdmissionDate.TabIndex = 7;
			// 
			// lblDiagnosisLabel
			// 
			this.lblDiagnosisLabel.AutoSize = true;
			this.lblDiagnosisLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblDiagnosisLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblDiagnosisLabel.Location = new System.Drawing.Point(30, 216);
			this.lblDiagnosisLabel.Name = "lblDiagnosisLabel";
			this.lblDiagnosisLabel.Size = new System.Drawing.Size(290, 23);
			this.lblDiagnosisLabel.TabIndex = 8;
			this.lblDiagnosisLabel.Text = "Reason for Admission / Diagnosis *";
			// 
			// txtDiagnosis
			// 
			this.txtDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDiagnosis.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtDiagnosis.Location = new System.Drawing.Point(30, 241);
			this.txtDiagnosis.Multiline = true;
			this.txtDiagnosis.Name = "txtDiagnosis";
			this.txtDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDiagnosis.Size = new System.Drawing.Size(640, 60);
			this.txtDiagnosis.TabIndex = 9;
			// 
			// btnConfirmAdmission
			// 
			this.btnConfirmAdmission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnConfirmAdmission.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConfirmAdmission.FlatAppearance.BorderSize = 0;
			this.btnConfirmAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfirmAdmission.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.btnConfirmAdmission.ForeColor = System.Drawing.Color.White;
			this.btnConfirmAdmission.Location = new System.Drawing.Point(30, 315);
			this.btnConfirmAdmission.Name = "btnConfirmAdmission";
			this.btnConfirmAdmission.Size = new System.Drawing.Size(220, 40);
			this.btnConfirmAdmission.TabIndex = 10;
			this.btnConfirmAdmission.Text = "Confirm Admission";
			this.btnConfirmAdmission.UseVisualStyleBackColor = false;
			this.btnConfirmAdmission.Click += new System.EventHandler(this.btnConfirmAdmission_Click);
			// 
			// lblHelperNote
			// 
			this.lblHelperNote.AutoSize = true;
			this.lblHelperNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
			this.lblHelperNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			this.lblHelperNote.Location = new System.Drawing.Point(30, 363);
			this.lblHelperNote.Name = "lblHelperNote";
			this.lblHelperNote.Size = new System.Drawing.Size(550, 20);
			this.lblHelperNote.TabIndex = 11;
			this.lblHelperNote.Text = "On confirm: room will be set to Occupied and the billing rate will be locked in.";
			// 
			// panelAdminOverride
			// 
			this.panelAdminOverride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.panelAdminOverride.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelAdminOverride.Controls.Add(this.btnEditAdmission);
			this.panelAdminOverride.Controls.Add(this.cmbExistingAdmission);
			this.panelAdminOverride.Controls.Add(this.lblExistingAdmission);
			this.panelAdminOverride.Controls.Add(this.lblAdminOverrideTitle);
			this.panelAdminOverride.Location = new System.Drawing.Point(30, 395);
			this.panelAdminOverride.Name = "panelAdminOverride";
			this.panelAdminOverride.Size = new System.Drawing.Size(640, 160);
			this.panelAdminOverride.TabIndex = 12;
			// 
			// lblAdminOverrideTitle
			// 
			this.lblAdminOverrideTitle.AutoSize = true;
			this.lblAdminOverrideTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblAdminOverrideTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblAdminOverrideTitle.Location = new System.Drawing.Point(15, 12);
			this.lblAdminOverrideTitle.Name = "lblAdminOverrideTitle";
			this.lblAdminOverrideTitle.Size = new System.Drawing.Size(220, 23);
			this.lblAdminOverrideTitle.TabIndex = 0;
			this.lblAdminOverrideTitle.Text = "── ADMIN OVERRIDE ──";
			// 
			// lblExistingAdmission
			// 
			this.lblExistingAdmission.AutoSize = true;
			this.lblExistingAdmission.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblExistingAdmission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblExistingAdmission.Location = new System.Drawing.Point(15, 44);
			this.lblExistingAdmission.Name = "lblExistingAdmission";
			this.lblExistingAdmission.Size = new System.Drawing.Size(220, 23);
			this.lblExistingAdmission.TabIndex = 1;
			this.lblExistingAdmission.Text = "Existing Admission Record";
			// 
			// cmbExistingAdmission
			// 
			this.cmbExistingAdmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbExistingAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbExistingAdmission.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbExistingAdmission.FormattingEnabled = true;
			this.cmbExistingAdmission.Location = new System.Drawing.Point(15, 70);
			this.cmbExistingAdmission.Name = "cmbExistingAdmission";
			this.cmbExistingAdmission.Size = new System.Drawing.Size(610, 31);
			this.cmbExistingAdmission.TabIndex = 2;
			// 
			// btnEditAdmission
			// 
			this.btnEditAdmission.BackColor = System.Drawing.Color.White;
			this.btnEditAdmission.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditAdmission.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnEditAdmission.FlatAppearance.BorderSize = 1;
			this.btnEditAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditAdmission.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnEditAdmission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnEditAdmission.Location = new System.Drawing.Point(15, 110);
			this.btnEditAdmission.Name = "btnEditAdmission";
			this.btnEditAdmission.Size = new System.Drawing.Size(220, 36);
			this.btnEditAdmission.TabIndex = 3;
			this.btnEditAdmission.Text = "Edit Admission Record";
			this.btnEditAdmission.UseVisualStyleBackColor = false;
			this.btnEditAdmission.Click += new System.EventHandler(this.btnEditAdmission_Click);
			// 
			// AdmissionForm
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
			this.Name = "AdmissionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admission";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.AdmissionForm_Load);
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.sidebarPanel.ResumeLayout(false);
			this.sidebarPanel.PerformLayout();
			this.contentPanel.ResumeLayout(false);
			this.contentPanel.PerformLayout();
			this.cardPanel.ResumeLayout(false);
			this.cardPanel.PerformLayout();
			this.panelAdminOverride.ResumeLayout(false);
			this.panelAdminOverride.PerformLayout();
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
		private System.Windows.Forms.Button btnNavBilling;
		private System.Windows.Forms.Button btnNavDischarge;
		private System.Windows.Forms.Button btnNavSummary;
		private System.Windows.Forms.Panel sidebarBorder;
		private System.Windows.Forms.Panel contentPanel;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblSubtitle;
		private System.Windows.Forms.Panel cardPanel;
		private System.Windows.Forms.Label lblPatientLabel;
		private System.Windows.Forms.TextBox txtSelectedPatient;
		private System.Windows.Forms.Button btnFindPatient;
		private System.Windows.Forms.Label lblRoomLabel;
		private System.Windows.Forms.TextBox txtSelectedRoom;
		private System.Windows.Forms.Button btnFindRoom;
		private System.Windows.Forms.Label lblDateLabel;
		private System.Windows.Forms.TextBox txtAdmissionDate;
		private System.Windows.Forms.Label lblDiagnosisLabel;
		private System.Windows.Forms.TextBox txtDiagnosis;
		private System.Windows.Forms.Button btnConfirmAdmission;
		private System.Windows.Forms.Label lblHelperNote;
		private System.Windows.Forms.Panel panelAdminOverride;
		private System.Windows.Forms.Label lblAdminOverrideTitle;
		private System.Windows.Forms.Label lblExistingAdmission;
		private System.Windows.Forms.ComboBox cmbExistingAdmission;
		private System.Windows.Forms.Button btnEditAdmission;
	}
}