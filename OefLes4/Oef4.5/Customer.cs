using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._5
{
    class Customer
    {
        public static Random generator = new Random();
        public enum AccountTypes { SavingsAccount, InvestementAccount }

        //a dictionary to print out a proper string, enums shouldn't be used to display info
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
            BankAccounts = new List<BankAccount>();
        }

        #region "Methods list bankaccounts"

        //if else structure changed so it doesn't assign unnecessarily 
        //if checks in a for loop to prevent 2 foreach loops
        //this method only returns all accounts of a given type
        public string ListBankAccounts(AccountTypes type)
        {
            if (BankAccounts.Count == 0)
            {
                return "This customer has no bank accounts";
            }
            else
            {
                StringBuilder output = new StringBuilder();
                output.AppendLine($"{AccountTypesStrings[type]}: \n");
                foreach (BankAccount bankAccount in BankAccounts)
                {
                    if (type == AccountTypes.SavingsAccount)
                    {
                        //Checks the type of the current bankaccount vs a constant
                        //the type will be the child class
                        if (bankAccount.GetType() == typeof(SavingsAccount))
                        {
                            output.AppendLine($"{bankAccount}");
                        }
                    }
                    //else if for possible future additions of accounttypes
                    else if (type == AccountTypes.InvestementAccount)
                    {
                        if (bankAccount.GetType() == typeof(InvestmentAccount))
                        {
                            output.AppendLine($"{bankAccount}");
                        }
                    }
                } 
                return output.ToString();
            }
        }

        public string ListBankAccounts()
        {
            if (BankAccounts.Count == 0)
            {
                return "This customer has no bank accounts";
            }
            else
            {
                StringBuilder output = new StringBuilder();
                output.AppendLine("Investement accounts: \n");
                foreach (BankAccount bankAccount in BankAccounts)
                {
                    output.AppendLine($"{bankAccount}");
                }
                return output.ToString();
            }
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

        #endregion "Methods list bankaccounts"

        public static Customer MakeRandomCustomer()
        {
            List<string> lastnames = new List<string>
            {
                "Jones",
                "Free",
                "HayWood",
                "Dooley",
                "Jameson"
            };
            List<string> firstnames = new List<string>
            {
                "Morgan",
                "Jack",
                "Trevor",
                "Brian",
                "Peter"
            };

            string randomName = $"{firstnames[generator.Next(firstnames.Count)]} {lastnames[generator.Next(lastnames.Count)]}";
            Address randomAddress = Address.MakeRandomAddress();
            return new Customer(randomName, randomAddress);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Customer number: {CustomerNumber:'C'00000000}");
            output.AppendLine($"Name: {Name}");
            output.AppendLine($"Address: \n{CustomerAddress}");
            if(BankAccounts.Count != 0)
            {
                output.AppendLine("Bank accounts: \n");
                foreach (BankAccount bankAccount in BankAccounts)
                {
                    output.AppendLine($"{bankAccount.AccountNumber}");
                }
            }
            else
            {
                output.AppendLine("This customer has no bankaccounts");
            }
            return output.ToString();
        }
    }
}
