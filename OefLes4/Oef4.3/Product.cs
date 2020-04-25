using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._3
{
    abstract class Product
    {
        public static Random generator = new Random();
        public string Name { get; set; }

        public string Supplier { get; set; }

        public decimal Price { get; set; }

        protected Product(string name, string supplier, decimal price)
        {
            Name = name;
            Supplier = supplier;
            Price = price;
        }

        public virtual string GetSalePrice()
        {
            return $"\u20AC {Price:#0.00}";
        }

        public string GetProductName()
        {
            return Name;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Name: {Name}");
            output.AppendLine($"Price: {GetSalePrice()}");
            output.AppendLine($"Supplier: {Supplier}");
            return output.ToString();
        }
    }
}
