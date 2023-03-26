using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using TruckScale.Library.BLL;
using TruckScale.Library.Data.DTOs;
using TruckScale.Library.Printing;
using TruckScale.Report_Print;
using TruckScale.UI.Forms;
using Font = System.Drawing.Font;

namespace TruckScale.UI.UserControls
{
    public partial class TransactionsUC : UserControl
    {
        public int transactionId { get; set; }
        private string _appDirectory;
        private StreamReader reader;
        private readonly MainForm _mainForm;
        private readonly ApplicationService _service;
        public TransactionsUC(ApplicationService service, MainForm mainForm)
        {
            InitializeComponent();
            _service = service;
            _mainForm = mainForm;
            _appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            GetRecords();
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AllowUserToAddRows = false;
        }

        public void PrintScaleTicket()
        {
            try
            {
                string ticketPath = _appDirectory;
                string fileName = "Templates\\ScaleTicket.txt";
                var excel = new ExcelHelper(ticketPath, fileName);

                ScaleTicket st = new ScaleTicket(fileName, ticketPath);


                var transaction = _service.GetTransaction(transactionId);

                var flatTrans = new FlatWeighingTransaction
                {
                    TruckPlateNumber = transaction.Truck.PlateNumber,
                    CustomerName = transaction.Customer.Name,
                    SupplierName = transaction.Supplier.Name,
                    FirstWeighingDate = transaction.FirstWeightDate,
                    SecondWeighingDate = transaction.SecondWeightDate,
                    FirstWeight = transaction.FirstWeight,
                    SecondWeight = transaction.SecondWeight,
                    ProductName = transaction.Product.Name,
                    Quantity = transaction.Quantity,
                    TicketNumber = transaction.TicketNumber,
                    WeigherName = $"{transaction.Weigher.FirstName} {transaction.Weigher.LastName}"
                };
                var fullPath = st.PrintTicket(flatTrans);

                PrintDocument pd = new PrintDocument();
                pd.DocumentName = fullPath;
                pd.PrintPage += Pd_PrintPage;
                reader = new StreamReader(fullPath);

                PrintPreviewDialog ppd = new PrintPreviewDialog();
                ppd.Document = pd;
                pd.Print();
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs ppeArgs)
        {
            System.Drawing.Font verdana10Font = new Font("Verdana", 8);
            //Get the Graphics object  
            Graphics g = ppeArgs.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            //Read margins from PrintPageEventArgs  
            float leftMargin = ppeArgs.MarginBounds.Left;
            float topMargin = ppeArgs.MarginBounds.Top;
            string line = null;
            //Calculate the lines per page on the basis of the height of the page and the height of the font  
            linesPerPage = ppeArgs.MarginBounds.Height / verdana10Font.GetHeight(g);
            //Now read lines one by one, using StreamReader  
            while (count < linesPerPage && ((line = reader.ReadLine()) != null))
            {
                //Calculate the starting position  
                yPos = topMargin + (count * verdana10Font.GetHeight(g));
                //Draw text  
                g.DrawString(line, verdana10Font, Brushes.Black, leftMargin, yPos, new StringFormat());
                //Move to next line  
                count++;
            }
            //If PrintPageEventArgs has more pages to print  
            if (line != null)
            {
                ppeArgs.HasMorePages = true;
            }
            else
            {
                ppeArgs.HasMorePages = false;
            }
        }

        private void GetRecords()
        {
            try
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
            catch (Exception)
            {

                throw;
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
                _mainForm.ShowWeighing(false, transactionId);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintScaleTicket();
        }
    }
}
