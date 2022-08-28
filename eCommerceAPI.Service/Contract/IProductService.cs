using eCommerceAPI.Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Service.Contract
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductAsync(int productId);
        Task<ProductDto> CreateProductAsync(ProductForCreationDto product);
        Task DeleteProductAsync(int productId);
        Task UpdateProductAsync(int productId, ProductForUpdateDto productForUpdate);
    }
}
