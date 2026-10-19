namespace WinFormsApp1
{
    partial class ForgetPasswordForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ResetBtn = new Button();
            BackBtn = new Button();
            txtUsername = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblMessage = new Label();
            SuspendLayout();
            label1.AutoSize = true;
            label1.Location = new Point(24, 38);
            label1.Text = "Username";
            txtUsername.Name = "txtUsername";
            txtUsername.SetBounds(162, 34, 230, 23);
            txtUsername.MaxLength = 100;
            txtUsername.TabIndex = 0;
            label2.AutoSize = true;
            label2.Location = new Point(24, 88);
            label2.Text = "New password";
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.SetBounds(162, 84, 230, 23);
            txtNewPassword.UseSystemPasswordChar = true;
            txtNewPassword.TabIndex = 1;
            label3.AutoSize = true;
            label3.Location = new Point(24, 138);
            label3.Text = "Confirm password";
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.SetBounds(162, 134, 230, 23);
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.TabIndex = 2;
            lblMessage.Name = "lblMessage";
            lblMessage.SetBounds(24, 178, 368, 48);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Text = "Reset Password";
            ResetBtn.SetBounds(86, 238, 140, 38);
            ResetBtn.TabIndex = 3;
            ResetBtn.Click += ResetBtn_Click;
            BackBtn.Name = "BackBtn";
            BackBtn.Text = "Back";
            BackBtn.SetBounds(242, 238, 100, 38);
            BackBtn.TabIndex = 4;
            BackBtn.Click += BackBtn_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 305);
            Controls.AddRange(new Control[] { label1, txtUsername, label2, txtNewPassword, label3, txtConfirmPassword, lblMessage, ResetBtn, BackBtn });
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Name = "ForgetPasswordForm";
            Text = "Reset Password";
            ResumeLayout(false);
            PerformLayout();
        }
        private Button ResetBtn;
        private Button BackBtn;
        private TextBox txtUsername;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblMessage;
    }
}
