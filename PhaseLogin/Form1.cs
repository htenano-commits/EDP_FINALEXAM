using System;
using System.Windows.Forms;

namespace PhaseLogin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();

            if (!string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show($"Login Successful!\n\nWelcome, {username}!",
                               "Success",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a username to login.",
                               "Input Required",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
        }

        // Add these two methods to remove the errors
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }
    }
}