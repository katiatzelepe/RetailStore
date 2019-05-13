using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace RetailStore
{
    interface IStore
    {
        
        void BuyProduct(Product product);
        void SellProduct(Product product);
        double GetRevenue();
    }

    public class SimpleRetailStore : IStore
    {
        public double TotalBuyBalance;
        public double TotalSellBalance;
        public double Revenue;
        //public double BuyProduct { get; set; }
        public  Product PriceWhenBuy;
        
        public Product PriceWhenSell;

        




        

        public void BuyProduct(Product product)
        {
            TotalBuyBalance += product.PriceWhenBuy;
            

        }

        public void SellProduct(Product product)
        {
            TotalSellBalance += product.PriceWhenSell;
            
        }

        public double GetRevenue()
        {
            Revenue = TotalSellBalance - TotalSellBalance;
            return Revenue;
        }

        
    }

    public class InvetoryRetailStore : IStore

    {
        // products[0].Id;
       

        List<Product> products = new List<Product>();
        public double TotalBuyBalance;
        public double TotalSellBalance;
        public double Revenue;

       // public InvetoryRetailStore()
       // {
         //   products = new List<Product>();
       // }
        public void BuyProduct(Product product)
        {
            products.Add(new Product(product.Id,
                product.Name, product.PriceWhenBuy, product.PriceWhenSell));
           
               TotalBuyBalance += product.PriceWhenBuy;
            
            
        }

        public void  SellProduct(Product product)
        {
            var productFound = false;
            //products.Find()
            foreach (var p in products)
            {
                if (p.Id == product.Id)
                {
                    productFound = true;
                }
            }
            if (productFound)
            {
                TotalSellBalance += product.PriceWhenSell;
                products.Remove(product);

                
            }
            else
            {
                Console.WriteLine("Product not found!");
                
            }
        }

        public double GetRevenue()
        {
            //return products.Sum(product => product.PriceWhenBuy - product.PriceWhenSell);
            //or
            //foreach (var p in products)
            //{
            //    Revenue += p.PriceWhenBuy - p.PriceWhenSell;

            //}
            //return Revenue;

            //or** the best way bcs you keep all the shells
            Revenue = TotalBuyBalance - TotalSellBalance;
            return Revenue; 
        }

        public void GetInvetory()
        {
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }

        public void Reset()
        {
            products.Clear();
            
        }

    }




}
