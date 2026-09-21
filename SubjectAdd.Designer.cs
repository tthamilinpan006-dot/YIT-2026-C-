namespace WinFormsApp1
{
    partial class SubjectAdd
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtid = new TextBox();
            txtStuName = new TextBox();
            txtAddNo = new TextBox();
            lstSubjects = new ListBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 60);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Student Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 104);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 150);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 0;
            label3.Text = "Admission No";
            // 
            // txtid
            // 
            txtid.Location = new Point(140, 57);
            txtid.Name = "txtid";
            txtid.Size = new Size(199, 23);
            txtid.TabIndex = 1;
            // 
            // txtStuName
            // 
            txtStuName.Location = new Point(140, 104);
            txtStuName.Name = "txtStuName";
            txtStuName.Size = new Size(199, 23);
            txtStuName.TabIndex = 1;
            // 
            // txtAddNo
            // 
            txtAddNo.Location = new Point(140, 150);
            txtAddNo.Name = "txtAddNo";
            txtAddNo.Size = new Size(199, 23);
            txtAddNo.TabIndex = 1;
            // 
            // lstSubjects
            // 
            lstSubjects.FormattingEnabled = true;
            lstSubjects.ItemHeight = 15;
            lstSubjects.Location = new Point(28, 214);
            lstSubjects.Name = "lstSubjects";
            lstSubjects.Size = new Size(349, 394);
            lstSubjects.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(158, 627);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // SubjectAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 662);
            Controls.Add(btnSave);
            Controls.Add(lstSubjects);
            Controls.Add(txtAddNo);
            Controls.Add(txtStuName);
            Controls.Add(txtid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SubjectAdd";
            Text = "SubjectAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtid;
        private TextBox txtStuName;
        private TextBox txtAddNo;
        private ListBox lstSubjects;
        private Button btnSave;
    }
}