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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            tableLayoutPanel4 = new TableLayoutPanel();
            btnDelete = new Button();
            btnReport = new Button();
            btnPrint = new Button();
            btnNew = new Button();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.Controls.Add(dgvTransactions, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(1, 2, 1, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1986, 857);
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTransactions.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTransactions.Dock = DockStyle.Fill;
            dgvTransactions.Location = new Point(10, 210);
            dgvTransactions.Margin = new Padding(10);
            dgvTransactions.MultiSelect = false;
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersWidth = 62;
            dgvTransactions.RowTemplate.Height = 33;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(1966, 637);
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
            label9.Location = new Point(873, 7);
            label9.Name = "label9";
            label9.Size = new Size(235, 32);
            label9.TabIndex = 1;
            label9.Text = "TRANSACTIONS LIST";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 227F));
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Controls.Add(dtStart, 1, 2);
            tableLayoutPanel2.Controls.Add(dtEnd, 1, 3);
            tableLayoutPanel2.Controls.Add(label1, 1, 1);
            tableLayoutPanel2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel2.Location = new Point(1689, 53);
            tableLayoutPanel2.Margin = new Padding(3, 3, 10, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.57143F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel2.Size = new Size(287, 143);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(15, 46);
            label2.Name = "label2";
            label2.Size = new Size(42, 40);
            label2.TabIndex = 1;
            label2.Text = "Start";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(21, 86);
            label3.Name = "label3";
            label3.Size = new Size(36, 40);
            label3.TabIndex = 2;
            label3.Text = "End";
            // 
            // dtStart
            // 
            dtStart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtStart.Format = DateTimePickerFormat.Short;
            dtStart.Location = new Point(63, 49);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(221, 29);
            dtStart.TabIndex = 3;
            dtStart.ValueChanged += btStart_ValueChanged;
            // 
            // dtEnd
            // 
            dtEnd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtEnd.Format = DateTimePickerFormat.Short;
            dtEnd.Location = new Point(63, 89);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(221, 29);
            dtEnd.TabIndex = 4;
            dtEnd.ValueChanged += dtEnd_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 6);
            label1.Name = "label1";
            label1.Size = new Size(196, 21);
            label1.TabIndex = 0;
            label1.Text = "Weighing Records Selector";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
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
            tableLayoutPanel3.Size = new Size(1673, 144);
            tableLayoutPanel3.TabIndex = 3;
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
            tableLayoutPanel4.Controls.Add(btnDelete, 4, 0);
            tableLayoutPanel4.Controls.Add(btnReport, 2, 0);
            tableLayoutPanel4.Controls.Add(btnPrint, 1, 0);
            tableLayoutPanel4.Controls.Add(btnNew, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(23, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel3.SetRowSpan(tableLayoutPanel4, 5);
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1647, 138);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(56, 56, 56);
            btnDelete.Location = new Point(603, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 94);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReport
            // 
            btnReport.Dock = DockStyle.Fill;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnReport.ForeColor = Color.FromArgb(56, 56, 56);
            btnReport.Location = new Point(303, 3);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(144, 94);
            btnReport.TabIndex = 1;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnPrint
            // 
            btnPrint.Dock = DockStyle.Fill;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.FromArgb(56, 56, 56);
            btnPrint.Location = new Point(153, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(144, 94);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnNew
            // 
            btnNew.Dock = DockStyle.Fill;
            btnNew.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnNew.ForeColor = Color.FromArgb(56, 56, 56);
            btnNew.Location = new Point(3, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(144, 94);
            btnNew.TabIndex = 4;
            btnNew.Text = "Add New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // TransactionsUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TransactionsUC";
            Size = new Size(1986, 857);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnDelete;
        private Button btnReport;
        private Button btnPrint;
        private Button btnNew;
    }
}
