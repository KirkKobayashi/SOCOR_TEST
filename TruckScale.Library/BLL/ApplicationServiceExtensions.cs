using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Graph.Models;
using Microsoft.Graph.Models.Security;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Data.DTOs;
using TruckScale.Library.Data.Models;

namespace TruckScale.Library.BLL
{

    public class ApplicationServiceExtensions : ApplicationService
    {
        ScaleDbContext _dbContext;

        public ApplicationServiceExtensions(ScaleDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        #region Validations
        public Customer ValidateCustomer(string name)
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

            if (customer == null)
            {
                var newRecord = new Customer { Name = name, Active = true };
                _dbContext.Add(newRecord);
                _dbContext.SaveChanges();

                return newRecord;
            }

            return customer;
        }

        public Supplier ValidateSupplier(string name)
        {
            var supplier = _dbContext.Suppliers.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

            if (supplier == null)
            {
                var newRecord = new Supplier { Name = name, Active = true };
                _dbContext.Add(newRecord);
                _dbContext.SaveChanges();

                return newRecord;
            }

            return supplier;
        }

        public Product ValidateProduct(string name)
        {
            var product = _dbContext.Products.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

            if (product == null)
            {
                var newRecord = new Product { Name = name, Active = true };
                _dbContext.Add(newRecord);
                _dbContext.SaveChanges();

                return newRecord;
            }

            return product;
        }

        public Truck ValidateTruck(string plateNumber)
        {
            var truck = _dbContext.Trucks.FirstOrDefault(x => x.PlateNumber.ToLower() == plateNumber.ToLower());

            if (truck == null)
            {
                var newRecord = new Truck { PlateNumber = plateNumber };
                _dbContext.Add(newRecord);
                _dbContext.SaveChanges();

                return newRecord;
            }

            return truck;
        }

        public Weigher ValidateUser(string username)
        {
            var user = _dbContext.Weighers.FirstOrDefault(x => x.UserName == username);

            if (user == null)
            {
                throw new ArgumentNullException("Username does not exists.");
            }

            return user;
        } 
        #endregion

        public void InsertNewTransaction(FlatWeighingTransaction transaction)
        {
            var customer = ValidateCustomer(transaction.CustomerName);
            var supplier     = ValidateSupplier(transaction.SupplierName);
            var product = ValidateProduct(transaction.ProductName);
            var truck = ValidateTruck(transaction.TruckPlateNumber);
            var weigher = ValidateUser(transaction.WeigherName);

            var newWeighing = new WeighingTransaction
            {
                Customer = customer,
                Supplier = supplier,
                Product = product,
                Truck = truck,
                Weigher = weigher,
                FirstWeight = transaction.FirstWeight,
                FirstWeightDate = transaction.FirstWeighingDate,
                Driver = transaction.DriverName,
                Quantity = transaction.Quantity,
                Remarks = transaction.Remarks
            };

            _dbContext.WeighingTransactions.Add(newWeighing);
            _dbContext.SaveChanges();
        }
    }
}
