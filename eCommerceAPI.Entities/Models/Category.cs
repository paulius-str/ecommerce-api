using eCommerceAPI.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Entities.Models
{
    public class Category : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("Parent")]
        public int? ParentId { get; set; }
        public Category? Parent { get; set; }
        public ICollection<Category>? Children { get; set; }
    }
}

