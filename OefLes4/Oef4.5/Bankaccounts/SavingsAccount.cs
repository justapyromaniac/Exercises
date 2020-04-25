using System;
using System.Collections.Generic;
using System.Globalization;
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

        #region "Methods calculate interest"

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
                            if(daysUntilNext.Days > 0)
                            {
                                if(TransactionLog[i].TransactionValue > 0)
                                {
                                    value += TransactionLog[i].TransactionValue;
                                    if ((daysUntilNext.Days / 365) > 0)
                                    {
                                        interest += (((value / 100) * FidelityInterestRate) * (daysUntilNext.Days / 365));
                                    }
                                    interest += (((value / 100) * InterestRate) * daysUntilNext.Days);
                                }
                            }
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

        #endregion "Methods calculate interest"

        public static SavingsAccount MakeRandomAccount()
        {
            decimal randomInterest = ((decimal)generator.Next(1, 101) / 1000M);
            decimal randomFidelityInterest = ((decimal)generator.Next(10, 101) / 1000M);
            int randomYear = generator.Next(DateTime.Today.Year - 80, DateTime.Today.Year + 1);
            int randomMonth = generator.Next(1, 13);
            int randomDay = generator.Next(1, DateTime.DaysInMonth(randomYear, randomMonth) + 1);
            DateTime randomDate = new DateTime(randomYear, randomMonth, randomDay);
            return new SavingsAccount(randomDate, randomInterest, randomFidelityInterest);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Account number: {AccountNumber:'BE'000000}");
            output.AppendLine($"{GetAccountStatus()}");
            output.AppendLine($"This account was opened on: {OpenAccountDate:yyyy-MM-dd}");
            output.AppendLine($"The account balance total is: \u20AC {CalculateAccountBalance():N}");
            output.AppendLine($"The interest rate on this account is: {InterestRate:P}");
            output.AppendLine($"The fidelity interest rate on this account is: {FidelityInterestRate:P}");
            if (TransactionLog.Count != 0)
            {
                output.AppendLine("Transactions: \n");
                foreach (Transaction transaction in TransactionLog)
                {
                    output.AppendLine($"{transaction.TransactionNumber}");
                }
            }
            else
            {
                output.AppendLine("This account has no transactions");
            }
            return output.ToString();
        }
    }
}
