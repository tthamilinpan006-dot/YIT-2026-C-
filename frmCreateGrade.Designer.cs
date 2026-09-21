namespace WinFormsApp1
{
    partial class frmCreateGrade
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
            btnCreate = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtGradeOrder = new TextBox();
            txtGradeGroup = new TextBox();
            txtGradeName = new TextBox();
            lblGradeName = new Label();
            colorDialog1 = new ColorDialog();
            btnChooseColour = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(109, 307);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(110, 38);
            btnCreate.TabIndex = 28;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 43);
            panel1.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(94, 7);
            label4.Name = "label4";
            label4.Size = new Size(143, 30);
            label4.TabIndex = 8;
            label4.Text = "Create Grade";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 241);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 36;
            label3.Text = "Grade Colour";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 178);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 35;
            label2.Text = "Grade Order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 118);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 34;
            label1.Text = "Grade Group";
            // 
            // txtGradeOrder
            // 
            txtGradeOrder.Location = new Point(24, 204);
            txtGradeOrder.Margin = new Padding(3, 2, 3, 2);
            txtGradeOrder.Name = "txtGradeOrder";
            txtGradeOrder.Size = new Size(298, 23);
            txtGradeOrder.TabIndex = 32;
            // 
            // txtGradeGroup
            // 
            txtGradeGroup.Location = new Point(23, 142);
            txtGradeGroup.Margin = new Padding(3, 2, 3, 2);
            txtGradeGroup.Name = "txtGradeGroup";
            txtGradeGroup.Size = new Size(298, 23);
            txtGradeGroup.TabIndex = 31;
            // 
            // txtGradeName
            // 
            txtGradeName.Location = new Point(23, 89);
            txtGradeName.Margin = new Padding(3, 2, 3, 2);
            txtGradeName.Name = "txtGradeName";
            txtGradeName.Size = new Size(298, 23);
            txtGradeName.TabIndex = 30;
            // 
            // lblGradeName
            // 
            lblGradeName.AutoSize = true;
            lblGradeName.Location = new Point(24, 64);
            lblGradeName.Name = "lblGradeName";
            lblGradeName.Size = new Size(73, 15);
            lblGradeName.TabIndex = 29;
            lblGradeName.Text = "Grade Name";
            // 
            // btnChooseColour
            // 
            btnChooseColour.Location = new Point(24, 263);
            btnChooseColour.Margin = new Padding(3, 2, 3, 2);
            btnChooseColour.Name = "btnChooseColour";
            btnChooseColour.Size = new Size(103, 32);
            btnChooseColour.TabIndex = 38;
            btnChooseColour.UseVisualStyleBackColor = true;
            btnChooseColour.Click += btnChooseColour_Click;
            // 
            // frmCreateGrade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(345, 349);
            Controls.Add(btnChooseColour);
            Controls.Add(btnCreate);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGradeOrder);
            Controls.Add(txtGradeGroup);
            Controls.Add(txtGradeName);
            Controls.Add(lblGradeName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCreateGrade";
            Text = "frmCreateGrade";
            Load += frmCreateGrade_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtGradeOrder;
        private TextBox txtGradeGroup;
        private TextBox txtGradeName;
        private Label lblGradeName;
        private ColorDialog colorDialog1;
        private Button btnChooseColour;
    }
}