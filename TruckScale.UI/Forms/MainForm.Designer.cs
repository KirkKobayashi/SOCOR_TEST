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
            menuStrip1 = new MenuStrip();
            systemToolStripMenuItem = new ToolStripMenuItem();
            stripMenuLogIn = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            managementToolStripMenuItem = new ToolStripMenuItem();
            toolMenuUser = new ToolStripMenuItem();
            tPanelMain = new TableLayoutPanel();
            tPanelTop = new TableLayoutPanel();
            IndicatorPanel = new Panel();
            label1 = new Label();
            txtIndicator = new TextBox();
            tbPanelButtons = new TableLayoutPanel();
            btnNew = new Button();
            btnTransactions = new Button();
            PanelMain = new Panel();
            menuStrip1.SuspendLayout();
            tPanelMain.SuspendLayout();
            tPanelTop.SuspendLayout();
            IndicatorPanel.SuspendLayout();
            tbPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { systemToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1168, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stripMenuLogIn, logOutToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(85, 29);
            systemToolStripMenuItem.Text = "System";
            // 
            // stripMenuLogIn
            // 
            stripMenuLogIn.Name = "stripMenuLogIn";
            stripMenuLogIn.Size = new Size(179, 34);
            stripMenuLogIn.Text = "Log In";
            stripMenuLogIn.Click += stripMenuLogIn_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(179, 34);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(176, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(179, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { managementToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // managementToolStripMenuItem
            // 
            managementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolMenuUser });
            managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            managementToolStripMenuItem.Size = new Size(219, 34);
            managementToolStripMenuItem.Text = "Management";
            // 
            // toolMenuUser
            // 
            toolMenuUser.Name = "toolMenuUser";
            toolMenuUser.Size = new Size(149, 34);
            toolMenuUser.Text = "User";
            toolMenuUser.Click += toolMenuUser_Click;
            // 
            // tPanelMain
            // 
            tPanelMain.ColumnCount = 3;
            tPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tPanelMain.Controls.Add(tPanelTop, 1, 0);
            tPanelMain.Controls.Add(PanelMain, 1, 1);
            tPanelMain.Dock = DockStyle.Fill;
            tPanelMain.Location = new Point(0, 33);
            tPanelMain.Name = "tPanelMain";
            tPanelMain.RowCount = 4;
            tPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tPanelMain.Size = new Size(1168, 511);
            tPanelMain.TabIndex = 1;
            // 
            // tPanelTop
            // 
            tPanelTop.BackColor = Color.White;
            tPanelTop.ColumnCount = 2;
            tPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.92308F));
            tPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.07692F));
            tPanelTop.Controls.Add(IndicatorPanel, 1, 0);
            tPanelTop.Controls.Add(tbPanelButtons, 0, 0);
            tPanelTop.Dock = DockStyle.Fill;
            tPanelTop.Location = new Point(5, 0);
            tPanelTop.Margin = new Padding(0);
            tPanelTop.Name = "tPanelTop";
            tPanelTop.RowCount = 1;
            tPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tPanelTop.Size = new Size(1158, 200);
            tPanelTop.TabIndex = 0;
            // 
            // IndicatorPanel
            // 
            IndicatorPanel.BackColor = Color.WhiteSmoke;
            IndicatorPanel.Controls.Add(label1);
            IndicatorPanel.Controls.Add(txtIndicator);
            IndicatorPanel.Dock = DockStyle.Fill;
            IndicatorPanel.Location = new Point(893, 3);
            IndicatorPanel.Name = "IndicatorPanel";
            IndicatorPanel.Size = new Size(262, 194);
            IndicatorPanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 17);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 1;
            label1.Text = "WEIGHT INDICATOR";
            // 
            // txtIndicator
            // 
            txtIndicator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtIndicator.BorderStyle = BorderStyle.None;
            txtIndicator.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            txtIndicator.Location = new Point(2, 45);
            txtIndicator.Name = "txtIndicator";
            txtIndicator.Size = new Size(260, 96);
            txtIndicator.TabIndex = 0;
            txtIndicator.TabStop = false;
            txtIndicator.Text = "123456";
            txtIndicator.TextAlign = HorizontalAlignment.Center;
            txtIndicator.TextChanged += txtIndicator_TextChanged;
            // 
            // tbPanelButtons
            // 
            tbPanelButtons.ColumnCount = 6;
            tbPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tbPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tbPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tbPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tbPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tbPanelButtons.Controls.Add(btnNew, 0, 1);
            tbPanelButtons.Controls.Add(btnTransactions, 0, 0);
            tbPanelButtons.Dock = DockStyle.Fill;
            tbPanelButtons.Location = new Point(3, 3);
            tbPanelButtons.Name = "tbPanelButtons";
            tbPanelButtons.RowCount = 2;
            tbPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbPanelButtons.Size = new Size(884, 194);
            tbPanelButtons.TabIndex = 4;
            tbPanelButtons.Visible = false;
            // 
            // btnNew
            // 
            btnNew.Dock = DockStyle.Fill;
            btnNew.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(3, 100);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(174, 91);
            btnNew.TabIndex = 5;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.Dock = DockStyle.Fill;
            btnTransactions.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTransactions.Location = new Point(3, 3);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(174, 91);
            btnTransactions.TabIndex = 0;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = true;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // PanelMain
            // 
            PanelMain.BackColor = Color.WhiteSmoke;
            PanelMain.BorderStyle = BorderStyle.FixedSingle;
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Location = new Point(8, 203);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(1152, 280);
            PanelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 544);
            Controls.Add(tPanelMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1190, 600);
            Name = "MainForm";
            Text = "Weigh Bridge Application";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tPanelMain.ResumeLayout(false);
            tPanelTop.ResumeLayout(false);
            IndicatorPanel.ResumeLayout(false);
            IndicatorPanel.PerformLayout();
            tbPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtIndicator;
        private Label label1;
        private Button btnTransactions;
        private Button btnNew;
        private ToolStripMenuItem managementToolStripMenuItem;
        private ToolStripMenuItem toolMenuUser;
    }
}