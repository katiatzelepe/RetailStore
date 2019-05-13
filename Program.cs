using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Product x1 = new Product(1, "Painting Picasso. Guernica", 100, 1000);
            Product x2 = new Product(2, "Painting Tsarouxis. Naftis A", 200, 2000);
            Product x4 = new Product(3, "Chair. Luis XV", 100, 1000);
            Product x3 = new Product(4, "Vase. Cubic", 500, 5000);
            var simple = new SimpleRetailStore();
            simple.BuyProduct(x1);
            simple.SellProduct(x1);
            simple.GetRevenue();

            var invStore = new InvetoryRetailStore();
            invStore.BuyProduct(x1);
            invStore.SellProduct(x2);
            Console.WriteLine(invStore.GetRevenue());
           
            invStore.GetInvetory();

            Console.ReadLine();
        }
    }
}
