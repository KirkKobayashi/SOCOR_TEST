using TruckScale.Library.Data.DTOs;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;

namespace TruckScale.Library.BLL
{
    public interface IApplicationServiceExtensions
    {
        List<Customer> GetCustomers();
        List<Supplier> GetSuppliers();
        List<Product> GetProducts();
        List<FlatWeighingTransaction> FlattenTransactionRecords(List<WeighingTransaction> weighingTransactions);
        List<FlatWeighingTransaction> GetRangedTransactions(DateTime startDate, DateTime endDate);
        void InsertNewTransaction(FlatWeighingTransaction transaction);
        void UpdateTransaction(FlatWeighingTransaction transaction);
        Customer ValidateCustomer(string name);
        Product ValidateProduct(string name);
        Supplier ValidateSupplier(string name);
        Truck ValidateTruck(string plateNumber);
        Weigher ValidateUser(string username);
        FlatWeighingTransaction GetDisplayTransaction(int id);
        List<WeighingTransaction>? GetTransactionsByDate(DateTime startDate, DateTime endDate);
        WeighingTransaction GetById(int id);
        void DeleteTransaction(int id);
        int GetTicketNumber();
    }

    public class ApplicationServiceExtensions : IApplicationServiceExtensions
    {
        private ICustomerRepository _customerService;
        private ISupplierRepository _supplierService;
        private IProductRepository _productService;
        private ITruckRepository _truckService;
        private IWeigherRepository _weigherService;
        private ITransactionRepository _transactionService;

        public ApplicationServiceExtensions(ICustomerRepository customerService, ISupplierRepository supplierService, IProductRepository productService, ITruckRepository truckService, IWeigherRepository weigherService, ITransactionRepository transactionService)
        {
            _customerService = customerService;
            _supplierService = supplierService;
            _productService = productService;
            _truckService = truckService;
            _weigherService = weigherService;
            _transactionService = transactionService;
        }



        #region Validations
        public Customer ValidateCustomer(string name)
        {
            var customer = _customerService.GetCustomerByName(name);

            if (customer == null)
            {
                var newRecord = new Customer { Name = name, Active = true };
                _customerService.Insert(newRecord);
                return newRecord;
            }

            return customer;
        }

        public Supplier ValidateSupplier(string name)
        {
            var supplier = _supplierService.GetSupplierByName(name);

            if (supplier == null)
            {
                var newRecord = new Supplier { Name = name, Active = true };
                _supplierService.Insert(newRecord);

                return newRecord;
            }

            return supplier;
        }

        public Product ValidateProduct(string name)
        {
            var product = _productService.GetProductByName(name);

            if (product == null)
            {
                var newRecord = new Product { Name = name, Active = true };
                _productService.Insert(newRecord);

                return newRecord;
            }

            return product;
        }

        public Truck ValidateTruck(string plateNumber)
        {
            var truck = _truckService.GetTruckByPlateNumber(plateNumber);

            if (truck == null)
            {
                var newRecord = new Truck { PlateNumber = plateNumber };
                _truckService.Insert(newRecord);

                return newRecord;
            }

            return truck;
        }

        public Weigher ValidateUser(string username)
        {
            var user = _weigherService.GetByName(username);

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

            _transactionService.Insert(newWeighing);
        }

        public void UpdateTransaction(FlatWeighingTransaction transaction)
        {
            var recordToUpdate = _transactionService.GetById(transaction.Id);

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

            _transactionService.Update(recordToUpdate);
        }

        public List<FlatWeighingTransaction> GetRangedTransactions(DateTime startDate, DateTime endDate)
        {
            var trans = _transactionService.GetRangedRecords(startDate, endDate).ToList();

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
            return _customerService.GetAll();
        }

        public List<Supplier> GetSuppliers()
        {
            return _supplierService.GetAll();
        }

        public List<Product> GetProducts()
        {
            return _productService.GetAll();
        }

        public FlatWeighingTransaction GetDisplayTransaction(int id)
        {
            var t =  _transactionService.GetById(id);

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
            return _transactionService.GetRangedRecords(startDate, endDate).ToList();
        }

        public WeighingTransaction GetById(int id)
        {
            return _transactionService.GetById(id);
        }

        public void DeleteTransaction(int id)
        {
            _transactionService.Delete(id);
        }

        public int GetTicketNumber()
        {
            return _transactionService.GetTicketNumber();
        }
    }
}
