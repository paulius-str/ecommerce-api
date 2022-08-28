using eCommerceAPI.Entities.Models;
using eCommerceAPI.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Repository
{
    internal class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryDbContext dbContext) : base(dbContext)
        {
        }

        public void CreateProduct(Product product)
        {
            Create(product);
        }

        public void DeleteProduct(Product product)
        {
            Delete(product);
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await FindAll().ToListAsync();
        }

        public async Task<Product> GetProductAsync(int productId)
        {
            return await FindByCondition(x => x.Id == productId).FirstOrDefaultAsync();
        }

        public void UpdateProduct(Product product)
        {
            Update(product);
        }
    }
}
