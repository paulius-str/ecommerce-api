using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Shared.DataTransferObjects
{
    public record BrandForCreationDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
