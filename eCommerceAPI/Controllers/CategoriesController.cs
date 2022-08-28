using eCommerceAPI.Service.Contract;
using eCommerceAPI.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly IServiceManager _serviceManager;

    public CategoriesController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCategories()
    {
        var categories = await _serviceManager.CategoryService.GetAllCategoriesAsync();

        return Ok(categories);
    }

    [HttpGet("{categoryId:int}", Name = "CategoryById")]
    public async Task<IActionResult> GetProduct(int categoryId)
    {
        var category = await _serviceManager.CategoryService.GetCategoryAsync(categoryId);

        return Ok(category);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory(CategoryForCreationDto category)
    {
        var createdCategory = await _serviceManager.CategoryService.CreateCategoryAsync(category);

        return CreatedAtRoute("CategoryById", new { categoryId = createdCategory.Id }, createdCategory);
    }

    [HttpPut("{categoryId:int}")]
    public async Task<IActionResult> UpdateCategory(int categoryId, [FromBody] CategoryForUpdateDto category)
    {
        await _serviceManager.CategoryService.UpdateCategoryAsync(categoryId, category);

        return NoContent();
    }


    [HttpDelete("{categoryId:int}")]
    public async Task<IActionResult> DeleteCategory(int categoryId)
    {
        await _serviceManager.CategoryService.DeleteCategoryAsync(categoryId);

        return NoContent();
    }
}
