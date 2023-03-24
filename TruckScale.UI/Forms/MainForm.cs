using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckScale.Library.BLL;
using TruckScale.Library.Data.DBContext;
using TruckScale.UI.HelperClass;
using TruckScale.UI.UserControls;

namespace TruckScale.UI.Forms
{
    public partial class MainForm : Form
    {
        public int weigherId { get; set; }
        public string? stringWeight { get; set; }

        private ApplicationService _service;

        public MainForm()
        {
            InitializeComponent();

            _service = Factory.GetApplicationService();
            ShowUserLogIn();
        }

        public void ClearPanelFromWeighing()
        {
            btnNew.Enabled = true;
            btnTransactions.Enabled = true;
            btnReport.Enabled = true;
            btnDelete.Enabled = true;
            btnPrint.Enabled = true;
            PanelMain.Controls.Clear();

            ShowTransactions();
        }

        public void LogIn()
        {
            PanelMain.Controls.Clear();
            tbPanelButtons.Visible = true;
        }

        private void ShowUserLogIn()
        {
            PanelMain.Controls.Clear();
            LogInUC logInUC = new LogInUC(_service, this);
            PanelMain.Controls.Add(logInUC);
            logInUC.Dock = DockStyle.Fill; 
            logInUC.Show();
        }

        private void ShowUserManagement()
        {
            PanelMain.Controls.Clear();
            WeigherUC weigherUC = new WeigherUC(_service);
            PanelMain.Controls.Add(weigherUC);
            weigherUC.Dock = DockStyle.Fill;
            weigherUC.Show();
        }

        private void ShowTransactions()
        {
            PanelMain.Controls.Clear();
            TransactionsUC uc = new TransactionsUC(_service);
            PanelMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnTransactions.Enabled = false;
            btnReport.Enabled = false;
            btnDelete.Enabled = false;
            btnPrint.Enabled= false;
            btnNew.Enabled = false;


            WeighingUC uc = new WeighingUC(_service, this);
            uc.NewTransaction = true;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(uc); 
            uc.Dock = DockStyle.Fill;
            uc.Show();

            stringWeight = txtIndicator.Text;
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            ShowTransactions();
        }

        private void toolMenuUser_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            ShowUserManagement();
        }

        private void stripMenuLogIn_Click(object sender, EventArgs e)
        {
            ShowUserLogIn();
        }
    }
}
