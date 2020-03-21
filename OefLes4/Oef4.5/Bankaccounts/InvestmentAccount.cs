using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._5
{
    class InvestmentAccount : BankAccount
    {
        public InvestmentAccount(DateTime openAccountDate, decimal intrestRate) : base(openAccountDate, intrestRate)
        {

        }

        public InvestmentAccount()
        {

        }

        #region "Withdraw methods"

        public override Transaction WithdrawMoney(decimal money, DateTime date)
        {
            if (money > 0)
            {
                if (date != null)
                {
                    decimal AvailableBalance = Balance;
                    foreach (Transaction investment in TransactionLog)
                    {
                        if (!investment.HasInvestmentEnded())
                        {
                            AvailableBalance -= investment.TransactionValue;
                        }
                    }
                    if ((AvailableBalance - money) < 0)
                    {
                        throw new Exception("Insufficient funds");
                    }
                    else
                    {
                        Transaction output = new Transaction(date, money - (money * 2));
                        AddTransaction(output);
                        CalculateAccountBalance();
                        return output;
                    }
                }
                else
                {
                    throw new Exception("Please input a date or use the method that does not require one");
                }
            }
            else
            {
                throw new Exception("Please withdraw a positive amount of money");
            }
        }

        public override Transaction WithdrawMoney(decimal money)
        {
            return WithdrawMoney(money, DateTime.Today);
        }

        #endregion "Withdraw methods"

        #region "Depost methods"

        public override Transaction DepositMoney(decimal money, DateTime date)
        {
            if (money > 0)
            {
                if (date != null)
                {
                    Transaction output = new Transaction(date, money);
                    AddTransaction(output);
                    CalculateAccountBalance();
                    return output;
                }
                else
                {
                    throw new Exception("Please input a date or use the method that doesn't require one");
                }
            }
            else
            {
                throw new Exception("Please input a number larger than 0");
            }
        }

        public override Transaction DepositMoney(decimal money)
        {
            return DepositMoney(money, DateTime.Today);
        }

        #endregion "Depost methods"

        #region "Invest methods"

        public Transaction InvestMoney(decimal money, TimeSpan investmentPeriod, DateTime date)
        {
            if (money > 0)
            {
                if (date != null)
                {
                    Transaction output = new Investment(date, money, investmentPeriod);
                    AddTransaction(output);
                    CalculateAccountBalance();
                    return output;
                }
                else
                {
                    throw new Exception("Please input a date or use the method that doesn't require one");
                }
            }
            else
            {
                throw new Exception("Please input a number larger than 0");
            }
        }

        public Transaction InvestMoney(decimal money, TimeSpan investmentPeriod)
        {
            return InvestMoney(money, investmentPeriod, DateTime.Today);
        }

        #endregion "Invest methods"

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
