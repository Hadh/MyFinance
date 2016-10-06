using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Provider
    {
        [DataType(DataType.Password)]
        [Required]
        [NotMapped]
        [Compare("Password")]
        public string confirmPassword { get; set; }

        public DateTime DateCreated { get; set; }

        public string email { get; set; }
        [Key]
        public int Id { get; set; }
        public bool isApproved { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [MinLength(8,ErrorMessage ="Le min est 8 ")]
        public string password { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Product> ProductsList { set; get; }
    }
}
