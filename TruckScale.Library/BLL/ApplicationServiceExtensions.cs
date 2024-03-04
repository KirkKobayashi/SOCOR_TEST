using TruckScale.Library.Data.DTOs;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;

namespace TruckScale.Library.BLL
{


    public class ApplicationServiceExtensions : IApplicationServiceExtensions
    {
        private IWeigherRepository _weigherService;
        private ITransactionRepository _transactionsService;
        private ICustomerRepository _customerService;
        private ISupplierRepository _supplierService;
        private IProductRepository _productService;
        private ITruckRepository _truckService;
        public ApplicationServiceExtensions(IWeigherRepository weigherService, ITransactionRepository transactionsService, ICustomerRepository customerService, ISupplierRepository supplierService, IProductRepository productService, ITruckRepository truckService)
        {
            _weigherService = weigherService;
            _transactionsService = transactionsService;
            _customerService = customerService;
            _supplierService = supplierService;
            _productService = productService;
            _truckService = truckService;
        }

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

        public void InsertNewTransaction(TransacionDTO transaction)
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

            _transactionsService.Insert(newWeighing); 
        }

        public void UpdateTransaction(TransacionDTO transaction)
        {
            var recordToUpdate = _transactionsService.GetById(transaction.Id);

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

            _transactionsService.Update(recordToUpdate);
        }

        public List<TransacionDTO> GetRangedTransactions(DateTime startDate, DateTime endDate)
        {
            var trans = _transactionsService.GetRangedRecords(startDate, endDate).ToList();

            return FlattenTransactionRecords(trans);
        }

        public List<TransacionDTO> FlattenTransactionRecords(List<WeighingTransaction> weighingTransactions)
        {
            List<TransacionDTO> flatTransactions = new List<TransacionDTO>();

            foreach (var i in weighingTransactions)
            {
                flatTransactions.Add(new TransacionDTO
                {
                    TruckPlateNumber = i.Truck?.PlateNumber ?? string.Empty,
                    CustomerName = i.Customer?.Name ?? string.Empty,
                    SupplierName = i.Supplier?.Name ?? string.Empty,
                    ProductName = i.Product?.Name ?? string.Empty,
                    TicketNumber = i.TicketNumber,
                    FirstWeight = i.FirstWeight,
                    SecondWeight = i.SecondWeight,
                    FirstWeighingDate = i.FirstWeightDate,
                    SecondWeighingDate = i.SecondWeightDate,
                    DriverName = i.Driver,
                    Quantity = i.Quantity,
                    Remarks = i.Remarks,
                    WeigherName = i.Weigher.UserName,
                    Id = i.Id
                });
            }

            return flatTransactions;
        }

        public List<Customer> GetCustomers()
        {
            return _customerService.GetAll().ToList();
        }

        public List<Supplier> GetSuppliers()
        {
            return _supplierService.GetAll().ToList();
        }

        public List<Product> GetProducts()
        {
            return _productService.GetAll().ToList();
        }

        public TransacionDTO GetDisplayTransaction(int id)
        {
            var t =_transactionsService.GetById(id);

            if (t != null)
            {
                return new TransacionDTO
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

            return new TransacionDTO();
        }

        public List<WeighingTransaction>? GetTransactionsByDate(DateTime startDate, DateTime endDate)
        {
            var trans = _transactionsService.GetRangedRecords(startDate, endDate);

            return trans.ToList();
        }

        public WeighingTransaction GetById(int id)
        {
           var rec = _transactionsService.GetById(id);
           
            if (rec == null)
                return new WeighingTransaction();

            return rec;
        }

        public void DeleteTransaction(int id)
        {
            _transactionsService.Delete(id);
        }

        public int GetTicketNumber()
        {
            return _transactionsService.GetTicketNumber();
        }
    }
}
