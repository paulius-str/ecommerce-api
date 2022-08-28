using eCommerceAPI.Repository.Contract;
using eCommerceAPI.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICategoryService> _categoryService;
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IBrandService> _brandService;
        private readonly IUnitOfWork _unitOfWork;

        public ServiceManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            _categoryService = new Lazy<ICategoryService>(() => new CategoryService(_unitOfWork));
            _productService = new Lazy<IProductService>(() => new ProductService(_unitOfWork));
            _brandService = new Lazy<IBrandService>(() => new BrandService(_unitOfWork));
        }

        public ICategoryService CategoryService => _categoryService.Value;

        public IProductService ProductService => _productService.Value;

        public IBrandService BrandService => _brandService.Value;

    }
}
