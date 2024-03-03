using System.Transactions;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;
using TruckScale.UI.HelperClass;


namespace TruckScale.UI.Forms
{
    public partial class TransactionForm : Form
    {
        private IApplicationService _service;
        public TransactionForm()
        {
                InitializeComponent();
        }
        public TransactionForm(IApplicationService service)
        {
            InitializeComponent();
            _service = service;
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
        #endregion
    }
}
