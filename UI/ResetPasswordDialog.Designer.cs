namespace UI
{
	partial class ResetPasswordDialog
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

		private void InitializeComponent()
		{
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblNewPass = new System.Windows.Forms.Label();
			this.txtNewPass = new System.Windows.Forms.TextBox();
			this.btnToggleNewPass = new System.Windows.Forms.Button();
			this.lblConfirmPass = new System.Windows.Forms.Label();
			this.txtConfirmPass = new System.Windows.Forms.TextBox();
			this.btnToggleConfirmPass = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(20, 20);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(300, 32);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Reset Password";
			// 
			// lblNewPass
			// 
			this.lblNewPass.AutoSize = true;
			this.lblNewPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblNewPass.Location = new System.Drawing.Point(20, 65);
			this.lblNewPass.Name = "lblNewPass";
			this.lblNewPass.Size = new System.Drawing.Size(150, 23);
			this.lblNewPass.TabIndex = 1;
			this.lblNewPass.Text = "New Password:";
			// 
			// txtNewPass
			// 
			this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtNewPass.Location = new System.Drawing.Point(20, 90);
			this.txtNewPass.Name = "txtNewPass";
			this.txtNewPass.Size = new System.Drawing.Size(300, 30);
			this.txtNewPass.TabIndex = 2;
			this.txtNewPass.UseSystemPasswordChar = true;
			// 
			// btnToggleNewPass
			// 
			this.btnToggleNewPass.BackColor = System.Drawing.Color.White;
			this.btnToggleNewPass.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnToggleNewPass.FlatAppearance.BorderSize = 0;
			this.btnToggleNewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnToggleNewPass.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F); // Increased to 12F
			this.btnToggleNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			this.btnToggleNewPass.Location = new System.Drawing.Point(294, 92); // Moved left and up
			this.btnToggleNewPass.Name = "btnToggleNewPass";
			this.btnToggleNewPass.Size = new System.Drawing.Size(24, 22);
			this.btnToggleNewPass.TabIndex = 7;
			this.btnToggleNewPass.TabStop = false;
			this.btnToggleNewPass.Text = "\uE890";
			this.btnToggleNewPass.UseVisualStyleBackColor = false;
			this.btnToggleNewPass.Click += new System.EventHandler(this.btnToggleNewPass_Click);
			// 
			// lblConfirmPass
			// 
			this.lblConfirmPass.AutoSize = true;
			this.lblConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblConfirmPass.Location = new System.Drawing.Point(20, 130);
			this.lblConfirmPass.Name = "lblConfirmPass";
			this.lblConfirmPass.Size = new System.Drawing.Size(180, 23);
			this.lblConfirmPass.TabIndex = 3;
			this.lblConfirmPass.Text = "Confirm Password:";
			// 
			// txtConfirmPass
			// 
			this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtConfirmPass.Location = new System.Drawing.Point(20, 155);
			this.txtConfirmPass.Name = "txtConfirmPass";
			this.txtConfirmPass.Size = new System.Drawing.Size(300, 30);
			this.txtConfirmPass.TabIndex = 4;
			this.txtConfirmPass.UseSystemPasswordChar = true;
			// 
			// btnToggleConfirmPass
			// 
			this.btnToggleConfirmPass.BackColor = System.Drawing.Color.White;
			this.btnToggleConfirmPass.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnToggleConfirmPass.FlatAppearance.BorderSize = 0;
			this.btnToggleConfirmPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnToggleConfirmPass.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F); // Increased to 12F
			this.btnToggleConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
			this.btnToggleConfirmPass.Location = new System.Drawing.Point(294, 157); // Moved left and up
			this.btnToggleConfirmPass.Name = "btnToggleConfirmPass";
			this.btnToggleConfirmPass.Size = new System.Drawing.Size(24, 22);
			this.btnToggleConfirmPass.TabIndex = 8;
			this.btnToggleConfirmPass.TabStop = false;
			this.btnToggleConfirmPass.Text = "\uE890";
			this.btnToggleConfirmPass.UseVisualStyleBackColor = false;
			this.btnToggleConfirmPass.Click += new System.EventHandler(this.btnToggleConfirmPass_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(20, 210);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(140, 40);
			this.btnSave.TabIndex = 5;
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
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.btnCancel.Location = new System.Drawing.Point(180, 210);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(140, 40);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// ResetPasswordDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(350, 280);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnToggleConfirmPass);
			this.Controls.Add(this.txtConfirmPass);
			this.Controls.Add(this.lblConfirmPass);
			this.Controls.Add(this.btnToggleNewPass);
			this.Controls.Add(this.txtNewPass);
			this.Controls.Add(this.lblNewPass);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ResetPasswordDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Reset Password";
			this.ResumeLayout(false);
			this.PerformLayout();
			this.btnToggleNewPass.BringToFront();
			this.btnToggleConfirmPass.BringToFront();
		}

		private System.Windows.Forms.Label lblTitle, lblNewPass, lblConfirmPass;
		private System.Windows.Forms.TextBox txtNewPass, txtConfirmPass;
		private System.Windows.Forms.Button btnToggleNewPass, btnToggleConfirmPass;
		private System.Windows.Forms.Button btnSave, btnCancel;
	}
}