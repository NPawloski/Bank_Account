using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Savings : Account
    {


        //declare the minimum balance allowed
        private decimal minBalance = 500.00m;

        //constructor
        public Savings()
        {

        }

        public Savings(int accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            accountType = "Savings";
        }


        //withdraw method
        public override void Withdraw(decimal withdraw)
        {
            //make sure account doesnt go below minimum balance
            if (balance - withdraw < minBalance)
            {
                Console.WriteLine("You cant make this withdrawl, the account balance will go too low");
            }
            else
            {
                base.Withdraw(withdraw);
            }

        }








    }
}
