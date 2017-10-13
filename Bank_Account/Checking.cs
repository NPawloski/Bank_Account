using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Checking : Account
    {

        //constructor
        public Checking()
        {

        }

        public Checking(int accountNumber,decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            accountType = "Checking";
        }








    }
}
