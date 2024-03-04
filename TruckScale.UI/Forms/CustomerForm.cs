using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;

namespace TruckScale.UI.Forms
{
    public partial class CustomerForm : Form
    {
        private readonly ICustomerRepository _customerService;
        private Customer _customer;
        public CustomerForm(ICustomerRepository customerService)
        {
            InitializeComponent();
            _customerService = customerService;
            GetAll();

        }

        private void GetAll()
        {
            listBoxCustomers.Items.Clear();
            var customers = _customerService.GetAll();

            if (customers != null)
            {
                foreach (var item in customers)
                {
                    listBoxCustomers.Items.Add(item.Name);
                }
            }
            else
            {
                listBoxCustomers.Items.Clear();
            }
        }

        private Customer GetCustomer(string name)
        {
            return _customerService.GetCustomerByName(name);
        }

        private void AddCustomer()
        {
            try
            {
                _customerService.Insert(new Customer { Name = txtName.Text.ToUpper() });
                MessageBox.Show("Record saved/updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while saving record.\n\n{ex.Message}");
            }
            finally
            {
                _customer = null;
            }
        }

        private void UpdateCustomer()
        {
            try
            {
                _customer.Name = txtName.Text.ToUpper();
                _customerService.Update(_customer);

                MessageBox.Show("Record saved/updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while saving record.\n\n{ex.Message}");
            }
            finally
            {
                _customer = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Customer name is empty.");
                return;
            }

            if (_customer == null)
            {
                var customerfound = GetCustomer(txtName.Text);

                if (customerfound == null)
                {
                    AddCustomer();
                }
                else
                {
                    MessageBox.Show("Customer name already exists.");
                    return;
                }
            }
            else
            {
                UpdateCustomer();
            }

            GetAll();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _customer = _customerService.GetCustomerByName(txtName.Text);

                if (_customer != null)
                {
                    txtName.Text = _customer.Name.ToUpper();
                }
                else
                {
                    txtName.Text = string.Empty;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
