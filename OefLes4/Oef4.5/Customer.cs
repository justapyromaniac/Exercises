using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._5
{
    class Customer
    {
        public enum AccountTypes { SavingsAccount, InvestementAccount }

        private Dictionary<AccountTypes, string> AccountTypesStrings = new Dictionary<AccountTypes, string>
        { 
            { AccountTypes.SavingsAccount, "Savings account" },
            { AccountTypes.InvestementAccount, "Investement account"}
        };
        
        private static int CustomerCounter = 1;

        public int CustomerNumber { get; private set; }

        public string Name { get; private set; }

        public Address CustomerAddress { get; private set; }

        public List<BankAccount> BankAccounts { get; }

        public Customer(string name, Address customerAddress)
        {
            Name = name;
            CustomerAddress = customerAddress;
            CustomerNumber = CustomerCounter++;
        }

        public string ListBankAccounts(AccountTypes type)
        {
            StringBuilder output = new StringBuilder();
            if (BankAccounts.Count != 0)
            {
                output.AppendLine($"{AccountTypesStrings[type]}: \n");
                if(type == AccountTypes.SavingsAccount)
                {
                    foreach (SavingsAccount bankAccount in BankAccounts)
                    {
                        output.AppendLine($"{bankAccount}");
                    }
                }
                else if(type == AccountTypes.InvestementAccount)
                {
                    foreach (InvestmentAccount bankAccount in BankAccounts)
                    {
                        output.AppendLine($"{bankAccount}");
                    }
                }
            }
            else
            {
                output.AppendLine("This customer has no bank accounts");
            }
            return output.ToString();
        }

        public string ListBankAccounts()
        {
            StringBuilder output = new StringBuilder();
            if (BankAccounts.Count != 0)
            {
                output.AppendLine("Investement accounts: \n");
                foreach (BankAccount bankAccount in BankAccounts)
                {
                    output.AppendLine($"{bankAccount}");
                }
            }
            else
            {
                output.AppendLine("This customer has no bank accounts");
            }
            return output.ToString();
        }

        public BankAccount FindBankAccount(int accountnumber)
        {
            BankAccount output = null;
            foreach (BankAccount bankAccount in BankAccounts)
            {
                if(bankAccount.AccountNumber == accountnumber)
                {
                    output = bankAccount;
                }
            }
            return output;
        }

        public bool AddBankAccount(BankAccount account)
        {
            if (account != null)
            {
                if (BankAccounts.Count != 0)
                {
                    if (BankAccounts.Contains(account))
                    {
                        return false;
                    }
                    else
                    {
                        BankAccounts.Add(account);
                        return true;
                    }
                }
                else
                {
                    BankAccounts.Add(account);
                    return true;
                }
            }
            else
            {
                throw new Exception("PLease input a valid bank account");
            }
        }

        public bool RemoveBankAccount(BankAccount account)
        {
            if (account != null)
            {
                if (BankAccounts.Count != 0)
                {
                    if (BankAccounts.Contains(account))
                    {
                        BankAccounts.Remove(account);
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
                throw new Exception("PLease input a valid investement account");
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Customernumber: {CustomerNumber:'C'00000000}");
            output.AppendLine($"Name: {Name}");
            output.AppendLine($"Address: {CustomerAddress}");
            output.AppendLine($"{ListBankAccounts()}");
            return base.ToString();
        }
    }
}
