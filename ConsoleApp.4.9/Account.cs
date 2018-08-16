using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._4._9
{
    class Account
    {
        private decimal balance;

        public Account(string accountName, decimal initialBalance)
        {
            Name = accountName;
            Balance = initialBalance;
        }

        public string Name
        {
            get;
            set;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }

            private set
            {
                if(value > 0.0m)
                {
                    balance = value;
                }
            }
        }

        public void Deposit(decimal depositAmount)
        {
            if(depositAmount > 0.0m)
            {
                Balance = Balance + depositAmount;
            }
        }

        public void Withdraw(decimal amount)
        {
            if(amount < Balance)
            {
                Balance = Balance - amount;
            }
        }
    }
}
