namespace TruckScale.UI.Forms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuLogIn = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.IndicatorPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tPanelMain.SuspendLayout();
            this.tPanelTop.SuspendLayout();
            this.IndicatorPanel.SuspendLayout();
            this.tbPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuLogIn,
            this.logOutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // stripMenuLogIn
            // 
            this.stripMenuLogIn.Name = "stripMenuLogIn";
            this.stripMenuLogIn.Size = new System.Drawing.Size(270, 34);
            this.stripMenuLogIn.Text = "Log In";
            this.stripMenuLogIn.Click += new System.EventHandler(this.stripMenuLogIn_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuUser});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // toolMenuUser
            // 
            this.toolMenuUser.Name = "toolMenuUser";
            this.toolMenuUser.Size = new System.Drawing.Size(149, 34);
            this.toolMenuUser.Text = "User";
            this.toolMenuUser.Click += new System.EventHandler(this.toolMenuUser_Click);
            // 
            // tPanelMain
            // 
            this.tPanelMain.ColumnCount = 3;
            this.tPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tPanelMain.Controls.Add(this.tPanelTop, 1, 0);
            this.tPanelMain.Controls.Add(this.PanelMain, 1, 1);
            this.tPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tPanelMain.Location = new System.Drawing.Point(0, 33);
            this.tPanelMain.Name = "tPanelMain";
            this.tPanelMain.RowCount = 4;
            this.tPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tPanelMain.Size = new System.Drawing.Size(1168, 511);
            this.tPanelMain.TabIndex = 1;
            // 
            // tPanelTop
            // 
            this.tPanelTop.BackColor = System.Drawing.Color.White;
            this.tPanelTop.ColumnCount = 2;
            this.tPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.92308F));
            this.tPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tPanelTop.Controls.Add(this.IndicatorPanel, 1, 0);
            this.tPanelTop.Controls.Add(this.tbPanelButtons, 0, 0);
            this.tPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tPanelTop.Location = new System.Drawing.Point(5, 0);
            this.tPanelTop.Margin = new System.Windows.Forms.Padding(0);
            this.tPanelTop.Name = "tPanelTop";
            this.tPanelTop.RowCount = 1;
            this.tPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tPanelTop.Size = new System.Drawing.Size(1158, 200);
            this.tPanelTop.TabIndex = 0;
            // 
            // IndicatorPanel
            // 
            this.IndicatorPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IndicatorPanel.Controls.Add(this.label1);
            this.IndicatorPanel.Controls.Add(this.textBox1);
            this.IndicatorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndicatorPanel.Location = new System.Drawing.Point(893, 3);
            this.IndicatorPanel.Name = "IndicatorPanel";
            this.IndicatorPanel.Size = new System.Drawing.Size(262, 194);
            this.IndicatorPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "WEIGHT INDICATOR";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(2, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(260, 96);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "123456";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPanelButtons
            // 
            this.tbPanelButtons.ColumnCount = 6;
            this.tbPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tbPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tbPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tbPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tbPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tbPanelButtons.Controls.Add(this.btnNew, 0, 1);
            this.tbPanelButtons.Controls.Add(this.btnDelete, 4, 0);
            this.tbPanelButtons.Controls.Add(this.btnReport, 2, 0);
            this.tbPanelButtons.Controls.Add(this.btnPrint, 1, 0);
            this.tbPanelButtons.Controls.Add(this.btnTransactions, 0, 0);
            this.tbPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPanelButtons.Location = new System.Drawing.Point(3, 3);
            this.tbPanelButtons.Name = "tbPanelButtons";
            this.tbPanelButtons.RowCount = 2;
            this.tbPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbPanelButtons.Size = new System.Drawing.Size(884, 194);
            this.tbPanelButtons.TabIndex = 4;
            this.tbPanelButtons.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(3, 100);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(174, 91);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(559, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 91);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReport.Location = new System.Drawing.Point(363, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(174, 91);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.Location = new System.Drawing.Point(183, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(174, 91);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnTransactions
            // 
            this.btnTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTransactions.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransactions.Location = new System.Drawing.Point(3, 3);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(174, 91);
            this.btnTransactions.TabIndex = 0;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(8, 203);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1152, 280);
            this.PanelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 544);
            this.Controls.Add(this.tPanelMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1190, 600);
            this.Name = "MainForm";
            this.Text = "Weigh Bridge Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tPanelMain.ResumeLayout(false);
            this.tPanelTop.ResumeLayout(false);
            this.IndicatorPanel.ResumeLayout(false);
            this.IndicatorPanel.PerformLayout();
            this.tbPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private TableLayoutPanel tPanelMain;
        private Panel PanelMain;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem stripMenuLogIn;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private TableLayoutPanel tPanelTop;
        private Panel IndicatorPanel;
        private TableLayoutPanel tbPanelButtons;
        private TextBox textBox1;
        private Label label1;
        private Button btnDelete;
        private Button btnReport;
        private Button btnPrint;
        private Button btnTransactions;
        private Button btnNew;
        private ToolStripMenuItem managementToolStripMenuItem;
        private ToolStripMenuItem toolMenuUser;
    }
}