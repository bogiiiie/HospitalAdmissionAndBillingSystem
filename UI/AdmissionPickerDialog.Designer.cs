namespace UI
{
	partial class AdmissionPickerDialog
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
			this.panelHeader = new System.Windows.Forms.Panel();
			this.lblHeader = new System.Windows.Forms.Label();
			this.toolbarPanel = new System.Windows.Forms.Panel();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.cardPanel = new System.Windows.Forms.Panel();
			this.lblNoResults = new System.Windows.Forms.Label();
			this.dgvAdmissions = new System.Windows.Forms.DataGridView();
			this.colAdmissionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAdmitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblCount = new System.Windows.Forms.Label();
			this.footerPanel = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSelect = new System.Windows.Forms.Button();
			this.panelHeader.SuspendLayout();
			this.toolbarPanel.SuspendLayout();
			this.cardPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAdmissions)).BeginInit();
			this.footerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.White;
			this.panelHeader.Controls.Add(this.lblHeader);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(900, 60);
			this.panelHeader.TabIndex = 0;
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
			this.lblHeader.Location = new System.Drawing.Point(20, 15);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(180, 32);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Find Admission";
			// 
			// toolbarPanel
			// 
			this.toolbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.toolbarPanel.Controls.Add(this.btnSearch);
			this.toolbarPanel.Controls.Add(this.txtSearch);
			this.toolbarPanel.Controls.Add(this.lblSearch);
			this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.toolbarPanel.Location = new System.Drawing.Point(0, 60);
			this.toolbarPanel.Name = "toolbarPanel";
			this.toolbarPanel.Size = new System.Drawing.Size(900, 65);
			this.toolbarPanel.TabIndex = 1;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblSearch.Location = new System.Drawing.Point(24, 22);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(63, 23);
			this.lblSearch.TabIndex = 0;
			this.lblSearch.Text = "Search:";
			// 
			// txtSearch
			// 
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtSearch.Location = new System.Drawing.Point(95, 19);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(450, 30);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(555, 19);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(100, 32);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "🔍 Search";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// cardPanel
			// 
			this.cardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.cardPanel.BackColor = System.Drawing.Color.White;
			this.cardPanel.Controls.Add(this.lblNoResults);
			this.cardPanel.Controls.Add(this.dgvAdmissions);
			this.cardPanel.Controls.Add(this.lblCount);
			this.cardPanel.Location = new System.Drawing.Point(24, 135);
			this.cardPanel.Name = "cardPanel";
			this.cardPanel.Size = new System.Drawing.Size(852, 395);
			this.cardPanel.TabIndex = 2;
			// 
			// dgvAdmissions
			// 
			this.dgvAdmissions.AllowUserToAddRows = false;
			this.dgvAdmissions.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.dgvAdmissions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAdmissions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAdmissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAdmissions.BackgroundColor = System.Drawing.Color.White;
			this.dgvAdmissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvAdmissions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvAdmissions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.dgvAdmissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvAdmissions.ColumnHeadersHeight = 45;
			this.dgvAdmissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colAdmissionCode, this.colPatientName, this.colRoom, this.colAdmitDate });
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.dgvAdmissions.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvAdmissions.EnableHeadersVisualStyles = false;
			this.dgvAdmissions.Location = new System.Drawing.Point(0, 0);
			this.dgvAdmissions.MultiSelect = false;
			this.dgvAdmissions.Name = "dgvAdmissions";
			this.dgvAdmissions.ReadOnly = true;
			this.dgvAdmissions.RowHeadersVisible = false;
			this.dgvAdmissions.RowTemplate.Height = 42;
			this.dgvAdmissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAdmissions.Size = new System.Drawing.Size(852, 350);
			this.dgvAdmissions.TabIndex = 0;
			this.dgvAdmissions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmissions_CellDoubleClick);
			this.dgvAdmissions.SelectionChanged += new System.EventHandler(this.dgvAdmissions_SelectionChanged);
			// 
			// colAdmissionCode
			// 
			this.colAdmissionCode.FillWeight = 20F;
			this.colAdmissionCode.HeaderText = "Admission Code";
			this.colAdmissionCode.Name = "colAdmissionCode";
			// 
			// colPatientName
			// 
			this.colPatientName.FillWeight = 40F;
			this.colPatientName.HeaderText = "Patient Name";
			this.colPatientName.Name = "colPatientName";
			// 
			// colRoom
			// 
			this.colRoom.FillWeight = 15F;
			this.colRoom.HeaderText = "Room";
			this.colRoom.Name = "colRoom";
			// 
			// colAdmitDate
			// 
			this.colAdmitDate.FillWeight = 25F;
			this.colAdmitDate.HeaderText = "Admit Date";
			this.colAdmitDate.Name = "colAdmitDate";
			// 
			// lblNoResults
			// 
			this.lblNoResults.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNoResults.AutoSize = true;
			this.lblNoResults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
			this.lblNoResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
			this.lblNoResults.Location = new System.Drawing.Point(320, 160);
			this.lblNoResults.Name = "lblNoResults";
			this.lblNoResults.Size = new System.Drawing.Size(210, 25);
			this.lblNoResults.TabIndex = 2;
			this.lblNoResults.Text = "No active admissions found.";
			this.lblNoResults.Visible = false;
			// 
			// lblCount
			// 
			this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblCount.AutoSize = true;
			this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblCount.Location = new System.Drawing.Point(20, 362);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(134, 23);
			this.lblCount.TabIndex = 1;
			this.lblCount.Text = "Total Results: 0";
			// 
			// footerPanel
			// 
			this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.footerPanel.Controls.Add(this.btnCancel);
			this.footerPanel.Controls.Add(this.btnSelect);
			this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.footerPanel.Location = new System.Drawing.Point(0, 545);
			this.footerPanel.Name = "footerPanel";
			this.footerPanel.Size = new System.Drawing.Size(900, 70);
			this.footerPanel.TabIndex = 3;
			// 
			// btnSelect
			// 
			this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSelect.Enabled = false;
			this.btnSelect.FlatAppearance.BorderSize = 0;
			this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnSelect.ForeColor = System.Drawing.Color.White;
			this.btnSelect.Location = new System.Drawing.Point(546, 15);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(180, 40);
			this.btnSelect.TabIndex = 0;
			this.btnSelect.Text = "Select Admission";
			this.btnSelect.UseVisualStyleBackColor = false;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.BackColor = System.Drawing.Color.White;
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
			this.btnCancel.FlatAppearance.BorderSize = 1;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnCancel.Location = new System.Drawing.Point(736, 15);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(140, 40);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// AdmissionPickerDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(900, 615);
			this.Controls.Add(this.cardPanel);
			this.Controls.Add(this.footerPanel);
			this.Controls.Add(this.toolbarPanel);
			this.Controls.Add(this.panelHeader);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AdmissionPickerDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Find Admission";
			this.Load += new System.EventHandler(this.AdmissionPickerDialog_Load);
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.toolbarPanel.ResumeLayout(false);
			this.toolbarPanel.PerformLayout();
			this.cardPanel.ResumeLayout(false);
			this.cardPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAdmissions)).EndInit();
			this.footerPanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.Panel toolbarPanel;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Panel cardPanel;
		private System.Windows.Forms.DataGridView dgvAdmissions;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAdmissionCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAdmitDate;
		private System.Windows.Forms.Label lblNoResults;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.Panel footerPanel;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Button btnCancel;
	}
}