using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class HospitalStaffMenuForm : Form
    {
        private LoginPage _loginPage;
        private string _username;
        private string _role;

        public HospitalStaffMenuForm()
        {
            InitializeComponent();
        }

        public HospitalStaffMenuForm(LoginPage loginPage, string username, string role) : this()
        {
            _loginPage = loginPage;
            _username = username;
            _role = role;
        }

        private void HospitalStaffMenuForm_Load_1(object sender, EventArgs e)
        {

            if (lblUserInfo != null)
            {
                lblUserInfo.Text = $"Logged in as: {_username} | Role: {_role}";
            }
        }

        private void llblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_loginPage != null)
            {
                _loginPage.Show();
            }
            this.Close();
        }

		private void btnRoomMgmt_Click(object sender, EventArgs e)
		{
			RoomManagementForm roomForm = new RoomManagementForm(_loginPage, _username, _role);
			roomForm.Show();
			this.Hide();
		}
	}
}