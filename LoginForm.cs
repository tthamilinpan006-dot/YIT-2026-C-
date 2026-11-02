using WinFormsApp1.DAL;

namespace WinFormsApp1;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
        txtPassword.UseSystemPasswordChar = true;
        lblMessage.Visible = true;
        lblMessage.AutoSize = false;
        AcceptButton = Loginbtn;
    }

    private void textBox2_TextChanged(object sender, EventArgs e) { }
    private void regbtn_Click(object sender, EventArgs e)
    {
        using var form = new RegisterForm();
        form.ShowDialog(this);
    }
    private void forgetbtn_Click(object sender, EventArgs e)
    {
        using var form = new ForgetPasswordForm();
        form.ShowDialog(this);
    }
    private async void Loginbtn_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text;
        lblMessage.ForeColor = Color.Red;
        if (username.Length == 0 || password.Length == 0)
        {
            lblMessage.Text = "Please enter both username and password.";
            return;
        }
        Loginbtn.Enabled = regbtn.Enabled = forgetbtn.Enabled = false;
        try
        {
            bool valid = await UserAuth.LoginAsync(username, password);
            if (IsDisposed) return;
            lblMessage.Text = valid ? "Login successful!" : "Invalid username or password.";
            lblMessage.ForeColor = valid ? Color.Green : Color.Red;
            txtPassword.Clear();
            if (valid)
            {
                var mainForm = new databaseconnect();
                mainForm.FormClosed += (_, _) => Close();
                mainForm.Show();
                Hide();
            }
        }
        catch (Exception)
        {
            if (!IsDisposed) lblMessage.Text = "Login failed. Check the database connection and setup.";
        }
        finally
        {
            if (!IsDisposed) Loginbtn.Enabled = regbtn.Enabled = forgetbtn.Enabled = true;
        }
    }
}



