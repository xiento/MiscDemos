using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingDemo.Models
{
    public class Category : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        //if ParentId has value, then its a subcategory
        //public Guid ParentId { get; set; }
        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
