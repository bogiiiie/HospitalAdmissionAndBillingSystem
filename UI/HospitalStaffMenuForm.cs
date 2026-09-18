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

        private void HospitalStaffMenuForm_Load(object sender, EventArgs e)
        {
            if (lblUserInfo != null)
            {
                lblUserInfo.Text = $"Logged in as: {_username} | Role: {_role}";
            }
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PerformLogout();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            PerformLogout();
        }

        private void PerformLogout()
        {
            if (_loginPage != null)
            {
                _loginPage.Show();
            }
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing && _loginPage != null && !_loginPage.Visible)
            {
                _loginPage.Show();
            }
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
    }
}