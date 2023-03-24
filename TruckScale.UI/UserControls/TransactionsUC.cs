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

namespace TruckScale.UI.UserControls
{
    public partial class TransactionsUC : UserControl
    {
        private readonly ApplicationService _service;
        public TransactionsUC(ApplicationService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void btStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        public void Refresh()
        {

        }
    }
}
