using Microsoft.EntityFrameworkCore;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;
using TruckScale.UI.Forms;
using TruckScale.UI.HelperClass;

namespace TruckScale.UI.UserControls
{
    public partial class CustomerCrudUC : UserControl
    {
        private ICustomerRepository _customerService;
        public CustomerCrudUC(MainForm mainForm, ICustomerRepository customerService)
        {
            InitializeComponent();
            _customerService = customerService;
            GetRecords();

            btnSave.Click += BtnSave_Click;
            dgvRecords.CellMouseClick += DgvRecords_CellMouseClick;
            btnAdd.Click += BtnAdd_Click;
            btnCancel.Click += BtnCancel_Click;

            TitleLabel.Text = "Customer Management";
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtName.ReadOnly = false;
            txtName.Focus();
            throw new NotImplementedException();
        }

        private void DgvRecords_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            var dgv = (DataGridView?)sender;
            DataGridViewRow? row = dgv.Rows[e.RowIndex];

            txtName.Text = row.Cells[1].Value.ToString();

            //_recId = Convert.ToInt32(row.Cells[0].Value);

            if (dgv.Columns[e.ColumnIndex].Name == "edit")
            {
                txtName.ReadOnly = false;
                txtName.Focus();
                //_newRecord = false;
            }

            if (dgv.Columns[e.ColumnIndex].Name == "delete")
            {
                var ans = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ans == DialogResult.Yes)
                {
                    //DeleteRecord(_recId);
                    txtName.Text = string.Empty;
                }
            }
        }

        private void DeleteRecord(int recordId)
        {
            try
            {
                throw new NotImplementedException();
                //var customer = _customerService.GetCustomerByName()

                //if (prod != null)
                //{
                //    _dbContext.Products.Remove(prod);
                //    _dbContext.SaveChanges();
                //    GetRecords();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Delete error \n\n{ex.Message}");
            }
        }
        private async void GetRecords()
        {
            try
            {
                var records = _customerService.GetAll();

                if (records != null)
                {
                    dgvRecords.Rows.Clear();
                    foreach (var i in records)
                    {
                        dgvRecords.Rows.Add(i.Id, i.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Retrieve error \n\n{ex.Message}");
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
            //var ep = new ErrorProvider();
            //if (string.IsNullOrWhiteSpace(txtName.Text))
            //{
            //    ep.SetError(txtName, "Name must not be blank.");
            //    return;
            //}
            //else
            //{
            //    ep.SetError(txtName, "");
            //}

            //try
            //{
            //    if (_newRecord)
            //    {
            //        _dbContext.Customers.Add(new Customer { Active = true, Name = txtName.Text.ToUpper(), });
            //        _dbContext.SaveChanges();

            //    }
            //    else
            //    {
            //        var record = _dbContext.Customers.Find(_recId);
            //        if (record != null)
            //        {
            //            record.Name = txtName.Text.ToUpper();
            //            _dbContext.Entry(record).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //            _dbContext.SaveChanges();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Record not found");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Save / Update error \n\n{ex.Message}");
            //}

            //_newRecord = false;
            //GetRecords();
            //txtName.Text = string.Empty;
            //txtName.ReadOnly = true;
        }
    }
}
