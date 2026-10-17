namespace UI
{
	partial class BillingForm
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
			if (disposing && (components != null)) components.Dispose();
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
			this.panelPayment = new System.Windows.Forms.Panel();
			this.btnFinalize = new System.Windows.Forms.Button();
			this.btnSaveDraft = new System.Windows.Forms.Button();
			this.lblChangeValue = new System.Windows.Forms.Label();
			this.lblChange = new System.Windows.Forms.Label();
			this.txtAmountPaid = new System.Windows.Forms.TextBox();
			this.lblAmountPaid = new System.Windows.Forms.Label();
			this.lblPaymentTitle = new System.Windows.Forms.Label();
			this.panelBreakdown = new System.Windows.Forms.Panel();
			this.lblDiscountDisplay = new System.Windows.Forms.Label();
			this.cmbDiscountReason = new System.Windows.Forms.ComboBox();
			this.lblDiscountReason = new System.Windows.Forms.Label();
			this.txtDiscountValue = new System.Windows.Forms.TextBox();
			this.cmbDiscountType = new System.Windows.Forms.ComboBox();
			this.lblDiscountType = new System.Windows.Forms.Label();
			this.lblTotalDue = new System.Windows.Forms.Label();
			this.lblTotalDueTitle = new System.Windows.Forms.Label();
			this.lblTreatmentCharges = new System.Windows.Forms.Label();
			this.lblTreatmentTitle = new System.Windows.Forms.Label();
			this.lblRoomCharges = new System.Windows.Forms.Label();
			this.lblRoomTitle = new System.Windows.Forms.Label();
			this.lblBreakdownTitle = new System.Windows.Forms.Label();
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
			this.panelPayment.SuspendLayout();
			this.panelBreakdown.SuspendLayout();
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
			this.btnNavBilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnNavBilling.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavBilling.FlatAppearance.BorderSize = 0;
			this.btnNavBilling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnNavBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavBilling.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnNavBilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
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
			this.cardPanel.BackColor = System.Drawing.Color.White;
			this.cardPanel.Controls.Add(this.panelPayment);
			this.cardPanel.Controls.Add(this.panelBreakdown);
			this.cardPanel.Controls.Add(this.lblNoResults);
			this.cardPanel.Location = new System.Drawing.Point(35, 190);
			this.cardPanel.Name = "cardPanel";
			this.cardPanel.Size = new System.Drawing.Size(1060, 480);
			this.cardPanel.TabIndex = 3;
			// 
			// panelPayment
			// 
			this.panelPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.panelPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelPayment.Controls.Add(this.btnFinalize);
			this.panelPayment.Controls.Add(this.btnSaveDraft);
			this.panelPayment.Controls.Add(this.lblChangeValue);
			this.panelPayment.Controls.Add(this.lblChange);
			this.panelPayment.Controls.Add(this.txtAmountPaid);
			this.panelPayment.Controls.Add(this.lblAmountPaid);
			this.panelPayment.Controls.Add(this.lblPaymentTitle);
			this.panelPayment.Location = new System.Drawing.Point(20, 260);
			this.panelPayment.Name = "panelPayment";
			this.panelPayment.Size = new System.Drawing.Size(1020, 150);
			this.panelPayment.TabIndex = 2;
			this.panelPayment.Visible = false;
			// 
			// btnFinalize
			// 
			this.btnFinalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnFinalize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFinalize.FlatAppearance.BorderSize = 0;
			this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFinalize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnFinalize.ForeColor = System.Drawing.Color.White;
			this.btnFinalize.Location = new System.Drawing.Point(190, 90);
			this.btnFinalize.Name = "btnFinalize";
			this.btnFinalize.Size = new System.Drawing.Size(180, 40);
			this.btnFinalize.TabIndex = 6;
			this.btnFinalize.Text = "Finalize Bill";
			this.btnFinalize.UseVisualStyleBackColor = false;
			this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
			// 
			// btnSaveDraft
			// 
			this.btnSaveDraft.BackColor = System.Drawing.Color.White;
			this.btnSaveDraft.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveDraft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnSaveDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveDraft.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnSaveDraft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnSaveDraft.Location = new System.Drawing.Point(20, 90);
			this.btnSaveDraft.Name = "btnSaveDraft";
			this.btnSaveDraft.Size = new System.Drawing.Size(150, 40);
			this.btnSaveDraft.TabIndex = 5;
			this.btnSaveDraft.Text = "Save Draft";
			this.btnSaveDraft.UseVisualStyleBackColor = false;
			this.btnSaveDraft.Click += new System.EventHandler(this.btnSaveDraft_Click);
			// 
			// lblChangeValue
			// 
			this.lblChangeValue.AutoSize = true;
			this.lblChangeValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblChangeValue.Location = new System.Drawing.Point(490, 43);
			this.lblChangeValue.Name = "lblChangeValue";
			this.lblChangeValue.Size = new System.Drawing.Size(56, 23);
			this.lblChangeValue.TabIndex = 4;
			this.lblChangeValue.Text = "₱0.00";
			// 
			// lblChange
			// 
			this.lblChange.AutoSize = true;
			this.lblChange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblChange.Location = new System.Drawing.Point(420, 45);
			this.lblChange.Name = "lblChange";
			this.lblChange.Size = new System.Drawing.Size(65, 20);
			this.lblChange.TabIndex = 3;
			this.lblChange.Text = "Change:";
			// 
			// txtAmountPaid
			// 
			this.txtAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAmountPaid.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtAmountPaid.Location = new System.Drawing.Point(250, 42);
			this.txtAmountPaid.Name = "txtAmountPaid";
			this.txtAmountPaid.Size = new System.Drawing.Size(150, 30);
			this.txtAmountPaid.TabIndex = 2;
			this.txtAmountPaid.TextChanged += new System.EventHandler(this.txtAmountPaid_TextChanged);
			// 
			// lblAmountPaid
			// 
			this.lblAmountPaid.AutoSize = true;
			this.lblAmountPaid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblAmountPaid.Location = new System.Drawing.Point(20, 45);
			this.lblAmountPaid.Name = "lblAmountPaid";
			this.lblAmountPaid.Size = new System.Drawing.Size(214, 20);
			this.lblAmountPaid.TabIndex = 1;
			this.lblAmountPaid.Text = "Payment Amount Received *:";
			// 
			// lblPaymentTitle
			// 
			this.lblPaymentTitle.AutoSize = true;
			this.lblPaymentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblPaymentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblPaymentTitle.Location = new System.Drawing.Point(20, 10);
			this.lblPaymentTitle.Name = "lblPaymentTitle";
			this.lblPaymentTitle.Size = new System.Drawing.Size(138, 23);
			this.lblPaymentTitle.TabIndex = 0;
			this.lblPaymentTitle.Text = "── PAYMENT ──";
			// 
			// panelBreakdown
			// 
			this.panelBreakdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.panelBreakdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBreakdown.Controls.Add(this.lblDiscountDisplay);
			this.panelBreakdown.Controls.Add(this.cmbDiscountReason);
			this.panelBreakdown.Controls.Add(this.lblDiscountReason);
			this.panelBreakdown.Controls.Add(this.txtDiscountValue);
			this.panelBreakdown.Controls.Add(this.cmbDiscountType);
			this.panelBreakdown.Controls.Add(this.lblDiscountType);
			this.panelBreakdown.Controls.Add(this.lblTotalDue);
			this.panelBreakdown.Controls.Add(this.lblTotalDueTitle);
			this.panelBreakdown.Controls.Add(this.lblTreatmentCharges);
			this.panelBreakdown.Controls.Add(this.lblTreatmentTitle);
			this.panelBreakdown.Controls.Add(this.lblRoomCharges);
			this.panelBreakdown.Controls.Add(this.lblRoomTitle);
			this.panelBreakdown.Controls.Add(this.lblBreakdownTitle);
			this.panelBreakdown.Location = new System.Drawing.Point(20, 20);
			this.panelBreakdown.Name = "panelBreakdown";
			this.panelBreakdown.Size = new System.Drawing.Size(1020, 220);
			this.panelBreakdown.TabIndex = 1;
			this.panelBreakdown.Visible = false;
			// 
			// lblDiscountDisplay
			// 
			this.lblDiscountDisplay.AutoSize = true;
			this.lblDiscountDisplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblDiscountDisplay.ForeColor = System.Drawing.Color.Gray;
			this.lblDiscountDisplay.Location = new System.Drawing.Point(20, 115);
			this.lblDiscountDisplay.Name = "lblDiscountDisplay";
			this.lblDiscountDisplay.Size = new System.Drawing.Size(178, 20);
			this.lblDiscountDisplay.TabIndex = 10;
			this.lblDiscountDisplay.Text = "Discount Applied: ₱0.00";
			this.lblDiscountDisplay.Visible = false;
			// 
			// cmbDiscountReason
			// 
			this.cmbDiscountReason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbDiscountReason.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbDiscountReason.FormattingEnabled = true;
			this.cmbDiscountReason.Items.AddRange(new object[] {
            "PhilHealth",
            "Senior Citizen",
            "PWD",
            "HMO",
            "Employee",
            "Other"});
			this.cmbDiscountReason.Location = new System.Drawing.Point(450, 112);
			this.cmbDiscountReason.Name = "cmbDiscountReason";
			this.cmbDiscountReason.Size = new System.Drawing.Size(180, 31);
			this.cmbDiscountReason.TabIndex = 9;
			// 
			// lblDiscountReason
			// 
			this.lblDiscountReason.AutoSize = true;
			this.lblDiscountReason.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblDiscountReason.Location = new System.Drawing.Point(390, 115);
			this.lblDiscountReason.Name = "lblDiscountReason";
			this.lblDiscountReason.Size = new System.Drawing.Size(64, 20);
			this.lblDiscountReason.TabIndex = 8;
			this.lblDiscountReason.Text = "Reason:";
			// 
			// txtDiscountValue
			// 
			this.txtDiscountValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDiscountValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtDiscountValue.Location = new System.Drawing.Point(290, 112);
			this.txtDiscountValue.Name = "txtDiscountValue";
			this.txtDiscountValue.Size = new System.Drawing.Size(80, 30);
			this.txtDiscountValue.TabIndex = 7;
			this.txtDiscountValue.TextChanged += new System.EventHandler(this.DiscountChanged);
			// 
			// cmbDiscountType
			// 
			this.cmbDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDiscountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbDiscountType.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbDiscountType.FormattingEnabled = true;
			this.cmbDiscountType.Items.AddRange(new object[] {
            "Percentage",
            "Amount"});
			this.cmbDiscountType.Location = new System.Drawing.Point(150, 112);
			this.cmbDiscountType.Name = "cmbDiscountType";
			this.cmbDiscountType.Size = new System.Drawing.Size(120, 31);
			this.cmbDiscountType.TabIndex = 6;
			this.cmbDiscountType.SelectedIndexChanged += new System.EventHandler(this.DiscountChanged);
			// 
			// lblDiscountType
			// 
			this.lblDiscountType.AutoSize = true;
			this.lblDiscountType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblDiscountType.Location = new System.Drawing.Point(20, 115);
			this.lblDiscountType.Name = "lblDiscountType";
			this.lblDiscountType.Size = new System.Drawing.Size(112, 20);
			this.lblDiscountType.TabIndex = 5;
			this.lblDiscountType.Text = "Discount Type:";
			// 
			// lblTotalDue
			// 
			this.lblTotalDue.AutoSize = true;
			this.lblTotalDue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.lblTotalDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.lblTotalDue.Location = new System.Drawing.Point(250, 158);
			this.lblTotalDue.Name = "lblTotalDue";
			this.lblTotalDue.Size = new System.Drawing.Size(78, 32);
			this.lblTotalDue.TabIndex = 12;
			this.lblTotalDue.Text = "₱0.00";
			// 
			// lblTotalDueTitle
			// 
			this.lblTotalDueTitle.AutoSize = true;
			this.lblTotalDueTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblTotalDueTitle.Location = new System.Drawing.Point(20, 160);
			this.lblTotalDueTitle.Name = "lblTotalDueTitle";
			this.lblTotalDueTitle.Size = new System.Drawing.Size(123, 28);
			this.lblTotalDueTitle.TabIndex = 11;
			this.lblTotalDueTitle.Text = "TOTAL DUE:";
			// 
			// lblTreatmentCharges
			// 
			this.lblTreatmentCharges.AutoSize = true;
			this.lblTreatmentCharges.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblTreatmentCharges.Location = new System.Drawing.Point(250, 75);
			this.lblTreatmentCharges.Name = "lblTreatmentCharges";
			this.lblTreatmentCharges.Size = new System.Drawing.Size(50, 20);
			this.lblTreatmentCharges.TabIndex = 4;
			this.lblTreatmentCharges.Text = "₱0.00";
			// 
			// lblTreatmentTitle
			// 
			this.lblTreatmentTitle.AutoSize = true;
			this.lblTreatmentTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.lblTreatmentTitle.Location = new System.Drawing.Point(20, 75);
			this.lblTreatmentTitle.Name = "lblTreatmentTitle";
			this.lblTreatmentTitle.Size = new System.Drawing.Size(136, 20);
			this.lblTreatmentTitle.TabIndex = 3;
			this.lblTreatmentTitle.Text = "Treatment Charges:";
			// 
			// lblRoomCharges
			// 
			this.lblRoomCharges.AutoSize = true;
			this.lblRoomCharges.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblRoomCharges.Location = new System.Drawing.Point(250, 45);
			this.lblRoomCharges.Name = "lblRoomCharges";
			this.lblRoomCharges.Size = new System.Drawing.Size(50, 20);
			this.lblRoomCharges.TabIndex = 2;
			this.lblRoomCharges.Text = "₱0.00";
			// 
			// lblRoomTitle
			// 
			this.lblRoomTitle.AutoSize = true;
			this.lblRoomTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.lblRoomTitle.Location = new System.Drawing.Point(20, 45);
			this.lblRoomTitle.Name = "lblRoomTitle";
			this.lblRoomTitle.Size = new System.Drawing.Size(109, 20);
			this.lblRoomTitle.TabIndex = 1;
			this.lblRoomTitle.Text = "Room Charges:";
			// 
			// lblBreakdownTitle
			// 
			this.lblBreakdownTitle.AutoSize = true;
			this.lblBreakdownTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblBreakdownTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblBreakdownTitle.Location = new System.Drawing.Point(20, 10);
			this.lblBreakdownTitle.Name = "lblBreakdownTitle";
			this.lblBreakdownTitle.Size = new System.Drawing.Size(209, 23);
			this.lblBreakdownTitle.TabIndex = 0;
			this.lblBreakdownTitle.Text = "── BILL BREAKDOWN ──";
			// 
			// lblNoResults
			// 
			this.lblNoResults.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNoResults.AutoSize = true;
			this.lblNoResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
			this.lblNoResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
			this.lblNoResults.Location = new System.Drawing.Point(350, 200);
			this.lblNoResults.Name = "lblNoResults";
			this.lblNoResults.Size = new System.Drawing.Size(320, 28);
			this.lblNoResults.TabIndex = 0;
			this.lblNoResults.Text = "Select an active admission to begin.";
			// 
			// toolbarPanel
			// 
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
			this.lblAdmission.Size = new System.Drawing.Size(161, 23);
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
			this.lblSubtitle.Size = new System.Drawing.Size(330, 23);
			this.lblSubtitle.TabIndex = 1;
			this.lblSubtitle.Text = "Compute and process the final patient bill";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
			this.lblTitle.Location = new System.Drawing.Point(35, 25);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(110, 41);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Billing";
			// 
			// BillingForm
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
			this.Name = "BillingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Billing";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.BillingForm_Load);
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.sidebarPanel.ResumeLayout(false);
			this.sidebarPanel.PerformLayout();
			this.contentPanel.ResumeLayout(false);
			this.contentPanel.PerformLayout();
			this.cardPanel.ResumeLayout(false);
			this.cardPanel.PerformLayout();
			this.panelPayment.ResumeLayout(false);
			this.panelPayment.PerformLayout();
			this.panelBreakdown.ResumeLayout(false);
			this.panelBreakdown.PerformLayout();
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
		private System.Windows.Forms.Panel panelBreakdown;
		private System.Windows.Forms.Label lblBreakdownTitle;
		private System.Windows.Forms.Label lblRoomTitle;
		private System.Windows.Forms.Label lblRoomCharges;
		private System.Windows.Forms.Label lblTreatmentTitle;
		private System.Windows.Forms.Label lblTreatmentCharges;
		private System.Windows.Forms.Label lblDiscountType;
		private System.Windows.Forms.ComboBox cmbDiscountType;
		private System.Windows.Forms.TextBox txtDiscountValue;
		private System.Windows.Forms.Label lblDiscountReason;
		private System.Windows.Forms.ComboBox cmbDiscountReason;
		private System.Windows.Forms.Label lblDiscountDisplay;
		private System.Windows.Forms.Label lblTotalDueTitle;
		private System.Windows.Forms.Label lblTotalDue;
		private System.Windows.Forms.Panel panelPayment;
		private System.Windows.Forms.Label lblPaymentTitle;
		private System.Windows.Forms.Label lblAmountPaid;
		private System.Windows.Forms.TextBox txtAmountPaid;
		private System.Windows.Forms.Label lblChange;
		private System.Windows.Forms.Label lblChangeValue;
		private System.Windows.Forms.Button btnSaveDraft;
		private System.Windows.Forms.Button btnFinalize;
	}
}