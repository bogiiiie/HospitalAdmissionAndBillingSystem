using System;
using System.Windows.Forms;
using BusinessLogic.Controller;

namespace UI
{
	public partial class ResetPasswordDialog : Form
	{
		private readonly UserController controller = new UserController();
		private readonly string _username;

		public ResetPasswordDialog(string username)
		{
			InitializeComponent();
			_username = username;
			lblTitle.Text = "Reset Password for: " + _username;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (txtNewPass.Text != txtConfirmPass.Text)
			{
				MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string result = controller.ResetPassword(_username, txtNewPass.Text);
			if (result == "OK")
			{
				MessageBox.Show("Password reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}