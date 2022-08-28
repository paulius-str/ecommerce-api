using eCommerceAPI.Service.Contract;
using eCommerceAPI.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IServiceManager _serviceManager;

    public ProductsController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await _serviceManager.ProductService.GetAllProductsAsync();

        return Ok(products);
    }

    [HttpGet("{productId:int}", Name = "ProductById")]
    public async Task<IActionResult> GetProduct(int productId)
    {
        var product = await _serviceManager.ProductService.GetProductAsync(productId);

        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct(ProductForCreationDto product)
    {
        var createdProduct = await _serviceManager.ProductService.CreateProductAsync(product);

        return CreatedAtRoute("ProductById", new { productId = createdProduct.Id }, createdProduct);
    }

    [HttpPut("{productId:int}")]
    public async Task<IActionResult> UpdateProduct(int productId, [FromBody] ProductForUpdateDto product)
    {
        await _serviceManager.ProductService.UpdateProductAsync(productId, product);

        return NoContent();
    }

    [HttpDelete("{productId:int}")]
    public async Task<IActionResult> DeleteProduct(int productId)
    {
        await _serviceManager.ProductService.DeleteProductAsync(productId);

        return NoContent();
    }
}
