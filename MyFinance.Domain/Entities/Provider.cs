using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Provider
    {
        public string confirmPassword { get; set; }
        public DateTime DateCreated { get; set; }

        public string email { get; set; }
        public int Id { get; set; }
        public bool isApproved { get; set; }
        public string password { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Product> ProductsList { set; get; }
    }
}
