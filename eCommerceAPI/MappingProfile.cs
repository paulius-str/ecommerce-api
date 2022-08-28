using AutoMapper;
using eCommerceAPI.Entities.Models;
using eCommerceAPI.Shared.DataTransferObjects;

namespace eCommerceAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<Brand, BrandDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<ProductForCreationDto, Product>();
            CreateMap<BrandForCreationDto, Brand>();
            CreateMap<CategoryForCreationDto, Category>();
            CreateMap<ProductForUpdateDto, Product>();
            CreateMap<BrandForUpdateDto, Brand>();
            CreateMap<CategoryForUpdateDto, Category>();
        }
    }
}
