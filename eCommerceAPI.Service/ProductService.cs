using AutoMapper;
using eCommerceAPI.Entities.Models;
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
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ProductDto> CreateProductAsync(ProductForCreationDto product)
        {
            var newProduct = _mapper.Map<Product>(product);

            _unitOfWork.Product.CreateProduct(newProduct);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<ProductDto>(newProduct);
        }

        public async Task DeleteProductAsync(int productId)
        {
            var productToDelete = await GetProductAndCheckIfItExists(productId);

            _unitOfWork.Product.DeleteProduct(productToDelete);
            await _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await _unitOfWork.Product.GetAllProductsAsync();

            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<ProductDto> GetProductAsync(int productId)
        {
            var product = await _unitOfWork.Product.GetProductAsync(productId);

            return _mapper.Map<ProductDto>(product);
        }

        public async Task UpdateProductAsync(int productId, ProductForUpdateDto productForUpdate)
        {
            var product = await GetProductAndCheckIfItExists(productId);

            _mapper.Map(productForUpdate, product);
            await _unitOfWork.SaveAsync();
        }

        private async Task<Product> GetProductAndCheckIfItExists(int productId)
        {
            var product = await _unitOfWork.Product.GetProductAsync(productId);

            if (product == null)
                throw new Exception();

            return product;
        }
    }
}
