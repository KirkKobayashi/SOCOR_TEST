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

            GetRecords();
        }

        private void GetRecords()
        {
            var startdate = dtStart.Value.Date;
            var enddate = dtEnd.Value.Date.AddDays(1).AddTicks(-10);
            var records = _service.GetTransactionsByDate(startdate, enddate);

        }

        private void btStart_ValueChanged(object sender, EventArgs e)
        {
            GetRecords();
        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            GetRecords();
        }

    }
}
