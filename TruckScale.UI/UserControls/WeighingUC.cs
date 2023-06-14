using System.Drawing.Printing;
using System.Transactions;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;
using TruckScale.Library.Printing;
using TruckScale.UI.Forms;
using TruckScale.UI.HelperClass;
using TruckScale_App;
using Control = System.Windows.Forms.Control;

namespace TruckScale.UI.UserControls
{
    public partial class WeighingUC : UserControl
    {
        private readonly int _transId;
        private readonly bool _newTrans;
        private ErrorProvider errorProvider;
        private readonly IApplicationService _service;
        private readonly MainForm _mainForm;
        private WeighingTransaction _transaction;

        public WeighingUC(IApplicationService service, MainForm mainForm, bool newTrans, int transId = 0)
        {
            InitializeComponent();
            _service = service;
            _mainForm = mainForm;
            _newTrans = newTrans;
            _transId = transId;
        }

        private void WeighingUC_Load(object sender, EventArgs e)
        {
            GetCustomers();
            GetSuppliers();
            GetProducts();
            if (_newTrans)
            {
                txtTicket.Text = _service.GetTicketNumber().ToString();
            }
            else
            {
                LoadDetails();
            }
            errorProvider = new ErrorProvider();

            txtPlateNumber.Focus();
        }

