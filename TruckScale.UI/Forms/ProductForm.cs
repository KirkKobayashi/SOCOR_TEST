using System.Windows.Forms;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;

namespace TruckScale.UI.Forms
{
    public partial class ProductForm : Form
    {
        private readonly IProductRepository _service;
        private Product _product;
        public ProductForm(IProductRepository service)
        {
            InitializeComponent();
            _service = service;

            GetAll();
        }

        private void GetAll()
        {
            listBox.Items.Clear();
            var records = _service.GetAll();

            if (records != null)
            {
                foreach (var item in records)
                {
                    listBox.Items.Add(item.Name);
                }
            }
            else
            {
                listBox.Items.Clear();
            }
        }

        private Product GetProduct(string name)
        {
            return _service.GetProductByName(name);
        }

        private void AddRecord()
        {
            try
            {
                _service.Insert(new Product { Name = txtName.Text.ToUpper() });
                MessageBox.Show("Record saved/updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while saving record.\n\n{ex.Message}");
            }
            finally
            {
                _product = null;
            }
        }

        private void UpdateProduct()
        {
            try
            {
                _product.Name = txtName.Text.ToUpper();
                _service.Update(_product);

                MessageBox.Show("Record saved/updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while saving record.\n\n{ex.Message}");
            }
            finally
            {
                _product = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Record name is empty.");
                return;
            }

            if (_product == null)
            {
                var recfound = GetProduct(txtName.Text);

                if (recfound == null)
                {
                    AddRecord();
                }
                else
                {
                    MessageBox.Show("Record name already exists.");
                    return;
                }
            }
            else
            {
                UpdateProduct();
            }

            GetAll();

            txtName.Text = string.Empty;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _product = _service.GetProductByName(txtName.Text);

                if (_product != null)
                {
                    txtName.Text = _product.Name.ToUpper();
                }
                else
                {
                    txtName.Text = string.Empty;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = listBox.SelectedItem.ToString().Split('@')[0];
        }
    }
}
