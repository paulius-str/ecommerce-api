using eCommerceAPI.Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Service.Contract
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();
        Task<CategoryDto> GetCategoryAsync(int categoryId);
        Task<CategoryDto> CreateCategoryAsync(CategoryForCreationDto category);
        Task DeleteCategoryAsync(int categoryId);
        Task UpdateCategoryAsync(int categoryId, CategoryForUpdateDto categoryForUpdate);
    }
}
