using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Configurations
{
    public class ProdutConfiguration:EntityTypeConfiguration<Product>
    {
        public ProdutConfiguration()
        {
            /*  RELATION : 1... 0*  */
            HasOptional(l => l.category).WithMany(c => c.ProductList)
                .HasForeignKey(p => p.CategoryId).WillCascadeOnDelete(false);

            /* RELATION:  *...* */ 
            HasMany(l => l.ProvidersList).WithMany(p => p.ProductsList)
                                .Map(p =>
                                {
                                    p.MapLeftKey("ProductId"); 
                                    p.MapRightKey("ProviderId");
                                    p.ToTable("Product_Provider");
                                });
        }
    }
}
