using MyFinance.Data;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFinanceContext fContext = new MyFinanceContext();
            Category cat1 = new Category
            {
                name="Cat_1",
                
            };
            fContext.Categorys.Add(cat1);
           
            fContext.SaveChanges();
            Console.WriteLine("Thank you! ");
            Console.ReadKey();
        }
    }
}
