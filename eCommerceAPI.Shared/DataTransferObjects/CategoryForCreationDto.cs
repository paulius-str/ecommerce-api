using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Shared.DataTransferObjects
{
    public record CategoryForCreationDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public ICollection<int>? ChildrenIds { get; set; }
    }
}
