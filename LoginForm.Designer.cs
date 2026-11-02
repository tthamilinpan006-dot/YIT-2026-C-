namespace WinFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Loginbtn = new Button();
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            forgetbtn = new Button();
            regbtn = new Button();
            lblMessage = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Loginbtn
            // 
            Loginbtn.Location = new Point(114, 313);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(120, 39);
            Loginbtn.TabIndex = 0;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = true;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(151, 109);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 23);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 95);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 111);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 3;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 175);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(151, 173);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 23);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // forgetbtn
            // 
            forgetbtn.Location = new Point(213, 254);
            forgetbtn.Name = "forgetbtn";
            forgetbtn.Size = new Size(119, 23);
            forgetbtn.TabIndex = 5;
            forgetbtn.Text = "Forget-Password";
            forgetbtn.UseVisualStyleBackColor = true;
            forgetbtn.Click += forgetbtn_Click;
            // 
            // regbtn
            // 
            regbtn.Location = new Point(43, 254);
            regbtn.Name = "regbtn";
            regbtn.Size = new Size(75, 23);
            regbtn.TabIndex = 6;
            regbtn.Text = "Register";
            regbtn.UseVisualStyleBackColor = true;
            regbtn.Click += regbtn_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = false;
            lblMessage.Location = new Point(20, 207);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(345, 38);
            lblMessage.TabIndex = 7;
            lblMessage.Visible = true;
            // 
            // label4
            // 
            label4.BackColor = Color.Red;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Honeydew;
            label4.Location = new Point(-2, -2);
            label4.Name = "label4";
            label4.Size = new Size(390, 39);
            label4.TabIndex = 8;
            label4.Text = "                     Login Page";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 407);
            Controls.Add(label4);
            Controls.Add(lblMessage);
            Controls.Add(regbtn);
            Controls.Add(forgetbtn);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(Loginbtn);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Loginbtn;
        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private Button forgetbtn;
        private Button regbtn;
        private Label lblMessage;
        private Label label4;
    }
}
