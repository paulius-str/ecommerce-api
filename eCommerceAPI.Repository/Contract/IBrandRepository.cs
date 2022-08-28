using eCommerceAPI.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Repository.Contract
{
    public interface IBrandRepository
    {
        Task<IEnumerable<Brand>> GetAllBrandsAsync();
        Task<Brand> GetBrandAsync(int productId);
        void CreateBrand(Brand brand);
        void UpdateBrand(Brand brand);
        void DeleteBrand(Brand brand);
    }
}
