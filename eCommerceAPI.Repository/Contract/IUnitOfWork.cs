using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Repository.Contract
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; set; }
        IProductRepository Product { get; set; }
        IBrandRepository Brand { get; set; }
        Task SaveAsync();
    }
}
