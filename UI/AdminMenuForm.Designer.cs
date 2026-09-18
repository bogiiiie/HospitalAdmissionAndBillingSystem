namespace UI
{
    partial class AdminMenuForm
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
			this.lblMainMenu = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.llblLogout = new System.Windows.Forms.LinkLabel();
			this.lblUserInfo = new System.Windows.Forms.Label();
			this.btnRoomMgmt = new System.Windows.Forms.Button();
			this.btnPatientInfo = new System.Windows.Forms.Button();
			this.btnPatientSearch = new System.Windows.Forms.Button();
			this.btnRoomSearch = new System.Windows.Forms.Button();
			this.btnAdmission = new System.Windows.Forms.Button();
			this.btnAdmissionLog = new System.Windows.Forms.Button();
			this.btnTreatmentBilling = new System.Windows.Forms.Button();
			this.btnDoctorAssign = new System.Windows.Forms.Button();
			this.btnBilling = new System.Windows.Forms.Button();
			this.btnDischarge = new System.Windows.Forms.Button();
			this.btnDischargeSummary = new System.Windows.Forms.Button();
			this.btnUserMgmt = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel1.Controls.Add(this.lblMainMenu);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(900, 45);
			this.panel1.TabIndex = 0;
			// 
			// lblMainMenu
			// 
			this.lblMainMenu.AutoSize = true;
			this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMainMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblMainMenu.Location = new System.Drawing.Point(3, 9);
			this.lblMainMenu.Name = "lblMainMenu";
			this.lblMainMenu.Size = new System.Drawing.Size(119, 25);
			this.lblMainMenu.TabIndex = 0;
			this.lblMainMenu.Text = "Main Menu";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panel2.Controls.Add(this.llblLogout);
			this.panel2.Controls.Add(this.lblUserInfo);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 45);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(900, 29);
			this.panel2.TabIndex = 1;
			// 
			// llblLogout
			// 
			this.llblLogout.AutoSize = true;
			this.llblLogout.LinkColor = System.Drawing.Color.Black;
			this.llblLogout.Location = new System.Drawing.Point(826, 7);
			this.llblLogout.Name = "llblLogout";
			this.llblLogout.Size = new System.Drawing.Size(62, 16);
			this.llblLogout.TabIndex = 1;
			this.llblLogout.TabStop = true;
			this.llblLogout.Text = "[ Logout ]";
			this.llblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLogout_LinkClicked);
			// 
			// lblUserInfo
			// 
			this.lblUserInfo.AutoSize = true;
			this.lblUserInfo.Location = new System.Drawing.Point(5, 7);
			this.lblUserInfo.Name = "lblUserInfo";
			this.lblUserInfo.Size = new System.Drawing.Size(217, 16);
			this.lblUserInfo.TabIndex = 0;
			this.lblUserInfo.Text = "Logged in as: [Name] | Role: [Role]";
			// 
			// btnRoomMgmt
			// 
			this.btnRoomMgmt.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRoomMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRoomMgmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRoomMgmt.ForeColor = System.Drawing.Color.Black;
			this.btnRoomMgmt.Location = new System.Drawing.Point(26, 114);
			this.btnRoomMgmt.Name = "btnRoomMgmt";
			this.btnRoomMgmt.Size = new System.Drawing.Size(196, 88);
			this.btnRoomMgmt.TabIndex = 2;
			this.btnRoomMgmt.Text = "Room Mgmt";
			this.btnRoomMgmt.UseVisualStyleBackColor = false;
			// 
			// btnPatientInfo
			// 
			this.btnPatientInfo.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPatientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPatientInfo.ForeColor = System.Drawing.Color.Black;
			this.btnPatientInfo.Location = new System.Drawing.Point(243, 114);
			this.btnPatientInfo.Name = "btnPatientInfo";
			this.btnPatientInfo.Size = new System.Drawing.Size(196, 88);
			this.btnPatientInfo.TabIndex = 3;
			this.btnPatientInfo.Text = "Patient Info";
			this.btnPatientInfo.UseVisualStyleBackColor = false;
			// 
			// btnPatientSearch
			// 
			this.btnPatientSearch.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPatientSearch.ForeColor = System.Drawing.Color.Black;
			this.btnPatientSearch.Location = new System.Drawing.Point(461, 114);
			this.btnPatientSearch.Name = "btnPatientSearch";
			this.btnPatientSearch.Size = new System.Drawing.Size(196, 88);
			this.btnPatientSearch.TabIndex = 4;
			this.btnPatientSearch.Text = "Patient Search";
			this.btnPatientSearch.UseVisualStyleBackColor = false;
			// 
			// btnRoomSearch
			// 
			this.btnRoomSearch.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRoomSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRoomSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRoomSearch.ForeColor = System.Drawing.Color.Black;
			this.btnRoomSearch.Location = new System.Drawing.Point(679, 114);
			this.btnRoomSearch.Name = "btnRoomSearch";
			this.btnRoomSearch.Size = new System.Drawing.Size(196, 88);
			this.btnRoomSearch.TabIndex = 5;
			this.btnRoomSearch.Text = "Room Search";
			this.btnRoomSearch.UseVisualStyleBackColor = false;
			// 
			// btnAdmission
			// 
			this.btnAdmission.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdmission.ForeColor = System.Drawing.Color.Black;
			this.btnAdmission.Location = new System.Drawing.Point(26, 233);
			this.btnAdmission.Name = "btnAdmission";
			this.btnAdmission.Size = new System.Drawing.Size(196, 88);
			this.btnAdmission.TabIndex = 6;
			this.btnAdmission.Text = "Admission";
			this.btnAdmission.UseVisualStyleBackColor = false;
			// 
			// btnAdmissionLog
			// 
			this.btnAdmissionLog.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnAdmissionLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdmissionLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdmissionLog.ForeColor = System.Drawing.Color.Black;
			this.btnAdmissionLog.Location = new System.Drawing.Point(243, 233);
			this.btnAdmissionLog.Name = "btnAdmissionLog";
			this.btnAdmissionLog.Size = new System.Drawing.Size(196, 88);
			this.btnAdmissionLog.TabIndex = 7;
			this.btnAdmissionLog.Text = "Admission Log";
			this.btnAdmissionLog.UseVisualStyleBackColor = false;
			// 
			// btnTreatmentBilling
			// 
			this.btnTreatmentBilling.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnTreatmentBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTreatmentBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTreatmentBilling.ForeColor = System.Drawing.Color.Black;
			this.btnTreatmentBilling.Location = new System.Drawing.Point(461, 233);
			this.btnTreatmentBilling.Name = "btnTreatmentBilling";
			this.btnTreatmentBilling.Size = new System.Drawing.Size(196, 88);
			this.btnTreatmentBilling.TabIndex = 8;
			this.btnTreatmentBilling.Text = "Treatment Billing";
			this.btnTreatmentBilling.UseVisualStyleBackColor = false;
			// 
			// btnDoctorAssign
			// 
			this.btnDoctorAssign.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDoctorAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDoctorAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDoctorAssign.ForeColor = System.Drawing.Color.Black;
			this.btnDoctorAssign.Location = new System.Drawing.Point(680, 233);
			this.btnDoctorAssign.Name = "btnDoctorAssign";
			this.btnDoctorAssign.Size = new System.Drawing.Size(196, 88);
			this.btnDoctorAssign.TabIndex = 9;
			this.btnDoctorAssign.Text = "Doctor/Nurse Assign";
			this.btnDoctorAssign.UseVisualStyleBackColor = false;
			// 
			// btnBilling
			// 
			this.btnBilling.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBilling.ForeColor = System.Drawing.Color.Black;
			this.btnBilling.Location = new System.Drawing.Point(26, 358);
			this.btnBilling.Name = "btnBilling";
			this.btnBilling.Size = new System.Drawing.Size(196, 88);
			this.btnBilling.TabIndex = 10;
			this.btnBilling.Text = "Billing";
			this.btnBilling.UseVisualStyleBackColor = false;
			// 
			// btnDischarge
			// 
			this.btnDischarge.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDischarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDischarge.ForeColor = System.Drawing.Color.Black;
			this.btnDischarge.Location = new System.Drawing.Point(243, 358);
			this.btnDischarge.Name = "btnDischarge";
			this.btnDischarge.Size = new System.Drawing.Size(196, 88);
			this.btnDischarge.TabIndex = 11;
			this.btnDischarge.Text = "Discharge";
			this.btnDischarge.UseVisualStyleBackColor = false;
			// 
			// btnDischargeSummary
			// 
			this.btnDischargeSummary.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDischargeSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDischargeSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDischargeSummary.ForeColor = System.Drawing.Color.Black;
			this.btnDischargeSummary.Location = new System.Drawing.Point(461, 358);
			this.btnDischargeSummary.Name = "btnDischargeSummary";
			this.btnDischargeSummary.Size = new System.Drawing.Size(196, 88);
			this.btnDischargeSummary.TabIndex = 12;
			this.btnDischargeSummary.Text = "Discharge Summary";
			this.btnDischargeSummary.UseVisualStyleBackColor = false;
			// 
			// btnUserMgmt
			// 
			this.btnUserMgmt.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnUserMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUserMgmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUserMgmt.ForeColor = System.Drawing.Color.Black;
			this.btnUserMgmt.Location = new System.Drawing.Point(680, 358);
			this.btnUserMgmt.Name = "btnUserMgmt";
			this.btnUserMgmt.Size = new System.Drawing.Size(196, 88);
			this.btnUserMgmt.TabIndex = 13;
			this.btnUserMgmt.Text = "User Mgmt";
			this.btnUserMgmt.UseVisualStyleBackColor = false;
			// 
			// AdminMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 577);
			this.Controls.Add(this.btnUserMgmt);
			this.Controls.Add(this.btnDischargeSummary);
			this.Controls.Add(this.btnDischarge);
			this.Controls.Add(this.btnBilling);
			this.Controls.Add(this.btnDoctorAssign);
			this.Controls.Add(this.btnTreatmentBilling);
			this.Controls.Add(this.btnAdmissionLog);
			this.Controls.Add(this.btnAdmission);
			this.Controls.Add(this.btnRoomSearch);
			this.Controls.Add(this.btnPatientSearch);
			this.Controls.Add(this.btnPatientInfo);
			this.Controls.Add(this.btnRoomMgmt);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "AdminMenuForm";
			this.Text = "Main Menu";
			this.Load += new System.EventHandler(this.AdminMenuForm_Load_1);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.LinkLabel llblLogout;
        private System.Windows.Forms.Button btnRoomMgmt;
        private System.Windows.Forms.Button btnPatientInfo;
        private System.Windows.Forms.Button btnPatientSearch;
        private System.Windows.Forms.Button btnRoomSearch;
        private System.Windows.Forms.Button btnAdmission;
        private System.Windows.Forms.Button btnAdmissionLog;
        private System.Windows.Forms.Button btnTreatmentBilling;
        private System.Windows.Forms.Button btnDoctorAssign;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnDischarge;
        private System.Windows.Forms.Button btnDischargeSummary;
        private System.Windows.Forms.Button btnUserMgmt;
    }
}