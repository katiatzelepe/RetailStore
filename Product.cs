using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PriceWhenBuy { get; set; }
        public double PriceWhenSell { get; set; }

        public Product(int id, string name, double priceWhenBuy,
            double priceWhenSell)
        {
            Id = id;
            Name = name;
            PriceWhenBuy = priceWhenBuy;
            PriceWhenSell = priceWhenSell;
        }
        public string GetName()
        {
            return Name;
        }

        public double GetPriceWhenBuy()
        {
            return PriceWhenBuy;
        }

        public double GetPriceWhenSell()
        {
            return PriceWhenSell;
        }

        public  bool Equals(Product obj)
        {
            return Id == obj.Id && Name == obj.Name;
        }

        public override string ToString()
        {
            return $"\nID : {Id} Name : {Name} Price when you by the product : {PriceWhenBuy}" +
                $"  Price when you shell the product : {PriceWhenSell} ";
        }
    }
}
