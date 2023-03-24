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


            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Plate Number", typeof(string));
            dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Supplier", typeof(string));
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("First Weight", typeof(int));
            dt.Columns.Add("Second Weight", typeof(int));
            dt.Columns.Add("Weighing Date/Time", typeof(string));

            foreach (var i in records)
            {
                dt.Rows.Add(i.Id, i.Truck.PlateNumber, i.Customer.Name, i.Supplier.Name, i.Product.Name, i.FirstWeight, i.SecondWeight, i.FirstWeightDate.ToString("HH:mm MM-dd-yyyy"));
            }

            dgvTransactions.DataSource = null;
            dgvTransactions.DataSource = dt;

            foreach (DataGridViewColumn column in dgvTransactions.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;

            dgvTransactions.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
