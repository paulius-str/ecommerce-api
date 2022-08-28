using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Service.Contract
{
    public interface IServiceManager
    {
        ICategoryService CategoryService { get; }
        IProductService ProductService { get; }
        IBrandService BrandService { get; }
    }
}
