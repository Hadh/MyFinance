using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    [Table("Produit")]
    public class Product
    {
        public DateTime DateProd { get; set; }
        [MaxLength(256)]
        public string description { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int productId { get; set; }
        public int quantity { get; set; }
        public int CategoryId { get; set; } // FK in DB in 0 * nullable ? 
        public Category category { get; set; }
        public virtual ICollection<Provider> ProvidersList { set; get; }

    }
}
