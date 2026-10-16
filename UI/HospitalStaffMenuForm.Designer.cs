namespace UI
{
	partial class HospitalStaffMenuForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnLogout = new System.Windows.Forms.Button();
			this.lblUserInfo = new System.Windows.Forms.Label();
			this.lblMainMenu = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cardPanel = new System.Windows.Forms.Panel();
			this.tilesPanel = new System.Windows.Forms.TableLayoutPanel();
			this.btnRoomMgmt = new System.Windows.Forms.Button();
			this.btnPatientInfo = new System.Windows.Forms.Button();
			this.btnPatientSearch = new System.Windows.Forms.Button();
			this.btnRoomSearch = new System.Windows.Forms.Button();
			this.btnAdmission = new System.Windows.Forms.Button();
			this.btnTreatmentBilling = new System.Windows.Forms.Button();
			this.btnBilling = new System.Windows.Forms.Button();
			this.btnDischarge = new System.Windows.Forms.Button();
			this.btnDischargeSummary = new System.Windows.Forms.Button();
			this.lblSubtitle = new System.Windows.Forms.Label();
			this.lblGreeting = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.cardPanel.SuspendLayout();
			this.tilesPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.btnLogout);
			this.panel1.Controls.Add(this.lblUserInfo);
			this.panel1.Controls.Add(this.lblMainMenu);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1366, 65);
			this.panel1.TabIndex = 0;
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
			this.btnLogout.Click += new System.EventHandler(this.llblLogout_LinkClicked);
			// 
			// lblUserInfo
			// 
			this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblUserInfo.AutoSize = true;
			this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblUserInfo.Location = new System.Drawing.Point(963, 23);
			this.lblUserInfo.Name = "lblUserInfo";
			this.lblUserInfo.Size = new System.Drawing.Size(271, 23);
			this.lblUserInfo.TabIndex = 1;
			this.lblUserInfo.Text = "Logged in as: [Name] | Role: [Role]";
			// 
			// lblMainMenu
			// 
			this.lblMainMenu.AutoSize = true;
			this.lblMainMenu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblMainMenu.Location = new System.Drawing.Point(24, 18);
			this.lblMainMenu.Name = "lblMainMenu";
			this.lblMainMenu.Size = new System.Drawing.Size(418, 37);
			this.lblMainMenu.TabIndex = 0;
			this.lblMainMenu.Text = "🏥  Hospital Admission System";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.panel2.Controls.Add(this.cardPanel);
			this.panel2.Controls.Add(this.lblSubtitle);
			this.panel2.Controls.Add(this.lblGreeting);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 65);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1366, 703);
			this.panel2.TabIndex = 1;
			// 
			// cardPanel
			// 
			this.cardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cardPanel.BackColor = System.Drawing.Color.White;
			this.cardPanel.Controls.Add(this.tilesPanel);
			this.cardPanel.Location = new System.Drawing.Point(35, 110);
			this.cardPanel.Name = "cardPanel";
			this.cardPanel.Size = new System.Drawing.Size(1296, 558);
			this.cardPanel.TabIndex = 2;
			// 
			// tilesPanel
			// 
			this.tilesPanel.ColumnCount = 4;
			this.tilesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tilesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tilesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tilesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tilesPanel.Controls.Add(this.btnRoomMgmt, 0, 0);
			this.tilesPanel.Controls.Add(this.btnPatientInfo, 1, 0);
			this.tilesPanel.Controls.Add(this.btnPatientSearch, 2, 0);
			this.tilesPanel.Controls.Add(this.btnRoomSearch, 3, 0);
			this.tilesPanel.Controls.Add(this.btnAdmission, 0, 1);
			this.tilesPanel.Controls.Add(this.btnTreatmentBilling, 1, 1);
			this.tilesPanel.Controls.Add(this.btnBilling, 2, 1);
			this.tilesPanel.Controls.Add(this.btnDischarge, 3, 1);
			this.tilesPanel.Controls.Add(this.btnDischargeSummary, 0, 2);
			this.tilesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tilesPanel.Location = new System.Drawing.Point(0, 0);
			this.tilesPanel.Name = "tilesPanel";
			this.tilesPanel.Padding = new System.Windows.Forms.Padding(20);
			this.tilesPanel.RowCount = 3;
			this.tilesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tilesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tilesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tilesPanel.Size = new System.Drawing.Size(1296, 558);
			this.tilesPanel.TabIndex = 0;
			// 
			// btnRoomMgmt
			// 
			this.btnRoomMgmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnRoomMgmt.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRoomMgmt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRoomMgmt.FlatAppearance.BorderSize = 0;
			this.btnRoomMgmt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
			this.btnRoomMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRoomMgmt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRoomMgmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
			this.btnRoomMgmt.Location = new System.Drawing.Point(35, 35);
			this.btnRoomMgmt.Margin = new System.Windows.Forms.Padding(15);
			this.btnRoomMgmt.Name = "btnRoomMgmt";
			this.btnRoomMgmt.Size = new System.Drawing.Size(284, 142);
			this.btnRoomMgmt.TabIndex = 3;
			this.btnRoomMgmt.Text = "🏠\nRoom Management";
			this.btnRoomMgmt.UseVisualStyleBackColor = false;
			this.btnRoomMgmt.Click += new System.EventHandler(this.btnRoomMgmt_Click);
			// 
			// btnPatientInfo
			// 
			this.btnPatientInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnPatientInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPatientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnPatientInfo.FlatAppearance.BorderSize = 0;
			this.btnPatientInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
			this.btnPatientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPatientInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
			this.btnPatientInfo.Location = new System.Drawing.Point(349, 35);
			this.btnPatientInfo.Margin = new System.Windows.Forms.Padding(15);
			this.btnPatientInfo.Name = "btnPatientInfo";
			this.btnPatientInfo.Size = new System.Drawing.Size(284, 142);
			this.btnPatientInfo.TabIndex = 4;
			this.btnPatientInfo.Text = "👤\nPatient Information";
			this.btnPatientInfo.UseVisualStyleBackColor = false;
			this.btnPatientInfo.Click += new System.EventHandler(this.btnPatientInfo_Click);
			// 
			// btnPatientSearch
			// 
			this.btnPatientSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnPatientSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPatientSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnPatientSearch.FlatAppearance.BorderSize = 0;
			this.btnPatientSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
			this.btnPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPatientSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPatientSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
			this.btnPatientSearch.Location = new System.Drawing.Point(663, 35);
			this.btnPatientSearch.Margin = new System.Windows.Forms.Padding(15);
			this.btnPatientSearch.Name = "btnPatientSearch";
			this.btnPatientSearch.Size = new System.Drawing.Size(284, 142);
			this.btnPatientSearch.TabIndex = 5;
			this.btnPatientSearch.Text = "🔍\nPatient Info Search";
			this.btnPatientSearch.UseVisualStyleBackColor = false;
			this.btnPatientSearch.Click += new System.EventHandler(this.btnPatientSearch_Click);
			// 
			// btnRoomSearch
			// 
			this.btnRoomSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnRoomSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRoomSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRoomSearch.FlatAppearance.BorderSize = 0;
			this.btnRoomSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
			this.btnRoomSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRoomSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRoomSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
			this.btnRoomSearch.Location = new System.Drawing.Point(977, 35);
			this.btnRoomSearch.Margin = new System.Windows.Forms.Padding(15);
			this.btnRoomSearch.Name = "btnRoomSearch";
			this.btnRoomSearch.Size = new System.Drawing.Size(284, 142);
			this.btnRoomSearch.TabIndex = 6;
			this.btnRoomSearch.Text = "🔎\nPatient Room Search";
			this.btnRoomSearch.UseVisualStyleBackColor = false;
			this.btnRoomSearch.Click += new System.EventHandler(this.btnRoomSearch_Click);
			// 
			// btnAdmission
			// 
			this.btnAdmission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnAdmission.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdmission.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAdmission.FlatAppearance.BorderSize = 0;
			this.btnAdmission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
			this.btnAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdmission.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdmission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
			this.btnAdmission.Location = new System.Drawing.Point(35, 207);
			this.btnAdmission.Margin = new System.Windows.Forms.Padding(15);
			this.btnAdmission.Name = "btnAdmission";
			this.btnAdmission.Size = new System.Drawing.Size(284, 142);
			this.btnAdmission.TabIndex = 7;
			this.btnAdmission.Text = "📋\nAdmission";
			this.btnAdmission.UseVisualStyleBackColor = false;
			this.btnAdmission.Click += new System.EventHandler(this.btnAdmission_Click);
			// 
			// btnTreatmentBilling
			// 
			this.btnTreatmentBilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnTreatmentBilling.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTreatmentBilling.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnTreatmentBilling.FlatAppearance.BorderSize = 0;
			this.btnTreatmentBilling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
			this.btnTreatmentBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTreatmentBilling.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTreatmentBilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
			this.btnTreatmentBilling.Location = new System.Drawing.Point(349, 207);
			this.btnTreatmentBilling.Margin = new System.Windows.Forms.Padding(15);
			this.btnTreatmentBilling.Name = "btnTreatmentBilling";
			this.btnTreatmentBilling.Size = new System.Drawing.Size(284, 142);
			this.btnTreatmentBilling.TabIndex = 9;
			this.btnTreatmentBilling.Text = "💊\nTreatment / Billing";
			this.btnTreatmentBilling.UseVisualStyleBackColor = false;
			// 
			// btnBilling
			// 
			this.btnBilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnBilling.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBilling.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnBilling.FlatAppearance.BorderSize = 0;
			this.btnBilling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
			this.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBilling.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
			this.btnBilling.Location = new System.Drawing.Point(663, 207);
			this.btnBilling.Margin = new System.Windows.Forms.Padding(15);
			this.btnBilling.Name = "btnBilling";
			this.btnBilling.Size = new System.Drawing.Size(284, 142);
			this.btnBilling.TabIndex = 11;
			this.btnBilling.Text = "💵\nBilling";
			this.btnBilling.UseVisualStyleBackColor = false;
			// 
			// btnDischarge
			// 
			this.btnDischarge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnDischarge.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDischarge.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDischarge.FlatAppearance.BorderSize = 0;
			this.btnDischarge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
			this.btnDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDischarge.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDischarge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
			this.btnDischarge.Location = new System.Drawing.Point(977, 207);
			this.btnDischarge.Margin = new System.Windows.Forms.Padding(15);
			this.btnDischarge.Name = "btnDischarge";
			this.btnDischarge.Size = new System.Drawing.Size(284, 142);
			this.btnDischarge.TabIndex = 12;
			this.btnDischarge.Text = "🚪\nDischarge";
			this.btnDischarge.UseVisualStyleBackColor = false;
			// 
			// btnDischargeSummary
			// 
			this.btnDischargeSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
			this.btnDischargeSummary.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDischargeSummary.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDischargeSummary.FlatAppearance.BorderSize = 0;
			this.btnDischargeSummary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
			this.btnDischargeSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDischargeSummary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDischargeSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
			this.btnDischargeSummary.Location = new System.Drawing.Point(35, 379);
			this.btnDischargeSummary.Margin = new System.Windows.Forms.Padding(15);
			this.btnDischargeSummary.Name = "btnDischargeSummary";
			this.btnDischargeSummary.Size = new System.Drawing.Size(284, 144);
			this.btnDischargeSummary.TabIndex = 13;
			this.btnDischargeSummary.Text = "📄\nDischarge Summary";
			this.btnDischargeSummary.UseVisualStyleBackColor = false;
			// 
			// lblSubtitle
			// 
			this.lblSubtitle.AutoSize = true;
			this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			this.lblSubtitle.Location = new System.Drawing.Point(38, 68);
			this.lblSubtitle.Name = "lblSubtitle";
			this.lblSubtitle.Size = new System.Drawing.Size(241, 23);
			this.lblSubtitle.TabIndex = 1;
			this.lblSubtitle.Text = "Select a module to get started";
			// 
			// lblGreeting
			// 
			this.lblGreeting.AutoSize = true;
			this.lblGreeting.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGreeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
			this.lblGreeting.Location = new System.Drawing.Point(35, 25);
			this.lblGreeting.Name = "lblGreeting";
			this.lblGreeting.Size = new System.Drawing.Size(221, 41);
			this.lblGreeting.TabIndex = 0;
			this.lblGreeting.Text = "Welcome back";
			// 
			// HospitalStaffMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(1366, 768);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.MinimumSize = new System.Drawing.Size(1200, 700);
			this.Name = "HospitalStaffMenuForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hospital Staff Menu";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.HospitalStaffMenuForm_Load_1);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.cardPanel.ResumeLayout(false);
			this.tilesPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label lblUserInfo;
		private System.Windows.Forms.Label lblMainMenu;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel cardPanel;
		private System.Windows.Forms.TableLayoutPanel tilesPanel;
		private System.Windows.Forms.Button btnDischargeSummary;
		private System.Windows.Forms.Button btnDischarge;
		private System.Windows.Forms.Button btnBilling;
		private System.Windows.Forms.Button btnTreatmentBilling;
		private System.Windows.Forms.Button btnAdmission;
		private System.Windows.Forms.Button btnRoomSearch;
		private System.Windows.Forms.Button btnPatientSearch;
		private System.Windows.Forms.Button btnPatientInfo;
		private System.Windows.Forms.Button btnRoomMgmt;
		private System.Windows.Forms.Label lblSubtitle;
		private System.Windows.Forms.Label lblGreeting;
	}
}