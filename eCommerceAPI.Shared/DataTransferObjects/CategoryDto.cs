using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Shared.DataTransferObjects
{
    public record CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CategoryDto? Parent { get; set; }
        public ICollection<CategoryDto>? Children { get; set; }
    }
}
