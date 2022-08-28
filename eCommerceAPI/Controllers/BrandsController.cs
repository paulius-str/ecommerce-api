using eCommerceAPI.Service.Contract;
using eCommerceAPI.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BrandsController : ControllerBase
{
    private readonly IServiceManager _serviceManager;

    public BrandsController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllBrands()
    {
        var brands = await _serviceManager.BrandService.GetAllBrandsAsync();

        return Ok(brands);
    }

    [HttpGet("{brandId:int}", Name = "BrandById")]
    public async Task<IActionResult> GetProduct(int brandId)
    {
        var brand = await _serviceManager.BrandService.GetBrandAsync(brandId);

        return Ok(brand);
    }

    [HttpPost]
    public async Task<IActionResult> CreateBrand(BrandForCreationDto brand)
    {
        var createdBrand = await _serviceManager.BrandService.CreateBrandAsync(brand);

        return CreatedAtRoute("BrandById", new { brandId = createdBrand.Id }, createdBrand);
    }

    [HttpPut("{brandId:int}")]
    public async Task<IActionResult> UpdateCategory(int brandId, [FromBody] BrandForUpdateDto brand)
    {
        await _serviceManager.BrandService.UpdateBrandAsync(brandId, brand);

        return NoContent();
    }


    [HttpDelete("{brandId:int}")]
    public async Task<IActionResult> DeleteBrand(int brandId)
    {
        await _serviceManager.BrandService.DeleteBrandAsync(brandId);

        return NoContent();
    }
}
