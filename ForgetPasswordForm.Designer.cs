namespace WinFormsApp1
{
    partial class ForgetPasswordForm
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
            ResetBtn = new Button();
            BackBtn = new Button();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(80, 200);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(100, 39);
            ResetBtn.TabIndex = 0;
            ResetBtn.Text = "Reset Password";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(200, 200);
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
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 70);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 120);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(30, 160);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 6;
            // 
            // ForgetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 270);
            Controls.Add(lblMessage);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(BackBtn);
            Controls.Add(ResetBtn);
            Name = "ForgetPasswordForm";
            Text = "Forget Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ResetBtn;
        private Button BackBtn;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label lblMessage;
    }
}
