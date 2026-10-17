namespace UI
{
	partial class TreatmentBillingForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

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
			this.panelAdd = new System.Windows.Forms.Panel();
			this.lblAddTitle = new System.Windows.Forms.Label();
			this.txtServiceName = new System.Windows.Forms.TextBox();
			this.lblServiceName = new System.Windows.Forms.Label();
			this.numQuantity = new System.Windows.Forms.NumericUpDown();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.txtUnitCost = new System.Windows.Forms.TextBox();
			this.lblUnitCost = new System.Windows.Forms.Label();
			this.btnAddItem = new System.Windows.Forms.Button();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.dgvTreatments = new System.Windows.Forms.DataGridView();
			this.colService = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colUnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.panelAdd.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
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
			this.lblUserInfo.Location = new System.Drawing.Point(843, 23);
			this.lblUserInfo.Name = "lblUserInfo";
			this.lblUserInfo.Size = new System.Drawing.Size(271, 23);
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
			this.lblBrand.Text = "🏥  Hospital Admission System";
			// 
			// headerBorder
			// 
			this.headerBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
			this.headerBorder.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerBorder.Location = new System.Drawing.Point(0, 65);
			this.headerBorder.Name = "headerBorder";
			this.headerBorder.Size = new System.Drawing.Size(1366, 1);
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
			// 
			// btnNavSummary
			// 
			this.btnNavSummary.BackColor = System.Drawing.Color.White;
			this.btnNavSummary.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavSummary.FlatAppearance.BorderSize = 0;
			this.btnNavSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavSummary.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavSummary.Location = new System.Drawing.Point(12, 444);
			this.btnNavSummary.Name = "btnNavSummary";
			this.btnNavSummary.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavSummary.Size = new System.Drawing.Size(216, 42);
			this.btnNavSummary.Text = "Discharge Summary";
			this.btnNavSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnNavDischarge
			// 
			this.btnNavDischarge.BackColor = System.Drawing.Color.White;
			this.btnNavDischarge.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavDischarge.FlatAppearance.BorderSize = 0;
			this.btnNavDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavDischarge.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavDischarge.Location = new System.Drawing.Point(12, 400);
			this.btnNavDischarge.Name = "btnNavDischarge";
			this.btnNavDischarge.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavDischarge.Size = new System.Drawing.Size(216, 42);
			this.btnNavDischarge.Text = "Discharge";
			this.btnNavDischarge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnNavBilling
			// 
			this.btnNavBilling.BackColor = System.Drawing.Color.White;
			this.btnNavBilling.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavBilling.FlatAppearance.BorderSize = 0;
			this.btnNavBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavBilling.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavBilling.Location = new System.Drawing.Point(12, 356);
			this.btnNavBilling.Name = "btnNavBilling";
			this.btnNavBilling.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavBilling.Size = new System.Drawing.Size(216, 42);
			this.btnNavBilling.Text = "Billing";
			this.btnNavBilling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnNavTreatment
			// 
			this.btnNavTreatment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnNavTreatment.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavTreatment.FlatAppearance.BorderSize = 0;
			this.btnNavTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavTreatment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnNavTreatment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
			this.btnNavTreatment.Location = new System.Drawing.Point(12, 312);
			this.btnNavTreatment.Name = "btnNavTreatment";
			this.btnNavTreatment.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavTreatment.Size = new System.Drawing.Size(216, 42);
			this.btnNavTreatment.Text = "Treatment / Billing";
			this.btnNavTreatment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnNavAdmissionLog
			// 
			this.btnNavAdmissionLog.BackColor = System.Drawing.Color.White;
			this.btnNavAdmissionLog.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavAdmissionLog.FlatAppearance.BorderSize = 0;
			this.btnNavAdmissionLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavAdmissionLog.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavAdmissionLog.Location = new System.Drawing.Point(12, 268);
			this.btnNavAdmissionLog.Name = "btnNavAdmissionLog";
			this.btnNavAdmissionLog.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavAdmissionLog.Size = new System.Drawing.Size(216, 42);
			this.btnNavAdmissionLog.Text = "Admission Log";
			this.btnNavAdmissionLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnNavAdmission
			// 
			this.btnNavAdmission.BackColor = System.Drawing.Color.White;
			this.btnNavAdmission.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavAdmission.FlatAppearance.BorderSize = 0;
			this.btnNavAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavAdmission.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavAdmission.Location = new System.Drawing.Point(12, 224);
			this.btnNavAdmission.Name = "btnNavAdmission";
			this.btnNavAdmission.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavAdmission.Size = new System.Drawing.Size(216, 42);
			this.btnNavAdmission.Text = "Admission";
			this.btnNavAdmission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnNavRoomSearch
			// 
			this.btnNavRoomSearch.BackColor = System.Drawing.Color.White;
			this.btnNavRoomSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavRoomSearch.FlatAppearance.BorderSize = 0;
			this.btnNavRoomSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavRoomSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavRoomSearch.Location = new System.Drawing.Point(12, 180);
			this.btnNavRoomSearch.Name = "btnNavRoomSearch";
			this.btnNavRoomSearch.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavRoomSearch.Size = new System.Drawing.Size(216, 42);
			this.btnNavRoomSearch.Text = "Patient Room Search";
			this.btnNavRoomSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnNavPatientSearch
			// 
			this.btnNavPatientSearch.BackColor = System.Drawing.Color.White;
			this.btnNavPatientSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavPatientSearch.FlatAppearance.BorderSize = 0;
			this.btnNavPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavPatientSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavPatientSearch.Location = new System.Drawing.Point(12, 136);
			this.btnNavPatientSearch.Name = "btnNavPatientSearch";
			this.btnNavPatientSearch.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavPatientSearch.Size = new System.Drawing.Size(216, 42);
			this.btnNavPatientSearch.Text = "Patient Info Search";
			this.btnNavPatientSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnNavPatient
			// 
			this.btnNavPatient.BackColor = System.Drawing.Color.White;
			this.btnNavPatient.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavPatient.FlatAppearance.BorderSize = 0;
			this.btnNavPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavPatient.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavPatient.Location = new System.Drawing.Point(12, 92);
			this.btnNavPatient.Name = "btnNavPatient";
			this.btnNavPatient.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavPatient.Size = new System.Drawing.Size(216, 42);
			this.btnNavPatient.Text = "Patient Information";
			this.btnNavPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnNavRoom
			// 
			this.btnNavRoom.BackColor = System.Drawing.Color.White;
			this.btnNavRoom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNavRoom.FlatAppearance.BorderSize = 0;
			this.btnNavRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnNavRoom.Location = new System.Drawing.Point(12, 48);
			this.btnNavRoom.Name = "btnNavRoom";
			this.btnNavRoom.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnNavRoom.Size = new System.Drawing.Size(216, 42);
			this.btnNavRoom.Text = "Room Management";
			this.btnNavRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSidebarHeader
			// 
			this.lblSidebarHeader.AutoSize = true;
			this.lblSidebarHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblSidebarHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
			this.lblSidebarHeader.Location = new System.Drawing.Point(22, 18);
			this.lblSidebarHeader.Name = "lblSidebarHeader";
			this.lblSidebarHeader.Size = new System.Drawing.Size(80, 20);
			this.lblSidebarHeader.Text = "MODULES";
			// 
			// sidebarBorder
			// 
			this.sidebarBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
			this.sidebarBorder.Dock = System.Windows.Forms.DockStyle.Left;
			this.sidebarBorder.Location = new System.Drawing.Point(240, 66);
			this.sidebarBorder.Name = "sidebarBorder";
			this.sidebarBorder.Size = new System.Drawing.Size(1, 702);
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
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(35, 25);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(380, 41);
			this.lblTitle.Text = "Treatment / Billing Breakdown";
			// 
			// lblSubtitle
			// 
			this.lblSubtitle.AutoSize = true;
			this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblSubtitle.Location = new System.Drawing.Point(38, 68);
			this.lblSubtitle.Name = "lblSubtitle";
			this.lblSubtitle.Size = new System.Drawing.Size(300, 23);
			this.lblSubtitle.Text = "Record services provided to a patient";
			// 
			// toolbarPanel
			// 
			this.toolbarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.toolbarPanel.BackColor = System.Drawing.Color.White;
			this.toolbarPanel.Controls.Add(this.btnFindAdmission);
			this.toolbarPanel.Controls.Add(this.txtSelectedAdmission);
			this.toolbarPanel.Controls.Add(this.lblAdmission);
			this.toolbarPanel.Location = new System.Drawing.Point(35, 110);
			this.toolbarPanel.Name = "toolbarPanel";
			this.toolbarPanel.Size = new System.Drawing.Size(1060, 70);
			// 
			// lblAdmission
			// 
			this.lblAdmission.AutoSize = true;
			this.lblAdmission.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblAdmission.Location = new System.Drawing.Point(20, 22);
			this.lblAdmission.Name = "lblAdmission";
			this.lblAdmission.Size = new System.Drawing.Size(200, 23);
			this.lblAdmission.Text = "Admission ID / Patient *";
			// 
			// txtSelectedAdmission
			// 
			this.txtSelectedAdmission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSelectedAdmission.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtSelectedAdmission.Location = new System.Drawing.Point(230, 19);
			this.txtSelectedAdmission.Name = "txtSelectedAdmission";
			this.txtSelectedAdmission.ReadOnly = true;
			this.txtSelectedAdmission.Size = new System.Drawing.Size(600, 30);
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
			this.btnFindAdmission.Text = "🔍  Find";
			this.btnFindAdmission.UseVisualStyleBackColor = false;
			this.btnFindAdmission.Click += new System.EventHandler(this.btnFindAdmission_Click);
			// 
			// cardPanel
			// 
			this.cardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.cardPanel.BackColor = System.Drawing.Color.White;
			this.cardPanel.Controls.Add(this.panelAdd);
			this.cardPanel.Controls.Add(this.dgvTreatments);
			this.cardPanel.Controls.Add(this.lblNoResults);
			this.cardPanel.Location = new System.Drawing.Point(35, 190);
			this.cardPanel.Name = "cardPanel";
			this.cardPanel.Size = new System.Drawing.Size(1060, 480);
			// 
			// dgvTreatments
			// 
			this.dgvTreatments.AllowUserToAddRows = false;
			this.dgvTreatments.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.dgvTreatments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTreatments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTreatments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTreatments.BackgroundColor = System.Drawing.Color.White;
			this.dgvTreatments.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvTreatments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvTreatments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.dgvTreatments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvTreatments.ColumnHeadersHeight = 50;
			this.dgvTreatments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colService, this.colDate, this.colQty, this.colUnitCost, this.colTotalCost });
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.dgvTreatments.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvTreatments.EnableHeadersVisualStyles = false;
			this.dgvTreatments.Location = new System.Drawing.Point(0, 0);
			this.dgvTreatments.MultiSelect = false;
			this.dgvTreatments.Name = "dgvTreatments";
			this.dgvTreatments.ReadOnly = true;
			this.dgvTreatments.RowHeadersVisible = false;
			this.dgvTreatments.RowTemplate.Height = 45;
			this.dgvTreatments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTreatments.Size = new System.Drawing.Size(1060, 300);
			// 
			// colService
			// 
			this.colService.FillWeight = 35F;
			this.colService.HeaderText = "Service/Treatment";
			this.colService.Name = "colService";
			// 
			// colDate
			// 
			this.colDate.FillWeight = 20F;
			this.colDate.HeaderText = "Date";
			this.colDate.Name = "colDate";
			// 
			// colQty
			// 
			this.colQty.FillWeight = 10F;
			this.colQty.HeaderText = "Qty";
			this.colQty.Name = "colQty";
			// 
			// colUnitCost
			// 
			this.colUnitCost.FillWeight = 15F;
			this.colUnitCost.HeaderText = "Unit Cost";
			this.colUnitCost.Name = "colUnitCost";
			// 
			// colTotalCost
			// 
			this.colTotalCost.FillWeight = 20F;
			this.colTotalCost.HeaderText = "Total Cost";
			this.colTotalCost.Name = "colTotalCost";
			// 
			// lblNoResults
			// 
			this.lblNoResults.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNoResults.AutoSize = true;
			this.lblNoResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
			this.lblNoResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
			this.lblNoResults.Location = new System.Drawing.Point(350, 130);
			this.lblNoResults.Name = "lblNoResults";
			this.lblNoResults.Size = new System.Drawing.Size(340, 28);
			this.lblNoResults.Text = "Select an active admission to begin.";
			// 
			// panelAdd
			// 
			this.panelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.panelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.panelAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelAdd.Controls.Add(this.lblAddTitle);
			this.panelAdd.Controls.Add(this.txtServiceName);
			this.panelAdd.Controls.Add(this.lblServiceName);
			this.panelAdd.Controls.Add(this.numQuantity);
			this.panelAdd.Controls.Add(this.lblQuantity);
			this.panelAdd.Controls.Add(this.txtUnitCost);
			this.panelAdd.Controls.Add(this.lblUnitCost);
			this.panelAdd.Controls.Add(this.btnAddItem);
			this.panelAdd.Controls.Add(this.lblSubtotal);
			this.panelAdd.Location = new System.Drawing.Point(20, 315);
			this.panelAdd.Name = "panelAdd";
			this.panelAdd.Size = new System.Drawing.Size(1020, 145);
			// 
			// lblAddTitle
			// 
			this.lblAddTitle.AutoSize = true;
			this.lblAddTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblAddTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblAddTitle.Location = new System.Drawing.Point(20, 10);
			this.lblAddTitle.Name = "lblAddTitle";
			this.lblAddTitle.Size = new System.Drawing.Size(150, 23);
			this.lblAddTitle.Text = "── ADD TREATMENT ──";
			// 
			// lblServiceName
			// 
			this.lblServiceName.AutoSize = true;
			this.lblServiceName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblServiceName.Location = new System.Drawing.Point(20, 45);
			this.lblServiceName.Name = "lblServiceName";
			this.lblServiceName.Size = new System.Drawing.Size(120, 20);
			this.lblServiceName.Text = "Service Name *";
			// 
			// txtServiceName
			// 
			this.txtServiceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtServiceName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtServiceName.Location = new System.Drawing.Point(20, 68);
			this.txtServiceName.Name = "txtServiceName";
			this.txtServiceName.Size = new System.Drawing.Size(400, 30);
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblQuantity.Location = new System.Drawing.Point(440, 45);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(50, 20);
			this.lblQuantity.Text = "Qty *";
			// 
			// numQuantity
			// 
			this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.numQuantity.Location = new System.Drawing.Point(440, 68);
			this.numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			this.numQuantity.Name = "numQuantity";
			this.numQuantity.Size = new System.Drawing.Size(100, 30);
			this.numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// lblUnitCost
			// 
			this.lblUnitCost.AutoSize = true;
			this.lblUnitCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblUnitCost.Location = new System.Drawing.Point(560, 45);
			this.lblUnitCost.Name = "lblUnitCost";
			this.lblUnitCost.Size = new System.Drawing.Size(85, 20);
			this.lblUnitCost.Text = "Unit Cost *";
			// 
			// txtUnitCost
			// 
			this.txtUnitCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUnitCost.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtUnitCost.Location = new System.Drawing.Point(560, 68);
			this.txtUnitCost.Name = "txtUnitCost";
			this.txtUnitCost.Size = new System.Drawing.Size(150, 30);
			// 
			// btnAddItem
			// 
			this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddItem.FlatAppearance.BorderSize = 0;
			this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnAddItem.ForeColor = System.Drawing.Color.White;
			this.btnAddItem.Location = new System.Drawing.Point(740, 68);
			this.btnAddItem.Name = "btnAddItem";
			this.btnAddItem.Size = new System.Drawing.Size(130, 30);
			this.btnAddItem.Text = "+ Add Item";
			this.btnAddItem.UseVisualStyleBackColor = false;
			this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
			this.lblSubtotal.Location = new System.Drawing.Point(20, 110);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(180, 28);
			this.lblSubtotal.Text = "Subtotal: ₱0.00";
			// 
			// TreatmentBillingForm
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
			this.Name = "TreatmentBillingForm";
			this.Text = "Treatment / Billing Breakdown";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.TreatmentBillingForm_Load);
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.sidebarPanel.ResumeLayout(false);
			this.sidebarPanel.PerformLayout();
			this.contentPanel.ResumeLayout(false);
			this.contentPanel.PerformLayout();
			this.cardPanel.ResumeLayout(false);
			this.cardPanel.PerformLayout();
			this.panelAdd.ResumeLayout(false);
			this.panelAdd.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
			this.toolbarPanel.ResumeLayout(false);
			this.toolbarPanel.PerformLayout();
			this.ResumeLayout(false);
		}

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
		private System.Windows.Forms.Panel toolbarPanel;
		private System.Windows.Forms.Label lblAdmission;
		private System.Windows.Forms.TextBox txtSelectedAdmission;
		private System.Windows.Forms.Button btnFindAdmission;
		private System.Windows.Forms.Panel cardPanel;
		private System.Windows.Forms.DataGridView dgvTreatments;
		private System.Windows.Forms.DataGridViewTextBoxColumn colService;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUnitCost;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTotalCost;
		private System.Windows.Forms.Label lblNoResults;
		private System.Windows.Forms.Panel panelAdd;
		private System.Windows.Forms.Label lblAddTitle;
		private System.Windows.Forms.Label lblServiceName;
		private System.Windows.Forms.TextBox txtServiceName;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.NumericUpDown numQuantity;
		private System.Windows.Forms.Label lblUnitCost;
		private System.Windows.Forms.TextBox txtUnitCost;
		private System.Windows.Forms.Button btnAddItem;
		private System.Windows.Forms.Label lblSubtotal;
	}
}