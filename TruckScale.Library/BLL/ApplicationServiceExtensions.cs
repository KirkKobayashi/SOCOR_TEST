using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using Microsoft.Graph.Models.Security;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Data.DTOs;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;
using TruckScale.Library.Repositories;

namespace TruckScale.Library.BLL
{


    public class ApplicationServiceExtensions : IApplicationServiceExtensions
    {
        private IWeigherRepository _weigherService;
        private ITransactionRepository _transactionsService;
        public ApplicationServiceExtensions(IWeigherRepository weigherService, ITransactionRepository transactionsService)
        {
            _weigherService = weigherService;
            _transactionsService = transactionsService;
        }

        ScaleDbContext _dbContext;

        public void SeedWeigher(Weigher weigher)
        {
            var weighers = _weigherService.GetAll();

            if (weighers.Count == 0 || weighers == null)
            {
                _weigherService.Insert(weigher);
            }
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
            var supplier = ValidateSupplier(transaction.SupplierName);
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
                Remarks = transaction.Remarks,
                TicketNumber = transaction.TicketNumber
            };

            _dbContext.WeighingTransactions.Add(newWeighing);
            _dbContext.SaveChanges();
        }

        public void UpdateTransaction(FlatWeighingTransaction transaction)
        {
            var recordToUpdate = _dbContext.WeighingTransactions.Find(transaction.Id);

            if (recordToUpdate == null)
            {
                throw new ArgumentNullException("Record does not exists.");
            }

            var customer = ValidateCustomer(transaction.CustomerName);
            var supplier = ValidateSupplier(transaction.SupplierName);
            var product = ValidateProduct(transaction.ProductName);
            var truck = ValidateTruck(transaction.TruckPlateNumber);
            var weigher = ValidateUser(transaction.WeigherName);

            recordToUpdate.Customer = customer;
            recordToUpdate.Supplier = supplier;
            recordToUpdate.Product = product;
            recordToUpdate.Truck = truck;
            recordToUpdate.Weigher = weigher;
            recordToUpdate.FirstWeight = transaction.FirstWeight;
            recordToUpdate.SecondWeight = transaction.SecondWeight;
            recordToUpdate.SecondWeightDate = transaction.SecondWeighingDate;
            recordToUpdate.Driver = transaction.DriverName;
            recordToUpdate.Quantity = transaction.Quantity;
            recordToUpdate.Remarks = transaction.Remarks;
            recordToUpdate.TicketNumber = transaction.TicketNumber;

            _dbContext.SaveChanges();
        }

        public List<FlatWeighingTransaction> GetRangedTransactions(DateTime startDate, DateTime endDate)
        {
            var trans = _transactionsService.GetRangedRecords(startDate, endDate).ToList();

            return FlattenTransactionRecords(trans);
        }

        public List<FlatWeighingTransaction> FlattenTransactionRecords(List<WeighingTransaction> weighingTransactions)
        {
            List<FlatWeighingTransaction> flatTransactions = new List<FlatWeighingTransaction>();

            foreach (var i in weighingTransactions)
            {
                flatTransactions.Add(new FlatWeighingTransaction
                {
                    TruckPlateNumber = i.Truck?.PlateNumber ?? string.Empty,
                    CustomerName = i.Customer?.Name ?? string.Empty,
                    SupplierName = i.Supplier?.Name ?? string.Empty,
                    ProductName = i.Product?.Name ?? string.Empty,
                    TicketNumber = i.TicketNumber,
                    FirstWeight = i.FirstWeight,
                    SecondWeight = i.SecondWeight,
                    Id = i.Id
                });
            }

            return flatTransactions;
        }

        public List<Customer> GetCustomers()
        {
            return _dbContext.Customers.ToList();
        }

        public List<Supplier> GetSuppliers()
        {
            return _dbContext.Suppliers.ToList();
        }

        public List<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public FlatWeighingTransaction GetDisplayTransaction(int id)
        {
            var t = _dbContext.WeighingTransactions
                    .Include(w => w.Customer)
                     .Include(w => w.Supplier)
                     .Include(w => w.Product)
                     .Include(w => w.Truck)
                     .Include(w => w.Weigher)
                     .Where(w => w.Id == id).FirstOrDefault();

            if (t != null)
            {
                return new FlatWeighingTransaction
                {
                    TruckPlateNumber = t.Truck.PlateNumber ?? string.Empty,
                    CustomerName = t.Customer.Name ?? string.Empty,
                    SupplierName = t.Supplier.Name ?? string.Empty,
                    ProductName = t.Product.Name ?? string.Empty,
                    TicketNumber = t.TicketNumber,
                    FirstWeighingDate = t.FirstWeightDate,
                    FirstWeight = t.FirstWeight,
                    SecondWeighingDate = t.SecondWeightDate,
                    SecondWeight = t.SecondWeight,
                    DriverName = t.Driver,
                    NetWeight = Math.Abs(t.FirstWeight - t.SecondWeight),
                    Quantity = t.Quantity ?? string.Empty,
                    Remarks = t.Remarks ?? string.Empty,
                    WeigherName = t.Weigher.UserName ?? string.Empty,
                };
            }

            return new FlatWeighingTransaction();
        }

        public List<WeighingTransaction>? GetTransactionsByDate(DateTime startDate, DateTime endDate)
        {
            var trans = _dbContext.WeighingTransactions
               .Include(w => w.Customer)
               .Include(w => w.Supplier)
               .Include(w => w.Product)
               .Include(w => w.Truck)
               .Include(w => w.Weigher)
               .Where(w => w.FirstWeightDate >= startDate && w.FirstWeightDate <= endDate);

            return trans.ToList();
        }

        public WeighingTransaction GetById(int id)
        {
            var transaction = _dbContext.WeighingTransactions
                 .Include(w => w.Customer)
                     .Include(w => w.Supplier)
                     .Include(w => w.Product)
                     .Include(w => w.Truck)
                     .Include(w => w.Weigher)
                     .Where(w => w.Id == id);

            return transaction.FirstOrDefault();
        }

        public void DeleteTransaction(int id)
        {
            var recordToDelete = _dbContext.WeighingTransactions.Find(id);

            if (recordToDelete != null)
            {
                _dbContext.WeighingTransactions.Remove(recordToDelete);
                _dbContext.SaveChanges();
            }
        }

        public int GetTicketNumber()
        {
            try
            {
                var maxTicket = _dbContext.WeighingTransactions.Max(x => x.TicketNumber);
                return maxTicket + 1;
            }
            catch (InvalidOperationException)
            {
                return 1;
            }
        }
    }
}
