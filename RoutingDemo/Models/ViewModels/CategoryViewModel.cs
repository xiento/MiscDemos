using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingDemo.Models.ViewModels
{
    public class CategoryViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; }
        public virtual IEnumerable<ProductViewModel> Products { get; set; }
    }
}
