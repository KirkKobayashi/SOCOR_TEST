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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvTransactions = new DataGridView();
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
            tableLayoutPanel4 = new TableLayoutPanel();
            btnDelete = new Button();
            btnReport = new Button();
            btnPrint = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
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
            tableLayoutPanel1.Size = new Size(1986, 856);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransactions.BorderStyle = BorderStyle.None;
            dgvTransactions.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTransactions.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvTransactions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTransactions.ColumnHeadersHeight = 50;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tableLayoutPanel1.SetColumnSpan(dgvTransactions, 2);
            dgvTransactions.Dock = DockStyle.Fill;
            dgvTransactions.Location = new Point(10, 260);
            dgvTransactions.Margin = new Padding(10);
            dgvTransactions.MultiSelect = false;
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersWidth = 62;
            dgvTransactions.RowTemplate.Height = 33;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(1966, 586);
            dgvTransactions.TabIndex = 0;
            dgvTransactions.CellMouseClick += dgvTransactions_CellMouseClick;
            dgvTransactions.CellMouseDoubleClick += dgvTransactions_CellMouseDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 37, 41);
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1980, 44);
            panel1.TabIndex = 1;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(248, 249, 250);
            label9.Location = new Point(873, 6);
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
            tableLayoutPanel2.Location = new Point(1393, 53);
            tableLayoutPanel2.Margin = new Padding(3, 3, 10, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.57143F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel2.Size = new Size(583, 194);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(103, 61);
            label2.Name = "label2";
            label2.Size = new Size(48, 40);
            label2.TabIndex = 1;
            label2.Text = "Start";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(109, 101);
            label3.Name = "label3";
            label3.Size = new Size(42, 40);
            label3.TabIndex = 2;
            label3.Text = "End";
            // 
            // dtStart
            // 
            dtStart.Location = new Point(157, 64);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(340, 31);
            dtStart.TabIndex = 3;
            dtStart.ValueChanged += btStart_ValueChanged;
            // 
            // dtEnd
            // 
            dtEnd.Location = new Point(157, 104);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(340, 31);
            dtEnd.TabIndex = 4;
            dtEnd.ValueChanged += dtEnd_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 21);
            label1.Name = "label1";
            label1.Size = new Size(223, 25);
            label1.TabIndex = 0;
            label1.Text = "Weighing Records Selector";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.9583321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.0416679F));
            tableLayoutPanel3.Controls.Add(label4, 2, 1);
            tableLayoutPanel3.Controls.Add(txtSearchBox, 2, 3);
            tableLayoutPanel3.Controls.Add(cboSearchFilter, 2, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
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
            tableLayoutPanel3.Size = new Size(1377, 194);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(890, 21);
            label4.Name = "label4";
            label4.Size = new Size(484, 40);
            label4.TabIndex = 1;
            label4.Text = "Search";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Dock = DockStyle.Right;
            txtSearchBox.Location = new Point(1010, 104);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(364, 31);
            txtSearchBox.TabIndex = 3;
            // 
            // cboSearchFilter
            // 
            cboSearchFilter.Dock = DockStyle.Right;
            cboSearchFilter.FormattingEnabled = true;
            cboSearchFilter.Items.AddRange(new object[] { "Plate Number", "Customer", "Supplier", "Product" });
            cboSearchFilter.Location = new Point(1010, 64);
            cboSearchFilter.Name = "cboSearchFilter";
            cboSearchFilter.Size = new Size(364, 33);
            cboSearchFilter.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 6;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(btnDelete, 3, 0);
            tableLayoutPanel4.Controls.Add(btnReport, 1, 0);
            tableLayoutPanel4.Controls.Add(btnPrint, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(23, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel3.SetRowSpan(tableLayoutPanel4, 5);
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(861, 188);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(453, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 54);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReport
            // 
            btnReport.Dock = DockStyle.Fill;
            btnReport.Location = new Point(153, 3);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(144, 54);
            btnReport.TabIndex = 1;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnPrint
            // 
            btnPrint.Dock = DockStyle.Fill;
            btnPrint.Location = new Point(3, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(144, 54);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // TransactionsUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TransactionsUC";
            Size = new Size(1986, 856);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnDelete;
        private Button btnReport;
        private Button btnPrint;
    }
}
