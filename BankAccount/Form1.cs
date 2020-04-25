using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        BankAccount BankAccount = new BankAccount(0);
        public Form1()
        {
            InitializeComponent();
            tbAccount.Text = $"{BankAccount}";
        }

        private void btDepositOrWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                if (nudDeposit.Value >= 0)
                {
                    BankAccount.DepositMoney(nudDeposit.Value);
                }
                else
                {
                    BankAccount.WithdrawMoney(nudDeposit.Value);
                }
                tbAccount.Text = $"{BankAccount}";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Invalid amount", MessageBoxButtons.OK);
            }
        }

        private void nudDeposit_ValueChanged(object sender, EventArgs e)
        {
            if(nudDeposit.Value >= 0)
            {
                lblDepositOrWithdraw.Text = "Deposit money";
                btDepositOrWithdraw.Text = "Deposit money";
            }
            else
            {
                lblDepositOrWithdraw.Text = "Withdraw money";
                btDepositOrWithdraw.Text = "Withdraw money";
            }
        }
    }
}
