using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ForgetPasswordForm : Form
    {
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string username = txtUsername.Text.Trim();

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username))
                {
                    lblMessage.Text = "Please enter both username and email.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                if (!email.Contains("@"))
                {
                    lblMessage.Text = "Please enter a valid email.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                lblMessage.Text = "Password reset link sent to your email!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                txtUsername.Clear();
                txtEmail.Clear();
                Task.Delay(2000).ContinueWith(t => this.Close());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
