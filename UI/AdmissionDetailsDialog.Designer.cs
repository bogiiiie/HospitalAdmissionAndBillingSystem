namespace UI
{
	partial class AdmissionDetailsDialog
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
			this.panelHeader = new System.Windows.Forms.Panel();
			this.lblHeader = new System.Windows.Forms.Label();
			this.panelBody = new System.Windows.Forms.Panel();
			this.lblSectionPatient = new System.Windows.Forms.Label();
			this.lblPatientLabel = new System.Windows.Forms.Label();
			this.lblPatientValue = new System.Windows.Forms.Label();
			this.lblSectionAdmission = new System.Windows.Forms.Label();
			this.lblCodeLabel = new System.Windows.Forms.Label();
			this.lblCodeValue = new System.Windows.Forms.Label();
			this.lblDateLabel = new System.Windows.Forms.Label();
			this.lblDateValue = new System.Windows.Forms.Label();
			this.lblStatusLabel = new System.Windows.Forms.Label();
			this.lblStatusValue = new System.Windows.Forms.Label();
			this.lblByLabel = new System.Windows.Forms.Label();
			this.lblByValue = new System.Windows.Forms.Label();
			this.lblDiagnosisLabel = new System.Windows.Forms.Label();
			this.lblDiagnosisValue = new System.Windows.Forms.Label();
			this.lblDoctorLabel = new System.Windows.Forms.Label();
			this.lblDoctorValue = new System.Windows.Forms.Label();
			this.lblNurseLabel = new System.Windows.Forms.Label();
			this.lblNurseValue = new System.Windows.Forms.Label();
			this.lblSectionHistory = new System.Windows.Forms.Label();
			this.dgvHistory = new System.Windows.Forms.DataGridView();
			this.colRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblSectionBilling = new System.Windows.Forms.Label();
			this.lblRoomChargesLabel = new System.Windows.Forms.Label();
			this.lblRoomChargesValue = new System.Windows.Forms.Label();
			this.lblTreatmentLabel = new System.Windows.Forms.Label();
			this.lblTreatmentValue = new System.Windows.Forms.Label();
			this.lblDiscountLabel = new System.Windows.Forms.Label();
			this.lblDiscountValue = new System.Windows.Forms.Label();
			this.lblPaymentStatusLabel = new System.Windows.Forms.Label();
			this.lblPaymentStatusValue = new System.Windows.Forms.Label();
			this.lblTotalLabel = new System.Windows.Forms.Label();
			this.lblTotalValue = new System.Windows.Forms.Label();
			this.panelFooter = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.panelHeader.SuspendLayout();
			this.panelBody.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
			this.panelFooter.SuspendLayout();
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
			this.lblHeader.Location = new System.Drawing.Point(24, 16);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(300, 32);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Admission Details";
			// 
			// panelBody
			// 
			this.panelBody.AutoScroll = true; // 👈 THIS MAKES IT SCROLLABLE
			this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.panelBody.Controls.Add(this.lblTotalValue);
			this.panelBody.Controls.Add(this.lblTotalLabel);
			this.panelBody.Controls.Add(this.lblPaymentStatusValue);
			this.panelBody.Controls.Add(this.lblPaymentStatusLabel);
			this.panelBody.Controls.Add(this.lblDiscountValue);
			this.panelBody.Controls.Add(this.lblDiscountLabel);
			this.panelBody.Controls.Add(this.lblTreatmentValue);
			this.panelBody.Controls.Add(this.lblTreatmentLabel);
			this.panelBody.Controls.Add(this.lblRoomChargesValue);
			this.panelBody.Controls.Add(this.lblRoomChargesLabel);
			this.panelBody.Controls.Add(this.lblSectionBilling);
			this.panelBody.Controls.Add(this.dgvHistory);
			this.panelBody.Controls.Add(this.lblSectionHistory);
			this.panelBody.Controls.Add(this.lblNurseValue);
			this.panelBody.Controls.Add(this.lblNurseLabel);
			this.panelBody.Controls.Add(this.lblDoctorValue);
			this.panelBody.Controls.Add(this.lblDoctorLabel);
			this.panelBody.Controls.Add(this.lblDiagnosisValue);
			this.panelBody.Controls.Add(this.lblDiagnosisLabel);
			this.panelBody.Controls.Add(this.lblByValue);
			this.panelBody.Controls.Add(this.lblByLabel);
			this.panelBody.Controls.Add(this.lblStatusValue);
			this.panelBody.Controls.Add(this.lblStatusLabel);
			this.panelBody.Controls.Add(this.lblDateValue);
			this.panelBody.Controls.Add(this.lblDateLabel);
			this.panelBody.Controls.Add(this.lblCodeValue);
			this.panelBody.Controls.Add(this.lblCodeLabel);
			this.panelBody.Controls.Add(this.lblSectionAdmission);
			this.panelBody.Controls.Add(this.lblPatientValue);
			this.panelBody.Controls.Add(this.lblPatientLabel);
			this.panelBody.Controls.Add(this.lblSectionPatient);
			this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBody.Location = new System.Drawing.Point(0, 60);
			this.panelBody.Name = "panelBody";
			this.panelBody.Size = new System.Drawing.Size(900, 570);
			this.panelBody.TabIndex = 1;
			// 
			// lblSectionPatient
			// 
			this.lblSectionPatient.AutoSize = true;
			this.lblSectionPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblSectionPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblSectionPatient.Location = new System.Drawing.Point(40, 20);
			this.lblSectionPatient.Name = "lblSectionPatient";
			this.lblSectionPatient.Size = new System.Drawing.Size(200, 23);
			this.lblSectionPatient.TabIndex = 0;
			this.lblSectionPatient.Text = "── PATIENT ──";
			// 
			// lblPatientLabel
			// 
			this.lblPatientLabel.AutoSize = true;
			this.lblPatientLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblPatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblPatientLabel.Location = new System.Drawing.Point(40, 55);
			this.lblPatientLabel.Name = "lblPatientLabel";
			this.lblPatientLabel.Size = new System.Drawing.Size(72, 23);
			this.lblPatientLabel.TabIndex = 1;
			this.lblPatientLabel.Text = "Patient:";
			// 
			// lblPatientValue
			// 
			this.lblPatientValue.AutoSize = true;
			this.lblPatientValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblPatientValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblPatientValue.Location = new System.Drawing.Point(200, 56);
			this.lblPatientValue.Name = "lblPatientValue";
			this.lblPatientValue.Size = new System.Drawing.Size(80, 23);
			this.lblPatientValue.TabIndex = 2;
			this.lblPatientValue.Text = "—";
			// 
			// lblSectionAdmission
			// 
			this.lblSectionAdmission.AutoSize = true;
			this.lblSectionAdmission.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblSectionAdmission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblSectionAdmission.Location = new System.Drawing.Point(40, 90);
			this.lblSectionAdmission.Name = "lblSectionAdmission";
			this.lblSectionAdmission.Size = new System.Drawing.Size(200, 23);
			this.lblSectionAdmission.TabIndex = 3;
			this.lblSectionAdmission.Text = "── ADMISSION ──";
			// 
			// lblCodeLabel
			// 
			this.lblCodeLabel.AutoSize = true;
			this.lblCodeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblCodeLabel.Location = new System.Drawing.Point(40, 125);
			this.lblCodeLabel.Name = "lblCodeLabel";
			this.lblCodeLabel.Size = new System.Drawing.Size(62, 23);
			this.lblCodeLabel.TabIndex = 4;
			this.lblCodeLabel.Text = "Code:";
			// 
			// lblCodeValue
			// 
			this.lblCodeValue.AutoSize = true;
			this.lblCodeValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblCodeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblCodeValue.Location = new System.Drawing.Point(200, 126);
			this.lblCodeValue.Name = "lblCodeValue";
			this.lblCodeValue.Size = new System.Drawing.Size(80, 23);
			this.lblCodeValue.TabIndex = 5;
			this.lblCodeValue.Text = "—";
			// 
			// lblDateLabel
			// 
			this.lblDateLabel.AutoSize = true;
			this.lblDateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblDateLabel.Location = new System.Drawing.Point(40, 155);
			this.lblDateLabel.Name = "lblDateLabel";
			this.lblDateLabel.Size = new System.Drawing.Size(55, 23);
			this.lblDateLabel.TabIndex = 6;
			this.lblDateLabel.Text = "Date:";
			// 
			// lblDateValue
			// 
			this.lblDateValue.AutoSize = true;
			this.lblDateValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblDateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblDateValue.Location = new System.Drawing.Point(200, 156);
			this.lblDateValue.Name = "lblDateValue";
			this.lblDateValue.Size = new System.Drawing.Size(80, 23);
			this.lblDateValue.TabIndex = 7;
			this.lblDateValue.Text = "—";
			// 
			// lblStatusLabel
			// 
			this.lblStatusLabel.AutoSize = true;
			this.lblStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblStatusLabel.Location = new System.Drawing.Point(40, 185);
			this.lblStatusLabel.Name = "lblStatusLabel";
			this.lblStatusLabel.Size = new System.Drawing.Size(66, 23);
			this.lblStatusLabel.TabIndex = 8;
			this.lblStatusLabel.Text = "Status:";
			// 
			// lblStatusValue
			// 
			this.lblStatusValue.AutoSize = true;
			this.lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblStatusValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.lblStatusValue.Location = new System.Drawing.Point(200, 186);
			this.lblStatusValue.Name = "lblStatusValue";
			this.lblStatusValue.Size = new System.Drawing.Size(80, 23);
			this.lblStatusValue.TabIndex = 9;
			this.lblStatusValue.Text = "—";
			// 
			// lblByLabel
			// 
			this.lblByLabel.AutoSize = true;
			this.lblByLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblByLabel.Location = new System.Drawing.Point(40, 215);
			this.lblByLabel.Name = "lblByLabel";
			this.lblByLabel.Size = new System.Drawing.Size(130, 23);
			this.lblByLabel.TabIndex = 10;
			this.lblByLabel.Text = "Admitted By:";
			// 
			// lblByValue
			// 
			this.lblByValue.AutoSize = true;
			this.lblByValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblByValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblByValue.Location = new System.Drawing.Point(200, 216);
			this.lblByValue.Name = "lblByValue";
			this.lblByValue.Size = new System.Drawing.Size(80, 23);
			this.lblByValue.TabIndex = 11;
			this.lblByValue.Text = "—";
			// 
			// lblDiagnosisLabel
			// 
			this.lblDiagnosisLabel.AutoSize = true;
			this.lblDiagnosisLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblDiagnosisLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblDiagnosisLabel.Location = new System.Drawing.Point(40, 245);
			this.lblDiagnosisLabel.Name = "lblDiagnosisLabel";
			this.lblDiagnosisLabel.Size = new System.Drawing.Size(96, 23);
			this.lblDiagnosisLabel.TabIndex = 12;
			this.lblDiagnosisLabel.Text = "Diagnosis:";
			// 
			// lblDiagnosisValue
			// 
			this.lblDiagnosisValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblDiagnosisValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblDiagnosisValue.Location = new System.Drawing.Point(200, 246);
			this.lblDiagnosisValue.MaximumSize = new System.Drawing.Size(660, 50);
			this.lblDiagnosisValue.Name = "lblDiagnosisValue";
			this.lblDiagnosisValue.Size = new System.Drawing.Size(660, 23);
			this.lblDiagnosisValue.TabIndex = 13;
			this.lblDiagnosisValue.Text = "—";
			// 
			// lblDoctorLabel
			// 
			this.lblDoctorLabel.AutoSize = true;
			this.lblDoctorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblDoctorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblDoctorLabel.Location = new System.Drawing.Point(40, 275);
			this.lblDoctorLabel.Name = "lblDoctorLabel";
			this.lblDoctorLabel.Size = new System.Drawing.Size(160, 23);
			this.lblDoctorLabel.TabIndex = 14;
			this.lblDoctorLabel.Text = "Attending Doctor:";
			// 
			// lblDoctorValue
			// 
			this.lblDoctorValue.AutoSize = true;
			this.lblDoctorValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblDoctorValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblDoctorValue.Location = new System.Drawing.Point(200, 276);
			this.lblDoctorValue.Name = "lblDoctorValue";
			this.lblDoctorValue.Size = new System.Drawing.Size(80, 23);
			this.lblDoctorValue.TabIndex = 15;
			this.lblDoctorValue.Text = "—";
			// 
			// lblNurseLabel
			// 
			this.lblNurseLabel.AutoSize = true;
			this.lblNurseLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblNurseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblNurseLabel.Location = new System.Drawing.Point(500, 275);
			this.lblNurseLabel.Name = "lblNurseLabel";
			this.lblNurseLabel.Size = new System.Drawing.Size(140, 23);
			this.lblNurseLabel.TabIndex = 16;
			this.lblNurseLabel.Text = "Assigned Nurse:";
			// 
			// lblNurseValue
			// 
			this.lblNurseValue.AutoSize = true;
			this.lblNurseValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblNurseValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblNurseValue.Location = new System.Drawing.Point(650, 276);
			this.lblNurseValue.Name = "lblNurseValue";
			this.lblNurseValue.Size = new System.Drawing.Size(80, 23);
			this.lblNurseValue.TabIndex = 17;
			this.lblNurseValue.Text = "—";
			// 
			// lblSectionHistory
			// 
			this.lblSectionHistory.AutoSize = true;
			this.lblSectionHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblSectionHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblSectionHistory.Location = new System.Drawing.Point(40, 320);
			this.lblSectionHistory.Name = "lblSectionHistory";
			this.lblSectionHistory.Size = new System.Drawing.Size(240, 23);
			this.lblSectionHistory.TabIndex = 18;
			this.lblSectionHistory.Text = "── ROOM HISTORY ──";
			// 
			// dgvHistory
			// 
			this.dgvHistory.AllowUserToAddRows = false;
			this.dgvHistory.AllowUserToDeleteRows = false;
			this.dgvHistory.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
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
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			this.dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvHistory.ColumnHeadersHeight = 40;
			this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colRoomNumber,
			this.colRoomType,
			this.colRate,
			this.colFrom,
			this.colTo});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvHistory.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvHistory.EnableHeadersVisualStyles = false;
			this.dgvHistory.GridColor = System.Drawing.Color.White;
			this.dgvHistory.Location = new System.Drawing.Point(40, 350);
			this.dgvHistory.MultiSelect = false;
			this.dgvHistory.Name = "dgvHistory";
			this.dgvHistory.ReadOnly = true;
			this.dgvHistory.RowHeadersVisible = false;
			this.dgvHistory.RowHeadersWidth = 51;
			this.dgvHistory.RowTemplate.Height = 36;
			this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHistory.Size = new System.Drawing.Size(820, 120);
			this.dgvHistory.TabIndex = 19;
			// 
			// colRoomNumber
			// 
			this.colRoomNumber.FillWeight = 15F;
			this.colRoomNumber.HeaderText = "Room #";
			this.colRoomNumber.MinimumWidth = 6;
			this.colRoomNumber.Name = "colRoomNumber";
			this.colRoomNumber.ReadOnly = true;
			// 
			// colRoomType
			// 
			this.colRoomType.FillWeight = 20F;
			this.colRoomType.HeaderText = "Type";
			this.colRoomType.MinimumWidth = 6;
			this.colRoomType.Name = "colRoomType";
			this.colRoomType.ReadOnly = true;
			// 
			// colRate
			// 
			this.colRate.FillWeight = 20F;
			this.colRate.HeaderText = "Rate / Day";
			this.colRate.MinimumWidth = 6;
			this.colRate.Name = "colRate";
			this.colRate.ReadOnly = true;
			// 
			// colFrom
			// 
			this.colFrom.FillWeight = 22F;
			this.colFrom.HeaderText = "From";
			this.colFrom.MinimumWidth = 6;
			this.colFrom.Name = "colFrom";
			this.colFrom.ReadOnly = true;
			// 
			// colTo
			// 
			this.colTo.FillWeight = 23F;
			this.colTo.HeaderText = "To";
			this.colTo.MinimumWidth = 6;
			this.colTo.Name = "colTo";
			this.colTo.ReadOnly = true;
			// 
			// lblSectionBilling
			// 
			this.lblSectionBilling.AutoSize = true;
			this.lblSectionBilling.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblSectionBilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
			this.lblSectionBilling.Location = new System.Drawing.Point(40, 490);
			this.lblSectionBilling.Name = "lblSectionBilling";
			this.lblSectionBilling.Size = new System.Drawing.Size(200, 23);
			this.lblSectionBilling.TabIndex = 20;
			this.lblSectionBilling.Text = "── BILLING ──";
			// 
			// lblRoomChargesLabel
			// 
			this.lblRoomChargesLabel.AutoSize = true;
			this.lblRoomChargesLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblRoomChargesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblRoomChargesLabel.Location = new System.Drawing.Point(40, 525);
			this.lblRoomChargesLabel.Name = "lblRoomChargesLabel";
			this.lblRoomChargesLabel.Size = new System.Drawing.Size(140, 23);
			this.lblRoomChargesLabel.TabIndex = 21;
			this.lblRoomChargesLabel.Text = "Room Charges:";
			// 
			// lblRoomChargesValue
			// 
			this.lblRoomChargesValue.AutoSize = true;
			this.lblRoomChargesValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblRoomChargesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblRoomChargesValue.Location = new System.Drawing.Point(260, 526);
			this.lblRoomChargesValue.Name = "lblRoomChargesValue";
			this.lblRoomChargesValue.Size = new System.Drawing.Size(80, 23);
			this.lblRoomChargesValue.TabIndex = 22;
			this.lblRoomChargesValue.Text = "₱0.00";
			// 
			// lblTreatmentLabel
			// 
			this.lblTreatmentLabel.AutoSize = true;
			this.lblTreatmentLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblTreatmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblTreatmentLabel.Location = new System.Drawing.Point(40, 555);
			this.lblTreatmentLabel.Name = "lblTreatmentLabel";
			this.lblTreatmentLabel.Size = new System.Drawing.Size(145, 23);
			this.lblTreatmentLabel.TabIndex = 23;
			this.lblTreatmentLabel.Text = "Treatment:";
			// 
			// lblTreatmentValue
			// 
			this.lblTreatmentValue.AutoSize = true;
			this.lblTreatmentValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblTreatmentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
			this.lblTreatmentValue.Location = new System.Drawing.Point(260, 556);
			this.lblTreatmentValue.Name = "lblTreatmentValue";
			this.lblTreatmentValue.Size = new System.Drawing.Size(80, 23);
			this.lblTreatmentValue.TabIndex = 24;
			this.lblTreatmentValue.Text = "₱0.00";
			// 
			// lblDiscountLabel
			// 
			this.lblDiscountLabel.AutoSize = true;
			this.lblDiscountLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblDiscountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblDiscountLabel.Location = new System.Drawing.Point(40, 585);
			this.lblDiscountLabel.Name = "lblDiscountLabel";
			this.lblDiscountLabel.Size = new System.Drawing.Size(90, 23);
			this.lblDiscountLabel.TabIndex = 25;
			this.lblDiscountLabel.Text = "Discount:";
			// 
			// lblDiscountValue
			// 
			this.lblDiscountValue.AutoSize = true;
			this.lblDiscountValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblDiscountValue.ForeColor = System.Drawing.Color.Red;
			this.lblDiscountValue.Location = new System.Drawing.Point(260, 586);
			this.lblDiscountValue.Name = "lblDiscountValue";
			this.lblDiscountValue.Size = new System.Drawing.Size(80, 23);
			this.lblDiscountValue.TabIndex = 26;
			this.lblDiscountValue.Text = "—";
			// 
			// lblPaymentStatusLabel
			// 
			this.lblPaymentStatusLabel.AutoSize = true;
			this.lblPaymentStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblPaymentStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
			this.lblPaymentStatusLabel.Location = new System.Drawing.Point(450, 585);
			this.lblPaymentStatusLabel.Name = "lblPaymentStatusLabel";
			this.lblPaymentStatusLabel.Size = new System.Drawing.Size(66, 23);
			this.lblPaymentStatusLabel.TabIndex = 27;
			this.lblPaymentStatusLabel.Text = "Status:";
			// 
			// lblPaymentStatusValue
			// 
			this.lblPaymentStatusValue.AutoSize = true;
			this.lblPaymentStatusValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblPaymentStatusValue.ForeColor = System.Drawing.Color.Gray;
			this.lblPaymentStatusValue.Location = new System.Drawing.Point(550, 586);
			this.lblPaymentStatusValue.Name = "lblPaymentStatusValue";
			this.lblPaymentStatusValue.Size = new System.Drawing.Size(100, 23);
			this.lblPaymentStatusValue.TabIndex = 28;
			this.lblPaymentStatusValue.Text = "Not Billed";
			// 
			// lblTotalLabel
			// 
			this.lblTotalLabel.AutoSize = true;
			this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
			this.lblTotalLabel.Location = new System.Drawing.Point(40, 625);
			this.lblTotalLabel.Name = "lblTotalLabel";
			this.lblTotalLabel.Size = new System.Drawing.Size(160, 25);
			this.lblTotalLabel.TabIndex = 29;
			this.lblTotalLabel.Text = "Total:";
			// 
			// lblTotalValue
			// 
			this.lblTotalValue.AutoSize = true;
			this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.lblTotalValue.Location = new System.Drawing.Point(260, 626);
			this.lblTotalValue.Name = "lblTotalValue";
			this.lblTotalValue.Size = new System.Drawing.Size(80, 25);
			this.lblTotalValue.TabIndex = 30;
			this.lblTotalValue.Text = "₱0.00";
			// 
			// panelFooter
			// 
			this.panelFooter.BackColor = System.Drawing.Color.White;
			this.panelFooter.Controls.Add(this.btnClose);
			this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelFooter.Location = new System.Drawing.Point(0, 630);
			this.panelFooter.Name = "panelFooter";
			this.panelFooter.Size = new System.Drawing.Size(900, 70);
			this.panelFooter.TabIndex = 2;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(40, 15);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(150, 40);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// AdmissionDetailsDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(900, 700); // Reduced from 810 to fit standard screens
			this.Controls.Add(this.panelBody);
			this.Controls.Add(this.panelFooter);
			this.Controls.Add(this.panelHeader);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(916, 739);
			this.Name = "AdmissionDetailsDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Admission Details";
			this.Load += new System.EventHandler(this.AdmissionDetailsDialog_Load);
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.panelBody.ResumeLayout(false);
			this.panelBody.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
			this.panelFooter.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.Panel panelBody;
		private System.Windows.Forms.Label lblSectionPatient;
		private System.Windows.Forms.Label lblPatientLabel;
		private System.Windows.Forms.Label lblPatientValue;
		private System.Windows.Forms.Label lblSectionAdmission;
		private System.Windows.Forms.Label lblCodeLabel;
		private System.Windows.Forms.Label lblCodeValue;
		private System.Windows.Forms.Label lblDateLabel;
		private System.Windows.Forms.Label lblDateValue;
		private System.Windows.Forms.Label lblStatusLabel;
		private System.Windows.Forms.Label lblStatusValue;
		private System.Windows.Forms.Label lblByLabel;
		private System.Windows.Forms.Label lblByValue;
		private System.Windows.Forms.Label lblDiagnosisLabel;
		private System.Windows.Forms.Label lblDiagnosisValue;
		private System.Windows.Forms.Label lblDoctorLabel;
		private System.Windows.Forms.Label lblDoctorValue;
		private System.Windows.Forms.Label lblNurseLabel;
		private System.Windows.Forms.Label lblNurseValue;
		private System.Windows.Forms.Label lblSectionHistory;
		private System.Windows.Forms.DataGridView dgvHistory;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRoomNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRoomType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFrom;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTo;
		private System.Windows.Forms.Label lblSectionBilling;
		private System.Windows.Forms.Label lblRoomChargesLabel;
		private System.Windows.Forms.Label lblRoomChargesValue;
		private System.Windows.Forms.Label lblTreatmentLabel;
		private System.Windows.Forms.Label lblTreatmentValue;
		private System.Windows.Forms.Label lblDiscountLabel;
		private System.Windows.Forms.Label lblDiscountValue;
		private System.Windows.Forms.Label lblPaymentStatusLabel;
		private System.Windows.Forms.Label lblPaymentStatusValue;
		private System.Windows.Forms.Label lblTotalLabel;
		private System.Windows.Forms.Label lblTotalValue;
		private System.Windows.Forms.Panel panelFooter;
		private System.Windows.Forms.Button btnClose;
	}
}