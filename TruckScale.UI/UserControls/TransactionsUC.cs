using System.Configuration;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using TruckScale.Library.BLL;
using TruckScale.Library.Data.DTOs;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Printing;
using TruckScale.UI.Forms;
using TruckScale.UI.HelperClass;

namespace TruckScale.UI.UserControls
{
    public partial class TransactionsUC : UserControl
    {
        public int transactionId { get; set; }

        private readonly MainForm _mainForm;
        //private readonly ApplicationService _service;
        private readonly IApplicationServiceExtensions _serviceExtensions;
        private StreamReader reader;
        //private List<WeighingTransaction> _transactions;
        private string _appDirectory;
        DataTable dt;


        public TransactionsUC(IApplicationServiceExtensions serviceExtensions)
        {
            InitializeComponent();
            _serviceExtensions = serviceExtensions;
            //_service = service;
            _appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            GetRecords();
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AllowUserToAddRows = false;

            CheckDirectory();

        }
        public TransactionsUC(ApplicationService service, MainForm mainForm, IApplicationServiceExtensions serviceExtensions)
        {
            InitializeComponent();
            //_service = service;
            _mainForm = mainForm;
            _appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            GetRecords();
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AllowUserToAddRows = false;

            CheckDirectory();
            _serviceExtensions = serviceExtensions;
        }

        private void CheckDirectory()
        {
            try
            {
                if (!Directory.Exists(_appDirectory + "\\Templates"))
                {
                    Directory.CreateDirectory(_appDirectory + "\\Templates");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Print creation error \n\n{ex.Message}");
            }
        }

        private void GetRecords()
        {
            try
            {
                var startdate = dtStart.Value.Date;
                var enddate = dtEnd.Value.Date.AddDays(1).AddTicks(-10);
                //var _transactions = _service.GetTransactionsByDate(startdate, enddate);
                var _transactions = _serviceExtensions.GetRangedTransactions(startdate, enddate);

                dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Plate Number", typeof(string));
                dt.Columns.Add("Customer", typeof(string));
                dt.Columns.Add("Supplier", typeof(string));
                dt.Columns.Add("Product", typeof(string));
                dt.Columns.Add("First Weight", typeof(int));
                dt.Columns.Add("Second Weight", typeof(int));
                dt.Columns.Add("Net Weight", typeof(int));
                dt.Columns.Add("Weighing Date/Time", typeof(string));

                foreach (var i in _transactions)
                {

                    var netweight = i.FirstWeight - i.SecondWeight;
                    dt.Rows.Add(i.Id, i.TruckPlateNumber, i.CustomerName, i.SupplierName, i.ProductName, i.FirstWeight, i.SecondWeight, Math.Abs(netweight), i.FirstWeighingDate.ToString("HH:mm MM-dd-yyyy"));
                    //    var netweight = i.FirstWeight - i.SecondWeight;
                    //    dt.Rows.Add(i.Id, i.Truck.PlateNumber, i.Customer.Name, i.Supplier.Name, i.Product.Name, i.FirstWeight, i.SecondWeight, Math.Abs(netweight), i.FirstWeightDate.ToString("HH:mm MM-dd-yyyy"));
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving records\n\n{ex.Message}", "Truck Scale Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                GlobalProps.TransactionId = transactionId;
                GlobalProps.newTrans = false;
                //_mainForm.ShowWeighing(false, transactionId);

                var frm = new TransactionForm(Factory.GetApplicationServiceExtensions());
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();

                GetRecords();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var transaction = _serviceExtensions.GetById(transactionId);
                var toprint = TransactionMiscClass.ConvertToDTO(transaction);
                var settings = SettingsGetter.GetPrintSettings();

                var printer = new TicketPrinter(toprint, settings);
                printer.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while printing the scale ticket \n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (transactionId > 0)
                {
                    var ans = MessageBox.Show("Delete selected record?", "Truck Scale Application", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                    if (ans == DialogResult.Yes)
                    {
                        _serviceExtensions.DeleteTransaction(transactionId);
                        GetRecords();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record", "Truck Scale Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                ScaleReport rpt = new ScaleReport();

                var startdate = dtStart.Value.Date;
                var enddate = dtEnd.Value.Date.AddDays(1).AddTicks(-10);
                var records = _serviceExtensions.GetTransactionsByDate(startdate, enddate);

                if (records.Count == 0)
                {
                    MessageBox.Show("No records found for the given date range.", "Truck Scale Application", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                {
                    dialog.InitialDirectory = @"C:\temp";
                    var result = dialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        var savePath = dialog.SelectedPath;
                        rpt.ExportReport(records, savePath);

                        MessageBox.Show("Report Saved", "Truck Scale Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //_mainForm.ShowWeighing(true, 0);
            GlobalProps.newTrans = true;
            var frm = new TransactionForm(Factory.GetApplicationServiceExtensions());
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();

            GetRecords();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchString = txtSearch.Text.Trim();

                // Filter the DataTable rows based on the search term in the "Name" column
                var filteredRows = dt.AsEnumerable()
                    .Where(row => row.Field<string>("Plate Number").ToLower().Contains(searchString.ToLower()));

                // Create a new DataTable with the filtered rows
                DataTable filteredDataTable = filteredRows.Any() ? filteredRows.CopyToDataTable() : dt.Clone();

                // Bind the filtered DataTable to the DataGridView
                dgvTransactions.DataSource = filteredDataTable;
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.SelectAll();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = "Plate Number";
        }

        public static class TransactionMiscClass
        {
            public static FlatWeighingTransaction ConvertToDTO(WeighingTransaction transaction)
            {
                if (transaction != null)
                {
                    return new FlatWeighingTransaction
                    {
                        FirstWeight = transaction.FirstWeight,
                        SecondWeighingDate = transaction.SecondWeightDate,
                        FirstWeighingDate = transaction.FirstWeightDate,
                        SecondWeight = transaction.SecondWeight,
                        CustomerName = transaction.Customer?.Name ?? string.Empty,
                        SupplierName = transaction.Supplier?.Name ?? string.Empty,
                        ProductName = transaction.Product.Name ?? string.Empty,
                        Remarks = transaction.Remarks ?? string.Empty,
                        Quantity = transaction.Quantity ?? string.Empty,
                        TicketNumber = transaction.TicketNumber,
                        TruckPlateNumber = transaction.Truck.PlateNumber,
                        WeigherName = transaction.Weigher.UserName
                    };
                }

                return new FlatWeighingTransaction();
            }
        }

    }
}