        private bool FormValidation(Control control)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                errorProvider.SetError(control, "Field can not be empty");
                return false;
            }
            else
            {
                errorProvider.SetError(control, "");
                return true;
            }
        }

        private void PrintTicket(int ticketType, WeighingTransaction transaction)
        {
            try
            {
                if (transaction != null)
                {
                    var ans = MessageBox.Show("Load scale ticket to the printer.", "Printing", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

                    if (ans == DialogResult.Cancel)
                        return;

                    var transactionToPrint = _service.GetTransaction(transaction.Id);
                    var flatTrans = ExtensionMethods.FlattenData(transactionToPrint);

                    string ticketPath = Global.AppDirectory;
                    string fileName = Global.TextFileName;

                    var fullPath = Path.Combine(ticketPath, fileName);

                    using (var pd = TicketPrinting.Print(flatTrans, fullPath, ticketType))
                    {
                        Margins margins = new Margins(5, 5, 20, 20);
                        pd.DefaultPageSettings.Margins = margins;
                        pd.DocumentName = fullPath;
                        var reader = new StreamReader(fullPath);
                        pd.PrintPage += (sender, e) => Pd_PrintPage(sender, e, reader);


                        using (PrintPreviewDialog ppd = new PrintPreviewDialog())
                        {
                            ppd.Document = pd;
                            pd.Print();
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ticket printing error\n\n{ex.Message}", "Truck Scale Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e, StreamReader reader)
        {
            System.Drawing.Font verdana10Font = new Font("Verdana", 8);
            //Get the Graphics object  
            Graphics g = e.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            //Read margins from PrintPageEventArgs  
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            //Calculate the lines per page on the basis of the height of the page and the height of the font  
            linesPerPage = e.MarginBounds.Height / verdana10Font.GetHeight(g);
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
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private void SaveTransaction(int ticketNumber)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    #region RelatedFieldsPrep
                    int productId;
                    int supplierId;
                    int customerId;
                    int truckId;

                    var supplier = _service.GetSupplierByName(cboSupplier.Text);
                    var customer = _service.GetCustomerByName(cboCustomer.Text);
                    var product = _service.GetProductByName(cboProduct.Text);
                    var truck = _service.GetTruckByPlate(txtPlateNumber.Text);

                    if (supplier is null)
                    {
                        supplierId = _service.AddSupplier(cboSupplier.Text);
                    }
                    else
                    {
                        supplierId = supplier.Id;
                    }

                    if (customer is null)
                    {
                        customerId = _service.AddCustomer(cboCustomer.Text);
                    }
                    else
                    {
                        customerId = customer.Id;
                    }

                    if (product is null)
                    {
                        productId = _service.AddProduct(cboProduct.Text);
                    }
                    else
                    {
                        productId = product.Id;
                    }

                    if (truck is null)
                    {
                        truckId = _service.AddTruck(txtPlateNumber.Text.ToUpper());
                    }
                    else
                    {
                        truckId = truck.Id;
                    }
                    #endregion

                    var weighingTransaction = new WeighingTransaction
                    {

                        FirstWeight = Convert.ToInt32(txtFirstWeight.Text),
                        Driver = txtDriver.Text.Trim(),
                        Remarks = txtRemarks.Text,
                        Quantity = txtQuantity.Text,
                        WeigherId = _mainForm.weigherId,
                        CustomerId = customerId,
                        SupplierId = supplierId,
                        ProductId = productId,
                        TruckId = truckId,
                        TicketNumber = ticketNumber
                    };

                    if (_newTrans)
                    {
                        weighingTransaction.FirstWeightDate = DateTime.Now;
                        InsertTransaction(weighingTransaction);

                        PrintTicket(1, weighingTransaction);
                    }
                    else
                    {
                        if (Convert.ToInt32(txtSecondWeight.Text) > 0)
                        {
                            var ans = MessageBox.Show("Update this transaction?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (ans == DialogResult.No)
                            {
                                return;
                            }
                        }

                        weighingTransaction.FirstWeightDate = _transaction.FirstWeightDate;
                        weighingTransaction.Id = _transId;
                        weighingTransaction.SecondWeightDate = DateTime.Now;
                        weighingTransaction.SecondWeight = Convert.ToInt32(txtSecondWeight.Text);
                        UpdateTransaction(weighingTransaction);
                        PrintTicket(2, weighingTransaction);
                    }

                    _mainForm.ClearPanelFromWeighing();
                    scope.Complete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving / updating record \n\n{ex.Message}", "Weigh Bridge Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    scope.Dispose();
                }
            }
        }

        private void InsertTransaction(WeighingTransaction weighingTransaction)
        {
            try
            {
                _service.InsertTransaction(weighingTransaction);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void UpdateTransaction(WeighingTransaction weighingTransaction)
        {
            try
            {
                _service.UpdateTransaction(weighingTransaction);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GetCustomers()
        {
            var customers = _service.GetCustomers();

            cboCustomer.Items.Clear();
            cboCustomer.DataSource = customers;
            cboCustomer.DisplayMember = "Name";
            cboCustomer.ValueMember = "Id";
            cboCustomer.SelectedIndex = -1;
        }

        private void GetSuppliers()
        {
            var suppliers = _service.GetSuppliers();

            cboSupplier.Items.Clear();
            cboSupplier.DataSource = suppliers;
            cboSupplier.DisplayMember = "Name";
            cboSupplier.ValueMember = "Id";
            cboSupplier.SelectedIndex = -1;
        }

        private void GetProducts()
        {
            var products = _service.GetProducts();

            cboProduct.Items.Clear();
            cboProduct.DataSource = products;
            cboProduct.DisplayMember = "Name";
            cboProduct.ValueMember = "Id";
            cboProduct.SelectedIndex = -1;
        }

        private void LoadDetails()
        {
            _transaction = _service.GetTransaction(_transId);

            if (_transaction != null)
            {
                txtId.Text = _transaction.Id.ToString("0000000000");
                txtTicket.Text = _transaction.TicketNumber.ToString();
                txtPlateNumber.Text = _transaction.Truck?.PlateNumber ?? string.Empty;
                cboCustomer.Text = _transaction.Customer?.Name ?? string.Empty;
                cboSupplier.Text = _transaction.Supplier?.Name ?? string.Empty;
                cboProduct.Text = _transaction.Product?.Name ?? string.Empty;
                txtFirstWeight.Text = _transaction.FirstWeight.ToString();
                txtSecondWeight.Text = _transaction.SecondWeight.ToString();
                txtNetWeight.Text = Math.Abs(_transaction.FirstWeight - _transaction.SecondWeight).ToString();
                txtRemarks.Text = _transaction.Remarks;
                txtQuantity.Text = _transaction.Quantity;
                txtDriver.Text = _transaction.Driver;
                txtWeighInDate.Text = _transaction.FirstWeightDate.ToString("MM/dd/yyyy HH:mm");
                txtWeighOutDate.Text = _transaction.SecondWeight > 0 ? _transaction.SecondWeightDate.ToString("MM/dd/yyyy HH:mm") : string.Empty;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _mainForm.ClearPanelFromWeighing();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ticketNumber;
            if (!int.TryParse(txtTicket.Text, out ticketNumber))
            {
                MessageBox.Show("Invalid ticket number.", "Ticket Number Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTicket.Focus();
                return;
            }

            var validTicketNumber = _service.ValidateTicketNumber(ticketNumber);

            if (!validTicketNumber && _newTrans)
            {
                MessageBox.Show($"Ticket number - {ticketNumber} has already been used.");
                return;
            }

            var goodTicket = FormValidation(txtTicket);
            var goodPlate = FormValidation(txtPlateNumber);
            var goodCustomer = FormValidation(cboCustomer);
            var goodSupplier = FormValidation(cboSupplier);
            var goodProduct = FormValidation(cboProduct);

            if (goodTicket && goodPlate && goodCustomer && goodSupplier && goodProduct)
            {
                if (string.IsNullOrWhiteSpace(txtFirstWeight.Text))
                {
                    errorProvider.SetError(btnUpdate, "Click update weight");
                    return;
                }
                else
                {
                    errorProvider.SetError(btnUpdate, "");
                }

                SaveTransaction(ticketNumber);
            }
        }

        private void GetWeight()
        {
            try
            {
                if (_newTrans)
                {
                    txtFirstWeight.Text = _mainForm.stringWeight;
                }
                else
                {
                    txtSecondWeight.Text = _mainForm.stringWeight;
                    txtNetWeight.Text = Math.Abs(Convert.ToInt32(txtFirstWeight.Text) - Convert.ToInt32(txtSecondWeight.Text)).ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error capturing weight");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GetWeight();
        }

        private void txtFirstWeight_DoubleClick(object sender, EventArgs e)
        {
            txtFirstWeight.ReadOnly = false;
            txtFirstWeight.SelectAll();

        }

        private void txtSecondWeight_DoubleClick(object sender, EventArgs e)
        {
            if (_newTrans)
            {
                return;
            }
            txtSecondWeight.ReadOnly = false;
            txtSecondWeight.SelectAll();
        }

        private void txtFirstWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFirstWeight_Leave(object sender, EventArgs e)
        {
            txtFirstWeight.ReadOnly = true;
            if (_newTrans == false)
            {
                txtNetWeight.Text = Math.Abs(Convert.ToInt32(txtFirstWeight.Text) - Convert.ToInt32(txtSecondWeight.Text)).ToString();
            }
        }

        private void txtSecondWeight_Leave(object sender, EventArgs e)
        {
            txtSecondWeight.ReadOnly = true;
            txtNetWeight.Text = Math.Abs(Convert.ToInt32(txtFirstWeight.Text) - Convert.ToInt32(txtSecondWeight.Text)).ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (_transaction != null)
            {
                PrintTicket(1, _transaction);
                return;
            }

            MessageBox.Show("No transaction to print.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            if (_transaction != null)
            {
                PrintTicket(2, _transaction);
                return;
            }

            MessageBox.Show("No transaction to print.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
