using WinFormsApp1.DAL;

namespace WinFormsApp1;

public partial class ForgetPasswordForm : Form
{
    public ForgetPasswordForm()
    {
        InitializeComponent();
        AcceptButton = ResetBtn;
    }

    private async void ResetBtn_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();
        string password = txtNewPassword.Text;
        lblMessage.ForeColor = Color.Red;
        if (username.Length == 0)
        {
            lblMessage.Text = "Please enter your username.";
            return;
        }
        if (password.Length < 8)
        {
            lblMessage.Text = "Password must contain at least 8 characters.";
            return;
        }
        if (password != txtConfirmPassword.Text)
        {
            lblMessage.Text = "Passwords do not match.";
            return;
        }
        ResetBtn.Enabled = false;
        try
        {
            bool changed = await UserAuth.ResetPasswordAsync(username, password);
            if (IsDisposed) return;
            lblMessage.Text = changed ? "Password updated. Login with your new password." : "Username not found.";
            lblMessage.ForeColor = changed ? Color.Green : Color.Red;
            if (changed)
            {
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
            }
        }
        catch (Exception)
        {
            if (!IsDisposed) lblMessage.Text = "Reset failed. Check the database connection.";
        }
        finally { if (!IsDisposed) ResetBtn.Enabled = true; }
    }

    private void BackBtn_Click(object sender, EventArgs e) => Close();
}
