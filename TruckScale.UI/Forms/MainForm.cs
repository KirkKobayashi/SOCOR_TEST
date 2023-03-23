using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private WeighingUC? weighingUC;
        public MainForm()
        {
            InitializeComponent();
            //ShowWeighing();
            //ShowUserManagement();
            ShowUserLogIn();
        }

        public void ClearPanel()
        {
            PanelMain.Controls.Clear();
        }

        private void ShowWeighing()
        {
            //weighingUC= new WeighingUC();
            //PanelMain.Controls.Add( weighingUC );
            //weighingUC.Dock = DockStyle.Fill;
            //weighingUC.Show();
        }

        private void ShowUserLogIn()
        {
            LogInUC logInUC = new LogInUC(new ApplicationService(new ScaleDbContext(ConStringHelper.Get())), this);
            PanelMain.Controls.Add(logInUC);
            logInUC.Dock = DockStyle.Fill; 
            logInUC.Show();
        }


        private void ShowUserManagement()
        {
            WeigherUC weigherUC = new WeigherUC(new ApplicationService(new ScaleDbContext(ConStringHelper.Get())));
            PanelMain.Controls.Add(weigherUC);
            weigherUC.Dock = DockStyle.Fill;
            weigherUC.Show();
        }

    }
}
