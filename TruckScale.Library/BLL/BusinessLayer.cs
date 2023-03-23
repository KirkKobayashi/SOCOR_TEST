using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;
using TruckScale.Library.Repositories;

namespace TruckScale.Library.BLL
{
    public class BusinessLayer
    {
        private string _constring;

        private ICustomerRepository customerService;
        private ISupplierRepository supplierService;
        private ITruckRepository truckService;
        private IWeigherRepository weigherService;
        private IProductRepository productService;

        public BusinessLayer(string constring)
        {
            _constring = constring;
        }

        public List<Customer> GetCustomers()
        {
            try
            {
                customerService = new CustomerRepository(new Data.DBContext.ScaleDbContext(_constring));

                return customerService.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
