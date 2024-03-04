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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            systemToolStripMenuItem = new ToolStripMenuItem();
            stripMenuLogIn = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ViewMenu = new ToolStripMenuItem();
            managementToolStripMenuItem = new ToolStripMenuItem();
            toolMenuUser = new ToolStripMenuItem();
            productMgtMenu = new ToolStripMenuItem();
            customerMgtMenu = new ToolStripMenuItem();
            supplierMgtMenu = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            tPanelMain = new TableLayoutPanel();
            tPanelTop = new TableLayoutPanel();
            IndicatorPanel = new Panel();
            txtIndicator = new TextBox();
            PanelMain = new Panel();
            menuStrip1.SuspendLayout();
            tPanelMain.SuspendLayout();
            tPanelTop.SuspendLayout();
            IndicatorPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { systemToolStripMenuItem, ViewMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1100, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stripMenuLogIn, logOutToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(57, 22);
            systemToolStripMenuItem.Text = "System";
            // 
            // stripMenuLogIn
            // 
            stripMenuLogIn.Name = "stripMenuLogIn";
            stripMenuLogIn.Size = new Size(117, 22);
            stripMenuLogIn.Text = "Log In";
            stripMenuLogIn.Click += stripMenuLogIn_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(117, 22);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(114, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(117, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // ViewMenu
            // 
            ViewMenu.DropDownItems.AddRange(new ToolStripItem[] { managementToolStripMenuItem, transactionsToolStripMenuItem });
            ViewMenu.Enabled = false;
            ViewMenu.Name = "ViewMenu";
            ViewMenu.Size = new Size(44, 22);
            ViewMenu.Text = "View";
            // 
            // managementToolStripMenuItem
            // 
            managementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolMenuUser, productMgtMenu, customerMgtMenu, supplierMgtMenu });
            managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            managementToolStripMenuItem.Size = new Size(145, 22);
            managementToolStripMenuItem.Text = "Management";
            // 
            // toolMenuUser
            // 
            toolMenuUser.Name = "toolMenuUser";
            toolMenuUser.Size = new Size(126, 22);
            toolMenuUser.Text = "User";
            toolMenuUser.Click += toolMenuUser_Click;
            // 
            // productMgtMenu
            // 
            productMgtMenu.Name = "productMgtMenu";
            productMgtMenu.Size = new Size(126, 22);
            productMgtMenu.Text = "Products";
            productMgtMenu.Click += productMgtMenu_Click;
            // 
            // customerMgtMenu
            // 
            customerMgtMenu.Name = "customerMgtMenu";
            customerMgtMenu.Size = new Size(126, 22);
            customerMgtMenu.Text = "Customer";
            customerMgtMenu.Click += customerMgtMenu_Click;
            // 
            // supplierMgtMenu
            // 
            supplierMgtMenu.Name = "supplierMgtMenu";
            supplierMgtMenu.Size = new Size(126, 22);
            supplierMgtMenu.Text = "Suppliers";
            supplierMgtMenu.Click += supplierMgtMenu_Click;
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(145, 22);
            transactionsToolStripMenuItem.Text = "Transactions";
            transactionsToolStripMenuItem.Click += transactionsToolStripMenuItem_Click;
            // 
            // tPanelMain
            // 
            tPanelMain.ColumnCount = 3;
            tPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 4F));
            tPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 4F));
            tPanelMain.Controls.Add(tPanelTop, 1, 0);
            tPanelMain.Controls.Add(PanelMain, 1, 1);
            tPanelMain.Dock = DockStyle.Fill;
            tPanelMain.Location = new Point(0, 24);
            tPanelMain.Margin = new Padding(2);
            tPanelMain.Name = "tPanelMain";
            tPanelMain.RowCount = 4;
            tPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 3F));
            tPanelMain.Size = new Size(1100, 521);
            tPanelMain.TabIndex = 1;
            // 
            // tPanelTop
            // 
            tPanelTop.BackColor = Color.FromArgb(63, 136, 197);
            tPanelTop.ColumnCount = 2;
            tPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.92308F));
            tPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.07692F));
            tPanelTop.Controls.Add(IndicatorPanel, 1, 0);
            tPanelTop.Dock = DockStyle.Fill;
            tPanelTop.Location = new Point(4, 0);
            tPanelTop.Margin = new Padding(0);
            tPanelTop.Name = "tPanelTop";
            tPanelTop.RowCount = 1;
            tPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tPanelTop.Size = new Size(1092, 42);
            tPanelTop.TabIndex = 0;
            // 
            // IndicatorPanel
            // 
            IndicatorPanel.BackColor = Color.Transparent;
            IndicatorPanel.Controls.Add(txtIndicator);
            IndicatorPanel.Dock = DockStyle.Fill;
            IndicatorPanel.Location = new Point(842, 2);
            IndicatorPanel.Margin = new Padding(2);
            IndicatorPanel.Name = "IndicatorPanel";
            IndicatorPanel.Size = new Size(248, 38);
            IndicatorPanel.TabIndex = 3;
            // 
            // txtIndicator
            // 
            txtIndicator.Anchor = AnchorStyles.Right;
            txtIndicator.BackColor = Color.White;
            txtIndicator.BorderStyle = BorderStyle.None;
            txtIndicator.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtIndicator.Location = new Point(1, 4);
            txtIndicator.Margin = new Padding(2);
            txtIndicator.Multiline = true;
            txtIndicator.Name = "txtIndicator";
            txtIndicator.ReadOnly = true;
            txtIndicator.Size = new Size(247, 31);
            txtIndicator.TabIndex = 0;
            txtIndicator.TabStop = false;
            txtIndicator.TextAlign = HorizontalAlignment.Right;
            txtIndicator.TextChanged += txtIndicator_TextChanged;
            txtIndicator.DoubleClick += txtIndicator_DoubleClick;
            txtIndicator.Leave += txtIndicator_Leave;
            // 
            // PanelMain
            // 
            PanelMain.BackColor = Color.WhiteSmoke;
            PanelMain.BorderStyle = BorderStyle.Fixed3D;
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Location = new Point(6, 44);
            PanelMain.Margin = new Padding(2);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(1088, 460);
            PanelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 545);
            Controls.Add(tPanelMain);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            MinimumSize = new Size(836, 369);
            Name = "MainForm";
            Text = "Weigh Bridge Application";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tPanelMain.ResumeLayout(false);
            tPanelTop.ResumeLayout(false);
            IndicatorPanel.ResumeLayout(false);
            IndicatorPanel.PerformLayout();
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
        private ToolStripMenuItem ViewMenu;
        private TableLayoutPanel tPanelTop;
        private Panel IndicatorPanel;
        private TextBox txtIndicator;
        private ToolStripMenuItem managementToolStripMenuItem;
        private ToolStripMenuItem toolMenuUser;
        private ToolStripMenuItem productMgtMenu;
        private ToolStripMenuItem customerMgtMenu;
        private ToolStripMenuItem supplierMgtMenu;
        private ToolStripMenuItem transactionsToolStripMenuItem;
    }
}