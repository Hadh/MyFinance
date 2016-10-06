using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data
{
    public class MyFinanceContext:DbContext
    {
        public MyFinanceContext():base("Name=MyF")
        {
            //Database.SetInitializer<MyFinanceContext>(new InitializerContext());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Provider> Providers { get; set; }
    }

    //public class InitializerContext:DropCreateDatabaseIfModelChanges<MyFinanceContext>    /* on va initialiser le context */
    //{
    //    protected override void Seed(MyFinanceContext context)
    //    {
    //        /* recreate DB from data to be inserted, this data is gonna be inserted right when the db is re-created */

    //        var CategoryList = new List<Category>
    //        {
    //            new Category {name="Stuff" },
    //            new Category {name="Other Stuff" },
    //            new Category {name="More stuff" },
    //        };

    //        context.Categorys.AddRange(CategoryList);
    //        context.SaveChanges();
    //    }
    //}
}
