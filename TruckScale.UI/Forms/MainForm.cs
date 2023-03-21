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
using TruckScale.Library.Data.DBContext;
using TruckScale.UI.UserControls;

namespace TruckScale.UI.Forms
{
    public partial class MainForm : Form
    {
        private WeighingUC? weighingUC;
        public MainForm()
        {
            InitializeComponent();
            ShowWeighing();
        }

        private void ShowWeighing()
        {
            weighingUC= new WeighingUC();
            PanelMain.Controls.Add( weighingUC );
            weighingUC.Dock = DockStyle.Fill;
            weighingUC.Show();
        }

    }
}
