using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    abstract class Account
    {

        //declare account info
        protected int accountNumber;
        protected decimal balance;
        protected string accountType;

        //shows account balance
        public decimal Balance
        {
            get { return this.balance; }
        }

        //deposit method
        public virtual void Deposit(decimal deposit)
        {

            balance += deposit;
        }

        //withdraw method
        public virtual void Withdraw(decimal withdraw)
        {
            //make sure you dont withdraw more than is in the account
            if (balance - withdraw < 0)
            {
                Console.WriteLine("Not enough money in account.");
            }
            else
            {
                balance -= withdraw;
            }
        }













    }
}
