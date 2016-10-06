using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Product
    {
        [DataType(DataType.DateTime)]
        [Display(Name ="Production Date")]
        public DateTime DateProd { get; set; }
        [MaxLength(256)]
        [DataType(DataType.MultilineText)]
        public string description { get; set; }
        [Required]
        [MaxLength(25,ErrorMessage ="La taille max est 20!")]
        [StringLength(50, ErrorMessage = "La Longueur max est 20!")]
        public string name { get; set; }
        [DataType(DataType.Currency)]
        public double price { get; set; }
        public int productId { get; set; }
        [Range(0,Int32.MaxValue)]
        public int quantity { get; set; }
        public int? CategoryId { get; set; } // FK in DB in 0 * nullable ? 
        [ForeignKey("CategoryId")]
        public virtual Category category { get; set; }
        public virtual ICollection<Provider> ProvidersList { set; get; }

    }
}
