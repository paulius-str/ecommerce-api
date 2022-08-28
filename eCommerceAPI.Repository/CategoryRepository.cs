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
    internal class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryDbContext dbContext) : base(dbContext)
        {
        }

        public void CreateCategory(Category category)
        {
            Create(category);
        }

        public void DeleteCategory(Category category)
        {
            Delete(category);
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await FindAll().ToListAsync();
        }

        public async Task<Category> GetCategoryAsync(int productId)
        {
            return await FindByCondition(x => x.Id == productId).FirstOrDefaultAsync();
        }

        public void UpdateCategory(Category category)
        {
            Update(category);
        }
    }
}
