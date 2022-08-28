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
    public class BrandService : IBrandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BrandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<BrandDto> CreateBrandAsync(BrandForCreationDto brand)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBrandAsync(int brandId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BrandDto>> GetAllBrandsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BrandDto> GetBrandAsync(int brandId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBrandAsync(int brandId, BrandForUpdateDto brandForUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
