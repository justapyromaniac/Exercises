using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._5
{
    class Transaction
    {
        private static int CounterTransactions = 1;
        public int TransactionNumber { get; private set; }

        public DateTime TransactionDate { get; private set; }

        public decimal TransactionValue { get; private set; }

        public Transaction(DateTime transactionDate, decimal transactionValue)
        {
            TransactionNumber = CounterTransactions++;
            TransactionDate = transactionDate;
            TransactionValue = transactionValue;
        }

        public virtual bool HasInvestmentEnded(DateTime date)
        {
            return true;
        }

        public virtual bool HasInvestmentEnded()
        {
            return HasInvestmentEnded(DateTime.Today);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Transaction number: {TransactionNumber:0000000}");
            output.AppendLine($"Date of transaction: {TransactionDate:yyyy-MM-dd}");
            output.AppendLine($"Transaction value: \u20AC {TransactionValue:#0.00}");
            return output.ToString();
        }
    }
}
