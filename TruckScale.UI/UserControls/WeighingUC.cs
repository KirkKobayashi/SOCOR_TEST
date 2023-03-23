﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;
using TruckScale.Library.Repositories;
using TruckScale.UI.HelperClass;

namespace TruckScale.UI.UserControls
{
    public partial class WeighingUC : UserControl
    {
        public bool NewTransaction { get; set; } = false;
        private ErrorProvider errorProvider;
        private readonly IApplicationService _service;
        public WeighingUC(IApplicationService service)
        {
            InitializeComponent();
            _service = service;
           
        }

        private void WeighingUC_Load(object sender, EventArgs e)
        {
            GetCustomers();
            GetSuppliers();
            GetProducts();

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
            Supplier supplier = new Supplier { Name = cboSupplier.Text, Active = true };
            Customer customer = new Customer { Name = cboCustomer.Text, Active = true };    
            Product product = new Product { Name=cboProduct.Text, Active=true };
            Truck truck = new Truck { PlateNumber = txtPlateNumber.Text.Trim(), TareWeight = Convert.ToInt32(txtFirstWeight.Text) };
            Weigher weigher = new Weigher { Id = 1, FirstName = "Test" };

            WeighingTransaction transaction = new WeighingTransaction
            {
                Supplier = supplier,
                Customer = customer,
                Product = product,
                Truck = truck,
                Weigher = weigher,
                FirstWeightDate = DateTime.Now,
                FirstWeight = Convert.ToInt32(txtFirstWeight.Text),
                Driver = txtDriver.Text.Trim(),
                Remarks = txtRemarks.Text,
                Quantity = txtQuantity.Text
            };
        }

        private void GetCustomers()
        {
            var customers = _service.GetCustomers();

            cboCustomer.Items.Clear();
            cboCustomer.DataSource = customers;
            cboCustomer.DisplayMember = "Name";
            cboCustomer.ValueMember = "Id";
        }

        private void GetSuppliers()
        {
            var suppliers = _service.GetSuppliers();

            cboSupplier.Items.Clear();
            cboSupplier.DataSource = suppliers;
            cboSupplier.DisplayMember = "Name";
            cboSupplier.ValueMember = "Id";
        }

        private void GetProducts()
        { 
            var products = _service.GetProducts();

            cboProduct.Items.Clear();
            cboProduct.DataSource = products;
            cboProduct.DisplayMember = "Name";
            cboProduct.ValueMember = "Id";
        }
    }
}
