using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;

namespace TruckScale.UI.Forms
{
    public partial class SupplierForm : Form
    {
        private readonly ISupplierRepository _service;
        private Supplier _supplier;

        public SupplierForm(ISupplierRepository service)
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

        private Supplier GetSupplier(string name)
        {
            return _service.GetSupplierByName(name);
        }

        private void AddRecord()
        {
            try
            {
                _service.Insert(new Supplier { Name = txtName.Text.ToUpper() });
                MessageBox.Show("Record saved/updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while saving record.\n\n{ex.Message}");
            }
            finally
            {
                _supplier = null;
            }
        }

        private void UpdateRecord()
        {
            try
            {
                _supplier.Name = txtName.Text.ToUpper();
                _service.Update(_supplier);

                MessageBox.Show("Record saved/updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while saving record.\n\n{ex.Message}");
            }
            finally
            {
                _supplier = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Record name is empty.");
                return;
            }

            if (_supplier == null)
            {
                var recfound = GetSupplier(txtName.Text);

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
                UpdateRecord();
            }

            GetAll();

            txtName.Text = string.Empty;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _supplier = _service.GetSupplierByName(txtName.Text);

                if (_supplier != null)
                {
                    txtName.Text = _supplier.Name.ToUpper();
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
