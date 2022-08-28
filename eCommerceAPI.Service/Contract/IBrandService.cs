using eCommerceAPI.Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Service.Contract
{
    public interface IBrandService
    {
        Task<IEnumerable<BrandDto>> GetAllBrandsAsync();
        Task<BrandDto> GetBrandAsync(int brandId);
        Task<BrandDto> CreateBrandAsync(BrandForCreationDto brand);
        Task DeleteBrandAsync(int brandId);
        Task UpdateBrandAsync(int brandId, BrandForUpdateDto brandForUpdate);
    }
}
