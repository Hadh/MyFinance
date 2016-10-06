using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string name { get; set; }
        public string test { get; set; }
        public virtual ICollection<Product> ProductList { set; get; }
    }
}
