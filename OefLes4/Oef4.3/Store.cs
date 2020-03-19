using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._3
{
    class Store
    {
        public string Name { get; set; }

        public string Adress { get; set; }

        //yes they fit in the same list
        //no you don't have to cast them
        //It's called polymorphism
        private List<Product> Products { get; }

        public Store(string name, string adress)
        {
            Name = name;
            Adress = adress;
            Products = new List<Product>();
        }

        public Store() : this("A store", "Whatever")
        {

        }

        public string DisplayProducts()
        {
            StringBuilder output = new StringBuilder();
            if(Products.Count != 0)
            {
                output.AppendLine("This store sells: ");
                foreach (Product product in Products)
                {
                    output.AppendLine($"{product}");
                }
            }
            else
            {
                output.AppendLine("The list of products is empty");
            }
            return output.ToString();
        }

        public Product FindProduct(string productName)
        {
            Product output = null;
            foreach (Product item in Products)
            {
                if(item.GetProductName() == productName)
                {
                    output = item;
                }
            }
            return output;
        }

        public bool AddProduct(Product input)
        {
            if(input != null)
            {
                if (Products.Count != 0)
                {
                    if(Products.Contains(input))
                    {
                        return false;
                    }
                    else
                    {
                        Products.Add(input);
                        return true;
                    }
                }
                else
                {
                    Products.Add(input);
                    return true;
                }
            }
            else
            {
                throw new ArgumentNullException();
            }           
        }

        public bool RemoveProduct(Product input)
        {
            if (input != null)
            {
                if (Products.Count != 0)
                {
                    if (Products.Contains(input))
                    {
                        Products.Remove(input);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Name: {Name}");
            output.AppendLine($"Adress: {Adress}");
            output.AppendLine($"{DisplayProducts()}");
            return output.ToString();
        }
    }
}
