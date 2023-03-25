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
using TruckScale.UI.Forms;

namespace TruckScale.UI.UserControls
{
    public partial class TransactionsUC : UserControl
    {
        public int transactionId { get; set; }

        private readonly MainForm _mainForm;
        private readonly ApplicationService _service;
        public TransactionsUC(ApplicationService service, MainForm mainForm)
        {
            InitializeComponent();
            _service = service;
            _mainForm = mainForm;

            GetRecords();
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AllowUserToAddRows = false;
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
            dt.Columns.Add("Net Weight", typeof(int));
            dt.Columns.Add("Weighing Date/Time", typeof(string));

            foreach (var i in records)
            {
                var netweight = i.FirstWeight - i.SecondWeight;
                dt.Rows.Add(i.Id, i.Truck.PlateNumber, i.Customer.Name, i.Supplier.Name, i.Product.Name, i.FirstWeight, i.SecondWeight, Math.Abs(netweight), i.FirstWeightDate.ToString("HH:mm MM-dd-yyyy"));
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

        private void dgvTransactions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTransactions.Rows[e.RowIndex];
                transactionId = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void dgvTransactions_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTransactions.Rows[e.RowIndex];
                transactionId = Convert.ToInt32(row.Cells[0].Value);
                _mainForm.ShowWeighing(false, transactionId);
            }
        }
    }
}
