using System.Windows.Forms;
namespace UI
{
	partial class AddEditRoomForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
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

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		private void InitializeComponent()
		{
			this.panelHeader = new System.Windows.Forms.Panel();
			this.lblHeader = new System.Windows.Forms.Label();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblRoomNumber = new System.Windows.Forms.Label();
			this.txtRoomNumber = new System.Windows.Forms.TextBox();
			this.lblRoomType = new System.Windows.Forms.Label();
			this.cmbRoomType = new System.Windows.Forms.ComboBox();
			this.lblRate = new System.Windows.Forms.Label();
			this.txtRate = new System.Windows.Forms.TextBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
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
			this.panel1.Controls.Add(this.cmbStatus);
			this.panel1.Controls.Add(this.lblStatus);
			this.panel1.Controls.Add(this.txtRate);
			this.panel1.Controls.Add(this.lblRate);
			this.panel1.Controls.Add(this.cmbRoomType);
			this.panel1.Controls.Add(this.lblRoomType);
			this.panel1.Controls.Add(this.txtRoomNumber);
			this.panel1.Controls.Add(this.lblRoomNumber);
			this.panel1.Location = new System.Drawing.Point(433, 105);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(500, 490);
			this.panel1.TabIndex = 0;
			// 
			// lblRoomNumber
			// 
			this.lblRoomNumber.AutoSize = true;
			this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblRoomNumber.Location = new System.Drawing.Point(40, 100);
			this.lblRoomNumber.Name = "lblRoomNumber";
			this.lblRoomNumber.Size = new System.Drawing.Size(128, 17);
			this.lblRoomNumber.TabIndex = 1;
			this.lblRoomNumber.Text = "Room Number / ID *";
			// 
			// txtRoomNumber
			// 
			this.txtRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtRoomNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRoomNumber.Location = new System.Drawing.Point(40, 125);
			this.txtRoomNumber.Name = "txtRoomNumber";
			this.txtRoomNumber.Size = new System.Drawing.Size(420, 27);
			this.txtRoomNumber.TabIndex = 2;
			// 
			// lblRoomType
			// 
			this.lblRoomType.AutoSize = true;
			this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblRoomType.Location = new System.Drawing.Point(40, 175);
			this.lblRoomType.Name = "lblRoomType";
			this.lblRoomType.Size = new System.Drawing.Size(82, 17);
			this.lblRoomType.TabIndex = 3;
			this.lblRoomType.Text = "Room Type *";
			// 
			// cmbRoomType
			// 
			this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbRoomType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbRoomType.FormattingEnabled = true;
			this.cmbRoomType.Items.AddRange(new object[] {
			"Ward",
			"Private",
			"Semi-Private",
			"ICU"});
			this.cmbRoomType.Location = new System.Drawing.Point(40, 200);
			this.cmbRoomType.Name = "cmbRoomType";
			this.cmbRoomType.Size = new System.Drawing.Size(420, 25);
			this.cmbRoomType.TabIndex = 4;
			// 
			// lblRate
			// 
			this.lblRate.AutoSize = true;
			this.lblRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblRate.Location = new System.Drawing.Point(40, 250);
			this.lblRate.Name = "lblRate";
			this.lblRate.Size = new System.Drawing.Size(87, 17);
			this.lblRate.TabIndex = 5;
			this.lblRate.Text = "Rate per Day *";
			// 
			// txtRate
			// 
			this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtRate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRate.Location = new System.Drawing.Point(40, 275);
			this.txtRate.Name = "txtRate";
			this.txtRate.Size = new System.Drawing.Size(420, 27);
			this.txtRate.TabIndex = 6;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblStatus.Location = new System.Drawing.Point(40, 325);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(54, 17);
			this.lblStatus.TabIndex = 7;
			this.lblStatus.Text = "Status *";
			// 
			// cmbStatus
			// 
			this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Items.AddRange(new object[] {
			"Available",
			"Occupied",
			"Maintenance"});
			this.cmbStatus.Location = new System.Drawing.Point(40, 350);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(420, 25);
			this.cmbStatus.TabIndex = 8;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(40, 415);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(200, 42);
			this.btnSave.TabIndex = 9;
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
			this.btnCancel.Location = new System.Drawing.Point(260, 415);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(200, 42);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// AddEditRoomForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(1366, 768);
			this.Controls.Add(this.tableLayoutPanel);
			this.Controls.Add(this.panelHeader);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.MinimumSize = new System.Drawing.Size(1000, 600);
			this.Name = "AddEditRoomForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Room";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.AddEditRoomForm_Load);
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
		private System.Windows.Forms.Label lblRoomNumber;
		private System.Windows.Forms.TextBox txtRoomNumber;
		private System.Windows.Forms.Label lblRoomType;
		private System.Windows.Forms.ComboBox cmbRoomType;
		private System.Windows.Forms.Label lblRate;
		private System.Windows.Forms.TextBox txtRate;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
	}
}