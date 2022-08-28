using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Entities.Models
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
