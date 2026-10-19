using WinFormsApp1.DAL;

namespace WinFormsApp1;

public partial class RegisterForm : Form
{
    public RegisterForm()
    {
        InitializeComponent();
        txtEmail.Visible = label2.Visible = false;
        txtUsername.MaxLength = 100;
        txtPassword.UseSystemPasswordChar = txtConfirmPassword.UseSystemPasswordChar = true;
        label4.Text = "Confirm";
        lblMessage.Visible = true;
        lblMessage.AutoSize = false;
        lblMessage.SetBounds(20, 225, 345, 50);
        AcceptButton = Registerbtn;
    }
    private async void Registerbtn_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text;
        lblMessage.ForeColor = Color.Red;
        if (username.Length < 3 || username.Length > 100)
        {
            lblMessage.Text = "Username must contain 3 to 100 characters.";
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
        Registerbtn.Enabled = false;
        try
        {
            bool created = await UserAuth.RegisterAsync(username, password);
            if (IsDisposed) return;
            lblMessage.Text = created ? "Registration successful! You can now login." : "Username already exists. Choose another.";
            lblMessage.ForeColor = created ? Color.Green : Color.Red;
            if (created)
            {
                txtUsername.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();
            }
        }
        catch (Exception)
        {
            if (!IsDisposed) lblMessage.Text = "Registration failed. Check the database connection and setup.";
        }
        finally { if (!IsDisposed) Registerbtn.Enabled = true; }
    }
    private void BackBtn_Click(object sender, EventArgs e) => Close();
}
