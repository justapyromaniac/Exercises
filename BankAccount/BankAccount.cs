using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        public decimal Balance { get; set; }

        public BankAccount(decimal balance)
        {
            Balance = balance;
        }

        public decimal DepositMoney(decimal amount)
        {
            if(amount < 0)
            {
                throw new Exception("Please deposit a positive amount of money");
            }
            else
            {
                Balance += amount;
                return Balance;
            }
        }

        public decimal WithdrawMoney(decimal amount)
        {
            if (amount > 0)
            {
                throw new Exception("Please withdraw a negative amount of money");
            }
            else
            {
                if(Balance + amount < 0)
                {
                    throw new Exception("You cannot withdraw more money than you have");
                }
                else
                {
                    Balance += amount;
                    return Balance;
                }
            }
        }

        public override string ToString()
        {
            return $"Account balance: {Balance}";
        }
    }
}
