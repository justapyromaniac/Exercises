using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._5
{
     abstract class BankAccount
     {
        public static Random generator = new Random();

        protected static int CounterAccounts = 1;

        public decimal Balance { get; protected set; }

        public DateTime OpenAccountDate { get; protected set; }

        public int AccountNumber { get; protected set; }

        public List<Transaction> TransactionLog { get; }

        public decimal InterestRate { get; protected set; }

        public bool IsOpen { get; protected set; }

        protected BankAccount(DateTime openAccountDate, decimal intrestRate)
        {
            OpenAccountDate = openAccountDate;
            AccountNumber = CounterAccounts++;
            TransactionLog = new List<Transaction>();
            InterestRate = intrestRate;
            IsOpen = true;
        }

        #region "TransactionLog methods"

        public string ListTransactions()
        {
            if(TransactionLog.Count == 0)
            {
                return "There are no transactions for this account";
            }
            else
            {
                StringBuilder output = new StringBuilder();
                output.AppendLine("Transactions: \n");
                foreach (Transaction transaction in TransactionLog)
                {
                    output.AppendLine($"{transaction}");
                }
                return output.ToString();
            }
        }

        public Transaction FindTransaction(int transactionNumber)
        {
            Transaction output = null;
            foreach (Transaction transaction in TransactionLog)
            {
                if(transaction.TransactionNumber == transactionNumber)
                {
                    output = transaction;
                }
            }
            return output;
        }

        public bool AddTransaction(Transaction transaction)
        {
            if(transaction != null)
            {
                if(TransactionLog.Count != 0)
                {
                    if(TransactionLog.Contains(transaction))
                    {
                        return false;
                    }
                    else
                    {
                        TransactionLog.Add(transaction);
                        return true;
                    }
                }
                else
                {
                    TransactionLog.Add(transaction);
                    return true;
                }
            }
            else
            {
                throw new Exception("Please input a valid transaction");
            }
        }

        public bool RemoveTransaction(Transaction transaction)
        {
            if (transaction != null)
            {
                if (TransactionLog.Count != 0)
                {
                    if (TransactionLog.Contains(transaction))
                    {
                        TransactionLog.Remove(transaction);
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
                throw new Exception("please input a valid transaction");
            }
        }

        #endregion "TransactionLog methods"

        #region "Depost methods"

        public virtual Transaction DepositMoney(decimal money, DateTime date)
        {
            if(money > 0)
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

        public virtual Transaction DepositMoney(decimal money)
        {
            DateTime date = DateTime.Today;
            return DepositMoney(money, date);
        }

        #endregion "Depost methods"

        #region "Withdraw methods"

        public virtual Transaction WithdrawMoney(decimal money, DateTime date)
        {
            if (money > 0)
            {
                if (date != null)
                {
                    if((Balance - money) < 0)
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

        public virtual Transaction WithdrawMoney(decimal money)
        {
            return WithdrawMoney(money, DateTime.Today);
        }

        #endregion "Withdraw methods"

        #region "Calculate balance methods"

        public virtual decimal CalculateAccountBalance(DateTime date)
        {
            if (date != null)
            {
                decimal output = 0;
                foreach (Transaction transaction in TransactionLog)
                {
                    if (transaction.TransactionDate <= date)
                    {
                        output += transaction.TransactionValue;
                    }
                }
                Balance = (output + CalculateInterest(date));
                return Math.Round(Balance, 2, MidpointRounding.ToEven);
            }
            else
            {
                throw new Exception("Please input a date or use the method that does not require one");
            }
        }

        public virtual decimal CalculateAccountBalance()
        {
            DateTime date = DateTime.Today;
            return CalculateAccountBalance(date);
        }

        public virtual decimal CalculateInterest(DateTime date)
        {
            if (date != null)
            {
                decimal value = 0;
                decimal interest = 0;
                DateTime nextTransaction = new DateTime();
                TimeSpan daysUntilNext = new TimeSpan();
                for(int i = 0; i < TransactionLog.Count; i++)
                {
                    if (TransactionLog[i].TransactionDate <= date)
                    {
                        if(i + 1 >= TransactionLog.Count)
                        {
                            nextTransaction = date;
                        }
                        else
                        {
                            nextTransaction = TransactionLog[i + 1].TransactionDate;
                        }
                        daysUntilNext = nextTransaction - TransactionLog[i].TransactionDate;
                        if (daysUntilNext.Days > 0)
                        {
                            if (TransactionLog[i].TransactionValue > 0)
                            {
                                value += TransactionLog[i].TransactionValue;
                                interest += (((value / 100) * InterestRate) * daysUntilNext.Days);
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

        public virtual decimal CalculateInterest()
        {
            return CalculateInterest(DateTime.Today);
        }

        #endregion "Calculate balance methods"

        #region "Account status methods"

        public string OpenAccount()
        {
            StringBuilder output = new StringBuilder();
            if(IsOpen)
            {
                output.AppendLine($"This account is already open!");
            }
            else
            {
                output.AppendLine($"This account has been opened");
                IsOpen = true;
            }
            return output.ToString();
        }

        public string CloseAccount()
        {
            StringBuilder output = new StringBuilder();
            if (IsOpen)
            {
                output.AppendLine($"This account has been closed");
                IsOpen = false;
            }
            else
            {
                output.AppendLine($"This account is already closed!");
            }
            return output.ToString();
        }

        public string GetAccountStatus()
        {
            StringBuilder output = new StringBuilder();
            if(IsOpen)
            {
                output.AppendLine($"This account is currently open");
            }
            else
            {
                output.AppendLine($"This account is currently closed");
            }
            return output.ToString();
        }

        #endregion "Account status methods"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Account number: {AccountNumber:'BE'000000}");
            output.AppendLine($"{GetAccountStatus()}");
            output.AppendLine($"This account was opened on: {OpenAccountDate:yyyy-MM-dd}");
            output.AppendLine($"The account balance total is: \u20AC {CalculateAccountBalance():N}");
            output.AppendLine($"The interest rate on this account is: {InterestRate:P}");
            if(TransactionLog.Count != 0)
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
