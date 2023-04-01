using Microsoft.EntityFrameworkCore;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Data.Models;
using TruckScale.UI.HelperClass;

namespace TruckScale.UI.UserControls
{
    public partial class SupplierCrudUC : UserControl
    {
        private ScaleDbContext _dbContext;
        private bool _newRecord;
        private int _recId;
        public SupplierCrudUC()
        {
            InitializeComponent();

            _dbContext = Factory.GetDBContext();

            GetRecords();

            btnSave.Click += BtnSave_Click;
            dgvRecords.CellMouseClick += DgvRecords_CellMouseClick;
            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtName.ReadOnly = false;
            txtName.Focus();
            _newRecord = true;
        }

        private void DgvRecords_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            var dgv = (DataGridView?)sender;
            DataGridViewRow? row = dgv.Rows[e.RowIndex];

            txtName.Text = row.Cells[1].Value.ToString();

            _recId = Convert.ToInt32(row.Cells[0].Value);

            if (dgv.Columns[e.ColumnIndex].Name == "edit")
            {
                txtName.ReadOnly = false;
                txtName.Focus();
                _newRecord = false;
            }

            if (dgv.Columns[e.ColumnIndex].Name == "delete")
            {
                var ans = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ans == DialogResult.Yes)
                {
                    DeleteRecord(_recId);
                    txtName.Text = string.Empty;
                }
            }
        }

        private void DeleteRecord(int recordId)
        {
            var supp = _dbContext.Suppliers.Find(recordId);

            if (supp != null)
            {
                _dbContext.Suppliers.Remove(supp);
                _dbContext.SaveChanges();
                GetRecords();
            }
        }
        private async void GetRecords()
        {
            var records = await _dbContext.Suppliers.ToListAsync();

            if (records != null)
            {
                dgvRecords.Rows.Clear();
                foreach (var i in records)
                {
                    dgvRecords.Rows.Add(i.Id, i.Name);
                }
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            var ep = new ErrorProvider();
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                ep.SetError(txtName, "Name must not be blank.");
                return;
            }
            else
            {
                ep.SetError(txtName, "");
            }

            try
            {
                if (_newRecord)
                {
                    _dbContext.Suppliers.Add(new Supplier { Active = true, Name = txtName.Text.ToUpper(), });
                    _dbContext.SaveChanges();

                }
                else
                {
                    var record = _dbContext.Suppliers.Find(_recId);
                    if (record != null)
                    {
                        record.Name = txtName.Text.ToUpper();
                        _dbContext.Entry(record).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        _dbContext.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Record not found");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            _newRecord = false;
            GetRecords();
            txtName.Text = string.Empty;
            txtName.ReadOnly = true;
        }
    }
}
