using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;
using TruckScale.Library.Repositories;
using TruckScale.UI.Forms;
using TruckScale.UI.HelperClass;

namespace TruckScale.UI.UserControls
{
    public partial class WeighingUC : UserControl
    {
        private readonly int _transId;
        private readonly bool _newTrans;
        private ErrorProvider errorProvider;
        private readonly IApplicationService _service;
        private readonly MainForm _mainForm;

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
                txtTicket.Text =  _service.GetTicketNumber().ToString();
            }
            else
            {
                LoadDetails();
            }
            errorProvider = new ErrorProvider();
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

        private void InsertTransaction()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
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

                    WeighingTransaction transaction = new WeighingTransaction
                    {
                        FirstWeightDate = DateTime.Now,
                        FirstWeight = Convert.ToInt32(txtFirstWeight.Text),
                        Driver = txtDriver.Text.Trim(),
                        Remarks = txtRemarks.Text,
                        Quantity = txtQuantity.Text,
                        WeigherId = _mainForm.weigherId,
                        CustomerId = customerId,
                        SupplierId = supplierId,
                        ProductId = productId,
                        TruckId = truckId, 
                        TicketNumber = Convert.ToInt32(txtTicket.Text)
                    };

                    _service.InsertTransaction(transaction);

                    _mainForm.ClearPanelFromWeighing();
                    scope.Complete();
                }
                catch (Exception)
                {
                    scope.Dispose();
                    throw;
                }
            }
        }

        private void UpdateTransaction()
        {

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
            var td = _service.GetTransaction(_transId);

            if (td != null)
            {
                txtTicket.Text = td.TicketNumber.ToString();
                txtPlateNumber.Text = td.Truck?.PlateNumber ?? string.Empty;
                cboCustomer.Text = td.Customer?.Name ?? string.Empty;
                cboSupplier.Text = td.Supplier?.Name ?? string.Empty;
                cboProduct.Text = td.Product?.Name ?? string.Empty;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _mainForm.ClearPanelFromWeighing();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var goodTicket = FormValidation(txtTicket);
            var goodPlate = FormValidation(txtPlateNumber);
            var goodCustomer = FormValidation(cboCustomer);
            var goodSupplier = FormValidation(cboSupplier);
            var goodProduct = FormValidation(cboProduct);

            if (_newTrans)
            {
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

                    InsertTransaction();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_newTrans)
            {
                txtFirstWeight.Text = _mainForm.stringWeight;
            }
        }
    }
}
