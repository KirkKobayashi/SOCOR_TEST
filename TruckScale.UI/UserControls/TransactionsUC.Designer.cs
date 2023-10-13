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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsUC));
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
            imageList1 = new ImageList(components);
            btnReport = new Button();
            btnPrint = new Button();
            btnNew = new Button();
            toolTip1 = new ToolTip(components);
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
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 360F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Controls.Add(dgvTransactions, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1787, 719);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvTransactions.BorderStyle = BorderStyle.None;
            dgvTransactions.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTransactions.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvTransactions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTransactions.ColumnHeadersHeight = 50;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tableLayoutPanel1.SetColumnSpan(dgvTransactions, 3);
            dgvTransactions.Dock = DockStyle.Fill;
            dgvTransactions.Location = new Point(9, 176);
            dgvTransactions.Margin = new Padding(9, 8, 9, 8);
            dgvTransactions.MultiSelect = false;
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersWidth = 62;
            dgvTransactions.RowTemplate.Height = 33;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(1769, 535);
            dgvTransactions.TabIndex = 0;
            dgvTransactions.CellMouseClick += dgvTransactions_CellMouseClick;
            dgvTransactions.CellMouseDoubleClick += dgvTransactions_CellMouseDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 37, 41);
            tableLayoutPanel1.SetColumnSpan(panel1, 3);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1781, 36);
            panel1.TabIndex = 1;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(248, 249, 250);
            label9.Location = new Point(785, 2);
            label9.Name = "label9";
            label9.Size = new Size(235, 32);
            label9.TabIndex = 1;
            label9.Text = "TRANSACTIONS LIST";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 294F));
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Controls.Add(dtStart, 1, 2);
            tableLayoutPanel2.Controls.Add(dtEnd, 1, 3);
            tableLayoutPanel2.Controls.Add(label1, 1, 1);
            tableLayoutPanel2.Location = new Point(3, 45);
            tableLayoutPanel2.Margin = new Padding(3, 3, 9, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.57143F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel2.Size = new Size(348, 120);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(9, 39);
            label2.Name = "label2";
            label2.Size = new Size(42, 34);
            label2.TabIndex = 1;
            label2.Text = "Start";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(15, 73);
            label3.Name = "label3";
            label3.Size = new Size(36, 34);
            label3.TabIndex = 2;
            label3.Text = "End";
            // 
            // dtStart
            // 
            dtStart.Location = new Point(57, 42);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(288, 29);
            dtStart.TabIndex = 3;
            dtStart.ValueChanged += btStart_ValueChanged;
            // 
            // dtEnd
            // 
            dtEnd.Location = new Point(57, 76);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(288, 29);
            dtEnd.TabIndex = 4;
            dtEnd.ValueChanged += dtEnd_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 5);
            label1.Name = "label1";
            label1.Size = new Size(196, 21);
            label1.TabIndex = 0;
            label1.Text = "Weighing Records Selector";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(369, 45);
            tableLayoutPanel3.Margin = new Padding(9, 3, 3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 28.57143F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel3.Size = new Size(1236, 120);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 6;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(btnDelete, 4, 2);
            tableLayoutPanel4.Controls.Add(btnReport, 2, 2);
            tableLayoutPanel4.Controls.Add(btnPrint, 1, 2);
            tableLayoutPanel4.Controls.Add(btnNew, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(21, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel3.SetRowSpan(tableLayoutPanel4, 5);
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.Size = new Size(1212, 114);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(55, 55, 55);
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.ImageIndex = 3;
            btnDelete.ImageList = imageList1;
            btnDelete.Location = new Point(458, 67);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 44);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnDelete, "Delete selected transaction");
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add.png");
            imageList1.Images.SetKeyName(1, "printing.png");
            imageList1.Images.SetKeyName(2, "report.png");
            imageList1.Images.SetKeyName(3, "minus.png");
            // 
            // btnReport
            // 
            btnReport.Dock = DockStyle.Fill;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.ForeColor = Color.FromArgb(55, 55, 55);
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.ImageIndex = 2;
            btnReport.ImageList = imageList1;
            btnReport.Location = new Point(273, 67);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(129, 44);
            btnReport.TabIndex = 1;
            btnReport.Text = "Report";
            btnReport.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnReport, "Generates a report based on displayed records");
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnPrint
            // 
            btnPrint.Dock = DockStyle.Fill;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.FromArgb(55, 55, 55);
            btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrint.ImageIndex = 1;
            btnPrint.ImageList = imageList1;
            btnPrint.Location = new Point(138, 67);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(129, 44);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print";
            btnPrint.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnPrint, "Print selected transaction");
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnNew
            // 
            btnNew.Dock = DockStyle.Fill;
            btnNew.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.FromArgb(55, 55, 55);
            btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnNew.ImageIndex = 0;
            btnNew.ImageList = imageList1;
            btnNew.Location = new Point(3, 67);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(129, 44);
            btnNew.TabIndex = 4;
            btnNew.Text = "Add New";
            btnNew.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnNew, "Create a new weighing transaction");
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // TransactionsUC
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "TransactionsUC";
            Size = new Size(1787, 719);
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
        private ImageList imageList1;
        private ToolTip toolTip1;
    }
}
