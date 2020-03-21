using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._5
{
    class Investment : Transaction
    {
        public TimeSpan InvestmentPeriod { get; private set; }

        public Investment(DateTime transactionDate, decimal transactionValue, TimeSpan investmentPeriod) : base(transactionDate, transactionValue)
        {
            InvestmentPeriod = investmentPeriod;
        }

        public DateTime CalculateInvestmentEnd()
        {
            DateTime output = TransactionDate + InvestmentPeriod;
            return output;
        }

        public override bool HasInvestmentEnded(DateTime date)
        {
            if(CalculateInvestmentEnd() <= date)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool HasInvestmentEnded()
        {
            return HasInvestmentEnded(DateTime.Today);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Investment perdiod: {InvestmentPeriod:ddd} days");
            output.AppendLine($"Investment ends on {CalculateInvestmentEnd():yyyy-MM-dd}");
            output.AppendLine($"{(HasInvestmentEnded() ? "This investment has ended" : "This investment is still ongoing")}");
            return base.ToString() + output.ToString();
        }
    }
}
