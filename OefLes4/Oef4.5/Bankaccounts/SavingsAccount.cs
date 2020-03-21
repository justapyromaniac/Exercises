using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._5
{
    class SavingsAccount : BankAccount
    {

        public decimal FidelityInterestRate { get; private set; }
        public SavingsAccount(DateTime openAccountDate, decimal intrestRate, decimal fidelityInterestRate) : base(openAccountDate, intrestRate)
        {
            FidelityInterestRate = fidelityInterestRate;
        }

        public SavingsAccount()
        {

        }

        public override decimal CalculateInterest(DateTime date)
        {
            if (date != null)
            {
                decimal value = 0;
                decimal interest = 0;
                DateTime nextTransaction = new DateTime();
                TimeSpan daysUntilNext = new TimeSpan();
                for (int i = 0; i < TransactionLog.Count; i++)
                {
                    if (TransactionLog[i].TransactionDate <= date)
                    {
                        if (i + 1 >= TransactionLog.Count)
                        {
                            nextTransaction = date;
                        }
                        else
                        {
                            nextTransaction = TransactionLog[i + 1].TransactionDate;
                            daysUntilNext = nextTransaction - TransactionLog[i].TransactionDate;
                            value += TransactionLog[i].TransactionValue;
                            if ((daysUntilNext.Days / 365) > 0)
                            {
                                interest += (((value / 100) * FidelityInterestRate) * (daysUntilNext.Days/365));
                            }
                            interest += (((value / 100) * InterestRate) * daysUntilNext.Days);
                        }
                    }
                }
                return interest;
            }
            else
            {
                throw new Exception("Please input a date or use the method that does not require one");
            }
        }

        public override decimal CalculateInterest()
        {
            return CalculateInterest(DateTime.Today);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Account number: {AccountNumber:'BE'000000}");
            output.AppendLine($"{GetAccountStatus()}");
            output.AppendLine($"This account was opened on: {OpenAccountDate:yyyy-MM-dd}");
            output.AppendLine($"The account balance total is: \u20AC {CalculateAccountBalance():#0.00}");
            output.AppendLine($"The interest rate on this account is: {InterestRate:P}");
            output.AppendLine($"The fidelity interest rate on this account is: {FidelityInterestRate:P}");
            output.AppendLine($"\n{ListTransactions()}");
            return output.ToString();
        }
    }
}
