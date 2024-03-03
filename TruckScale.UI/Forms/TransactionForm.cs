using System.Transactions;
using TruckScale.Library.BLL;
using TruckScale.Library.Data.DTOs;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;
using TruckScale.UI.HelperClass;


namespace TruckScale.UI.Forms
{
    public partial class TransactionForm : Form
    {
        private IApplicationService _service;
        private IApplicationServiceExtensions _serviceExtensions;

        public TransactionForm(IApplicationService service, IApplicationServiceExtensions serviceExtensions)
        {
            InitializeComponent();
            _service = service;
            _serviceExtensions = serviceExtensions;
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            if (GlobalProps.newTrans)
            {
                txtTicket.Text = _service.GetTicketNumber().ToString();
                lblWeighIn.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            }

            txtPlateNumber.Focus();
            GetCustomers();
            GetSuppliers();
            GetProducts();
        }

        #region Data Fetch
        private void GetCustomers()
        {
            try
            {
                var customers = _service.GetCustomers();
                var autosource = new AutoCompleteStringCollection();

                Extensions.SetTextBoxSource(customers, txtCustomer);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in getting customer list. \n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetSuppliers()
        {
            try
            {
                var list = _service.GetSuppliers();
                var autosource = new AutoCompleteStringCollection();

                Extensions.SetTextBoxSource(list, txtSupplier);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in getting supplier list. \n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetProducts()
        {
            try
            {
                var list = _service.GetProducts();
                var autosource = new AutoCompleteStringCollection();

                Extensions.SetTextBoxSource(list, txtItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in getting items list. \n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RetrieveDetails()
        {
            
        }
        #endregion

        private void InsertTransaction()
        {
            var recordToInsert = new FlatWeighingTransaction
            {
                CustomerName = txtCustomer.Text,
                SupplierName = txtSupplier.Text,
                TruckPlateNumber = txtPlateNumber.Text,
                ProductName = txtItem.Text,
                DriverName = txtDriver.Text,
                WeigherName = GlobalProps.UserName,
                FirstWeighingDate = DateTime.Now,
                FirstWeight = Convert.ToInt32(txtFirstWeight.Text),
                TicketNumber = Convert.ToInt32(txtTicket.Text),
                Quantity = txtQuantity.Text
            };

            try
            {
                _serviceExtensions.InsertNewTransaction(recordToInsert);
                MessageBox.Show("Record Saved.", "New Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while saving a new transaction. \n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTransaction()
        {
            try
            {
                var recordToUpdate = new FlatWeighingTransaction
                {
                    CustomerName = txtCustomer.Text,
                    SupplierName = txtSupplier.Text,
                    TruckPlateNumber = txtPlateNumber.Text,
                    ProductName = txtItem.Text,
                    DriverName = txtDriver.Text,
                    WeigherName = GlobalProps.UserName,
                    FirstWeight = Convert.ToInt32(txtFirstWeight.Text),
                    TicketNumber = Convert.ToInt32(txtTicket.Text),
                    Quantity = txtQuantity.Text,
                    SecondWeighingDate = DateTime.Now,
                    SecondWeight = Convert.ToInt32(txtSecondWeight.Text),
                    Id = GlobalProps.TransactionId,
                    NetWeight = Convert.ToInt32(txtNetWeight.Text)
                };

                _serviceExtensions.UpdateTransaction(recordToUpdate);

                MessageBox.Show("Record Updated.", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while updating this transaction. \n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetWeight_Click(object sender, EventArgs e)
        {
            if (GlobalProps.newTrans)
            {
                txtFirstWeight.Text = GlobalProps.CurrentWeight.ToString();
                lblWeighIn.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm ");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(txtPlateNumber.Text))
            {
                MessageBox.Show("Invalid platenumber.");
                return;
            }

            if (string.IsNullOrEmpty(txtItem.Text))
            {
                MessageBox.Show("Invalid item.");
                return;
            }

            if (GlobalProps.newTrans)
            {
                if (int.TryParse(txtFirstWeight.Text, out int firstWeight))
                {
                    MessageBox.Show("Invalid first weight.");
                    return;
                }

                InsertTransaction();
            }
            else
            {
                if (int.TryParse(txtSecondWeight.Text, out int secondWeight))
                {
                    MessageBox.Show("Invalid first weight.");
                    return;
                }

                UpdateTransaction();
            }
        }
    }
}
