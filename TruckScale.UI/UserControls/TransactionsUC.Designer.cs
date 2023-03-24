namespace TruckScale.UI.UserControls
{
    partial class TransactionsUC
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
            dgvTransactions = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Supplier = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label9 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            dtStart = new DateTimePicker();
            dtEnd = new DateTimePicker();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            txtSearchBox = new TextBox();
            cboSearchFilter = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvTransactions, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1270, 856);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Supplier, Column4, Column5, Column6 });
            tableLayoutPanel1.SetColumnSpan(dgvTransactions, 2);
            dgvTransactions.Dock = DockStyle.Fill;
            dgvTransactions.Location = new Point(10, 260);
            dgvTransactions.Margin = new Padding(10);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 62;
            dgvTransactions.RowTemplate.Height = 33;
            dgvTransactions.Size = new Size(1250, 586);
            dgvTransactions.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Plate Number";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Customer";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Supplier
            // 
            Supplier.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Supplier.HeaderText = "Supplier";
            Supplier.MinimumWidth = 8;
            Supplier.Name = "Supplier";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Product";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column5.HeaderText = "First Weight";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 142;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column6.HeaderText = "Second Weight";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 154;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 37, 41);
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 44);
            panel1.TabIndex = 1;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(248, 249, 250);
            label9.Location = new Point(515, 6);
            label9.Name = "label9";
            label9.Size = new Size(235, 32);
            label9.TabIndex = 1;
            label9.Text = "TRANSACTIONS LIST";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.47059F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.52941F));
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Controls.Add(dtStart, 1, 2);
            tableLayoutPanel2.Controls.Add(dtEnd, 1, 3);
            tableLayoutPanel2.Controls.Add(label1, 1, 1);
            tableLayoutPanel2.Location = new Point(638, 53);
            tableLayoutPanel2.Margin = new Padding(3, 3, 10, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.57143F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel2.Size = new Size(622, 194);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(113, 61);
            label2.Name = "label2";
            label2.Size = new Size(48, 40);
            label2.TabIndex = 1;
            label2.Text = "Start";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(119, 101);
            label3.Name = "label3";
            label3.Size = new Size(42, 40);
            label3.TabIndex = 2;
            label3.Text = "End";
            // 
            // dtStart
            // 
            dtStart.Location = new Point(167, 64);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(340, 31);
            dtStart.TabIndex = 3;
            dtStart.ValueChanged += btStart_ValueChanged;
            // 
            // dtEnd
            // 
            dtEnd.Location = new Point(167, 104);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(340, 31);
            dtEnd.TabIndex = 4;
            dtEnd.ValueChanged += dtEnd_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 21);
            label1.Name = "label1";
            label1.Size = new Size(223, 25);
            label1.TabIndex = 0;
            label1.Text = "Weighing Records Selector";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label4, 1, 1);
            tableLayoutPanel3.Controls.Add(txtSearchBox, 1, 3);
            tableLayoutPanel3.Controls.Add(cboSearchFilter, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(10, 53);
            tableLayoutPanel3.Margin = new Padding(10, 3, 3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 28.57143F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel3.Size = new Size(622, 194);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Location = new Point(23, 21);
            label4.Name = "label4";
            label4.Size = new Size(64, 40);
            label4.TabIndex = 1;
            label4.Text = "Search";
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new Point(23, 104);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(364, 31);
            txtSearchBox.TabIndex = 3;
            // 
            // cboSearchFilter
            // 
            cboSearchFilter.FormattingEnabled = true;
            cboSearchFilter.Items.AddRange(new object[] { "Plate Number", "Customer", "Supplier", "Product" });
            cboSearchFilter.Location = new Point(23, 64);
            cboSearchFilter.Name = "cboSearchFilter";
            cboSearchFilter.Size = new Size(364, 33);
            cboSearchFilter.TabIndex = 2;
            // 
            // TransactionsUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TransactionsUC";
            Size = new Size(1270, 856);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvTransactions;
        private Panel panel1;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtStart;
        private DateTimePicker dtEnd;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private TextBox txtSearchBox;
        private ComboBox cboSearchFilter;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Supplier;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
