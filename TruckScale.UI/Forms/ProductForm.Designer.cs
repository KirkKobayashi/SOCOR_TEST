namespace TruckScale.UI.Forms
{
    partial class ProductForm
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
            btnExit = new Button();
            btnSave = new Button();
            label3 = new Label();
            listBox = new ListBox();
            txtName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 370);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 18;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(11, 341);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(102, 13);
            label3.TabIndex = 16;
            label3.Text = "Products Record";
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(12, 110);
            listBox.Name = "listBox";
            listBox.Size = new Size(324, 225);
            listBox.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(77, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 20);
            txtName.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(35, 13);
            label2.TabIndex = 13;
            label2.Text = "Name";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(63, 136, 197);
            panel1.Location = new Point(11, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 2);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 11;
            label1.Text = "Product Management";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(348, 404);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(listBox);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductForm";
            Text = "ProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnSave;
        private Label label3;
        private ListBox listBox;
        private TextBox txtName;
        private Label label2;
        private Panel panel1;
        private Label label1;
    }
}