using eCommerceAPI.Repository.Contract;
using eCommerceAPI.Service.Contract;
using eCommerceAPI.Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<CategoryDto> CreateCategoryAsync(CategoryForCreationDto category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(int categoryId, CategoryForUpdateDto categoryForUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
