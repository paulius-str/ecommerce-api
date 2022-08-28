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
    internal class BrandRepository : RepositoryBase<Brand>, IBrandRepository
    {
        public BrandRepository(RepositoryDbContext dbContext) : base(dbContext)
        {
        }

        public void CreateBrand(Brand brand)
        {
            Create(brand);
        }

        public void DeleteBrand(Brand brand)
        {
            Delete(brand);
        }

        public async Task<IEnumerable<Brand>> GetAllBrandsAsync()
        {
            return await FindAll().ToListAsync();
        }

        public async Task<Brand> GetBrandAsync(int productId)
        {
            return await FindByCondition(x => x.Id == productId).FirstOrDefaultAsync();
        }

        public void UpdateBrand(Brand brand)
        {
            Update(brand);
        }
    }
}
