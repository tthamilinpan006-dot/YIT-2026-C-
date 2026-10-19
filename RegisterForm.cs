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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || 
                    string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                {
                    lblMessage.Text = "Please fill all fields.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                if (username.Length < 3)
                {
                    lblMessage.Text = "Username must be at least 3 characters.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                if (password.Length < 6)
                {
                    lblMessage.Text = "Password must be at least 6 characters.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                if (password != confirmPassword)
                {
                    lblMessage.Text = "Passwords do not match.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                if (!email.Contains("@"))
                {
                    lblMessage.Text = "Please enter a valid email.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                lblMessage.Text = "Registration successful! You can now login.";
                lblMessage.ForeColor = System.Drawing.Color.Green;

                // Clear fields after successful registration
                txtUsername.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();

                // Close after 2 seconds
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
