namespace TruckScale.UI.Forms
{
    partial class WeigherManagementForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtUsername = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtConfirm = new TextBox();
            btnSave = new Button();
            btnExit = new Button();
            label5 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.37484F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.71855F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9066067F));
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(txtUsername, 1, 1);
            tableLayoutPanel1.Controls.Add(txtFirstName, 1, 2);
            tableLayoutPanel1.Controls.Add(txtLastName, 1, 3);
            tableLayoutPanel1.Controls.Add(txtConfirm, 1, 5);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 7);
            tableLayoutPanel1.Controls.Add(btnExit, 0, 8);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 4);
            tableLayoutPanel1.Location = new Point(9, 38);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(312, 268);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(55, 13);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 40);
            label3.Name = "label3";
            label3.Size = new Size(57, 13);
            label3.TabIndex = 1;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 70);
            label4.Name = "label4";
            label4.Size = new Size(58, 13);
            label4.TabIndex = 2;
            label4.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 130);
            label6.Name = "label6";
            label6.Size = new Size(91, 13);
            label6.TabIndex = 4;
            label6.Text = "Confirm Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(107, 13);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(124, 20);
            txtUsername.TabIndex = 1;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(107, 43);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(124, 20);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(107, 73);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(124, 20);
            txtLastName.TabIndex = 3;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(107, 133);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(124, 20);
            txtConfirm.TabIndex = 5;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(3, 178);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(74, 34);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(3, 218);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(74, 34);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 100);
            label5.Name = "label5";
            label5.Size = new Size(53, 13);
            label5.TabIndex = 13;
            label5.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(107, 103);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(124, 20);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(124, 13);
            label1.TabIndex = 1;
            label1.Text = "Weigher Management";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 136, 197);
            panel1.Location = new Point(9, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 2);
            panel1.TabIndex = 2;
            // 
            // WeigherManagementForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(329, 316);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WeigherManagementForm";
            Text = "WeigherManagementForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label6;
        private TextBox txtUsername;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtConfirm;
        private Button btnSave;
        private Button btnExit;
        private Label label5;
        private TextBox txtPassword;
        private Panel panel1;
    }
}