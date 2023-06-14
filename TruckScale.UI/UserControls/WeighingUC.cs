using System.Transactions;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;
using TruckScale.UI.Forms;
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
    }
}
