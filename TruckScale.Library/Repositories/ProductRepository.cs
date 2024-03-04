using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;

namespace TruckScale.Library.Repositories
{
    public class ProductRepository : IProductRepository, IDisposable
    {
        private ScaleDbContext dbContext;

        public ProductRepository(ScaleDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Delete(int id)
        {
            Product product = dbContext.Products.Find(id);

            if (product is null)
            {
                return;
            }
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
        }

        public List<Product> GetAll()
        {
            var products = dbContext?.Products.ToList();
            return products;
        }

        public Product? GetById(int id)
        {
            var product = dbContext?.Products.Find(id);
            if (product is null)
            {
                return null;
            }
            return product;
        }

        public int Insert(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();

            return product.Id;
        }

        public Product GetProductByName(string name)
        {
            return dbContext.Products.FirstOrDefault(p => p.Name == name);
        }

        public void Update(Product product)
        {
            var rectoupdate = GetById(product.Id);

            if (rectoupdate != null)
            {
                rectoupdate.Name = product.Name;
                dbContext.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Customer record not found.");
            }
        }

         private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            disposed = true;
            GC.SuppressFinalize(this);
        }


    }
}
