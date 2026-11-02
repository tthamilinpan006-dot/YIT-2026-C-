namespace WinFormsApp1
{
    partial class RegisterForm
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
            Registerbtn = new Button();
            BackBtn = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // Registerbtn
            // 
            Registerbtn.Location = new Point(80, 280);
            Registerbtn.Name = "Registerbtn";
            Registerbtn.Size = new Size(100, 39);
            Registerbtn.TabIndex = 0;
            Registerbtn.Text = "Register";
            Registerbtn.UseVisualStyleBackColor = true;
            Registerbtn.Click += Registerbtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(200, 280);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(100, 39);
            BackBtn.TabIndex = 1;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(150, 70);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(150, 190);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(200, 23);
            txtConfirmPassword.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 70);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 150);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 190);
            label4.Name = "label4";
            label4.Size = new Size(148, 21);
            label4.TabIndex = 9;
            label4.Text = "Confirm Password";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(30, 240);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 10;
            lblMessage.Visible = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 346);
            Controls.Add(lblMessage);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(BackBtn);
            Controls.Add(Registerbtn);
            Name = "RegisterForm";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Registerbtn;
        private Button BackBtn;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label lblMessage;
    }
}
