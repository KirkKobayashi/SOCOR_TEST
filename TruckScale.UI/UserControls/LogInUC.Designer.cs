﻿namespace TruckScale.UI.UserControls
{
    partial class LogInUC
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogIn = new Button();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.6354F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.7291965F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.6354027F));
            tableLayoutPanel1.Controls.Add(label2, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(txtUserName, 1, 2);
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 4);
            tableLayoutPanel1.Controls.Add(btnLogIn, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(1581, 1029);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(582, 239);
            label2.Name = "label2";
            label2.Size = new Size(416, 45);
            label2.TabIndex = 4;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(582, 149);
            label1.Name = "label1";
            label1.Size = new Size(416, 45);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtUserName
            // 
            txtUserName.Dock = DockStyle.Fill;
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(582, 197);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(416, 39);
            txtUserName.TabIndex = 2;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(582, 287);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(416, 39);
            txtPassword.TabIndex = 3;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            btnLogIn.Dock = DockStyle.Fill;
            btnLogIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.Location = new Point(582, 339);
            btnLogIn.Margin = new Padding(3, 10, 3, 3);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(416, 87);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 37, 41);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1581, 50);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1581, 50);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(530, 0);
            label3.Name = "label3";
            label3.Size = new Size(521, 50);
            label3.TabIndex = 0;
            label3.Text = "User Log In";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogInUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "LogInUC";
            Size = new Size(1581, 1079);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogIn;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
