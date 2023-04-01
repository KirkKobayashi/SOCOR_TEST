namespace TruckScale.UI.UserControls
{
    partial class WeigherUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label9 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnClear = new Button();
            btnSave = new Button();
            btnSearch = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 37, 41);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 50);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.Controls.Add(label9, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1077, 50);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(248, 249, 250);
            label9.Location = new Point(362, 0);
            label9.Name = "label9";
            label9.Size = new Size(353, 50);
            label9.TabIndex = 2;
            label9.Text = "WEIGHER MANAGEMENT";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label5, 1, 7);
            tableLayoutPanel1.Controls.Add(label4, 1, 6);
            tableLayoutPanel1.Controls.Add(label3, 1, 4);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(txtFirstName, 2, 1);
            tableLayoutPanel1.Controls.Add(txtLastName, 2, 2);
            tableLayoutPanel1.Controls.Add(txtUserName, 2, 4);
            tableLayoutPanel1.Controls.Add(txtPassword, 2, 6);
            tableLayoutPanel1.Controls.Add(txtConfirmPassword, 2, 7);
            tableLayoutPanel1.Controls.Add(btnClear, 3, 8);
            tableLayoutPanel1.Controls.Add(btnSave, 4, 8);
            tableLayoutPanel1.Controls.Add(btnSearch, 2, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1077, 752);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(191, 305);
            label5.Name = "label5";
            label5.Size = new Size(194, 40);
            label5.TabIndex = 9;
            label5.Text = "Confirm Password";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(191, 265);
            label4.Name = "label4";
            label4.Size = new Size(194, 40);
            label4.TabIndex = 8;
            label4.Text = "Password";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(191, 185);
            label3.Name = "label3";
            label3.Size = new Size(194, 40);
            label3.TabIndex = 7;
            label3.Text = "User Name";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(191, 120);
            label2.Name = "label2";
            label2.Size = new Size(194, 40);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(191, 80);
            label1.Name = "label1";
            label1.Size = new Size(194, 40);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            tableLayoutPanel1.SetColumnSpan(txtFirstName, 3);
            txtFirstName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtFirstName.Location = new Point(391, 83);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(494, 31);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            tableLayoutPanel1.SetColumnSpan(txtLastName, 3);
            txtLastName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtLastName.Location = new Point(391, 123);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(494, 31);
            txtLastName.TabIndex = 3;
            // 
            // txtUserName
            // 
            tableLayoutPanel1.SetColumnSpan(txtUserName, 2);
            txtUserName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.Location = new Point(391, 188);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(194, 31);
            txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            tableLayoutPanel1.SetColumnSpan(txtPassword, 3);
            txtPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(391, 268);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(494, 31);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            tableLayoutPanel1.SetColumnSpan(txtConfirmPassword, 3);
            txtConfirmPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtConfirmPassword.Location = new Point(391, 308);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(494, 31);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(33, 37, 41);
            btnClear.Dock = DockStyle.Fill;
            btnClear.ForeColor = Color.FromArgb(248, 249, 250);
            btnClear.Location = new Point(591, 348);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 54);
            btnClear.TabIndex = 10;
            btnClear.Text = "Close";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(2, 62, 138);
            btnSave.Dock = DockStyle.Fill;
            btnSave.ForeColor = Color.FromArgb(248, 249, 250);
            btnSave.Location = new Point(691, 348);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(194, 54);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(391, 228);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(194, 34);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Check Name";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // WeigherUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "WeigherUC";
            Size = new Size(1077, 802);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnClear;
        private Button btnSave;
        private Button btnSearch;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
