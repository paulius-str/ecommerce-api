using eCommerceAPI.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RepositoryDbContext _dbContext;
        private readonly Lazy<ICategoryRepository> _categoryRepository;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<IBrandRepository> _brandRepository;

        public UnitOfWork(RepositoryDbContext dbContext)
        {
            _dbContext = dbContext;
            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(_dbContext));
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(_dbContext));
            _brandRepository = new Lazy<IBrandRepository>(() => new BrandRepository(_dbContext));
        }

        public ICategoryRepository Category { get; set; }
        public IProductRepository Product { get; set; }
        public IBrandRepository Brand { get; set; }

        public async Task SaveAsync() => await _dbContext.SaveChangesAsync();
    }
}
