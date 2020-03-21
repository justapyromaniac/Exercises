using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._5
{
    class Bank
    {
        public string Name { get; set; }

        public Address BankAddress { get; set; }

        public List<Customer> Customers { get; set; }

        public Bank(string name, Address bankAddress)
        {
            Name = name;
            BankAddress = bankAddress;
        }

        public string ListCustomers()
        {
            StringBuilder output = new StringBuilder();
            if(Customers.Count != 0)
            {
                output.AppendLine("Customers: \n");
                foreach (Customer customer in Customers)
                {
                    output.AppendLine($"{customer}");
                }
            }
            else
            {
                output.AppendLine($"This bank has no customers");
            }
            return output.ToString();
        }

        public Customer FindCustomer(int customerNumber)
        {
            Customer output = null;
            foreach (Customer customer in Customers)
            {
                if(customer.CustomerNumber == customerNumber)
                {
                    output = customer;
                }
            }
            return output;
        }

        public bool AddCustomer(Customer customer)
        {
            if(customer != null)
            {
                if(Customers.Count != 0)
                {
                    if(Customers.Contains(customer))
                    {
                        return false;
                    }
                    else
                    {
                        Customers.Add(customer);
                        return true;
                    }
                }
                else
                {
                    Customers.Add(customer);
                    return true;
                }
            }
            else
            {
                throw new Exception("Please input a valid customer");
            }
        }

        public bool RemoveCustomer(Customer customer)
        {
            if (customer != null)
            {
                if (Customers.Count != 0)
                {
                    if (Customers.Contains(customer))
                    {
                        Customers.Remove(customer);
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
                throw new Exception("Please input a valid customer");
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Name: {Name}");
            output.AppendLine($"Address: {BankAddress}");
            output.AppendLine($"{ListCustomers()}");
            return base.ToString();
        }
    }
}
