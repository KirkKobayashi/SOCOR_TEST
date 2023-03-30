using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Binom_Dist_Range;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckScale.Library.BLL;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Data.Models;

namespace TruckScale.UI.UserControls
{
    public partial class ProductManagementUC : UserControl
    {
        private ApplicationService _applicationService;
        private List<Product> _products;
        private int _recordId;
        private readonly ScaleDbContext _dbcontext;
        private ErrorProvider _ep;

        public ProductManagementUC(ScaleDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public ProductManagementUC()
        {
            InitializeComponent();

            dgvRecords.CellMouseClick += DgvRecords_CellMouseClick;
            btnDelete.Click += BtnDelete_Click;
            btnAdd.Click += BtnAdd_Click;
            btnSave.Click += BtnSave_Click;

            _ep = new ErrorProvider();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                _ep.SetError(txtName, "This field can not be empty");
                return;
            }
            else
            {
                _ep.SetError(txtName, "");

                using (_dbcontext)
                {
                    var product = _dbcontext.Products.FirstOrDefault(p => p.Name.ToUpper() == txtName.Text.ToUpper());

                    if (product != null)
                    {
                        _dbcontext.Products.Add(new Product { Name = txtName.Text.ToUpper(), Active = true });
                        _dbcontext.SaveChanges();
                    }
                    else
                    {
                        product.Name = txtName.Text.ToUpper();
                        _dbcontext.Products.Update(product);
                        _dbcontext.SaveChanges();
                    }

                    txtName.Text = string.Empty;
                    FillDataGrid();
                }
            }
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtName.Focus();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (_recordId > 0)
            {
                var ans = MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ans == DialogResult.Yes)
                {
                    using (_dbcontext)
                    {
                        var product = _dbcontext.Products.Find(_recordId);

                        if (product != null)
                        {
                            _dbcontext.Products.Remove(product);
                            _dbcontext.SaveChanges();

                            FillDataGrid();
                        }
                    }
                }
            }
        }

        private void DgvRecords_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                var row = dgvRecords.Rows[e.RowIndex];

                txtName.Text = row.Cells[index: 1].Value.ToString();
                _recordId = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        public void FillDataGrid()
        {
            try
            {
                using (_dbcontext)
                {
                    _products = _dbcontext.Products.ToList();
                    dgvRecords.Rows.Clear();

                    if (_products != null)
                    {
                        dgvRecords.DataSource = _products;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
