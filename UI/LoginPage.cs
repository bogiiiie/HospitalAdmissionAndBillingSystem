// ============================================================
// LoginPage.cs
// Purpose: Handles login button click and validation.
//          Design is in LoginPage.Designer.cs (untouched).
// ============================================================

using System;
using System.Windows.Forms;
using BusinessLogic.Controller;

namespace UI
{
	public partial class LoginPage : Form
	{
		public LoginPage()
		{
			InitializeComponent();
			txtPassword.PasswordChar = '●';
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text.Trim();
			string password = txtPassword.Text;

			LoginController controller = new LoginController();
			string result = controller.Login(username, password);

			if (result == "Admin")
			{
				AdminMenuForm adminMenu = new AdminMenuForm(this, username, "Admin");
				adminMenu.Show();
				this.Hide();
			}
			else if (result == "Hospital Staff")
			{
				HospitalStaffMenuForm staffMenu = new HospitalStaffMenuForm(this, username, "Hospital Staff");
				staffMenu.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show(result, "Login Failed",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPassword.Clear();
				txtPassword.Focus();
			}
		}

		// ------------------------------------------------------
		// Fires whenever the form becomes visible.
		// Clears the fields so the previous user's data doesn't
		// linger after logout.
		// ------------------------------------------------------
		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);

			if (this.Visible)
			{
				txtUsername.Clear();
				txtPassword.Clear();
				txtUsername.Focus();
			}
		}

		private void lblForgotPassword_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show(
						"Please contact your system administrator to reset your password.",
						"Forgot Password",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);
		}
	}
}