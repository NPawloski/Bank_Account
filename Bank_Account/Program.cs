using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables to take in user input
            string name;
            int cliNum;
            int accNum;
            decimal initDeposit;
            bool exit = false;
            string whatToDo;

            ////taking in user info
            //Console.WriteLine("Please enter your name.");
            //name = Console.ReadLine();

            //Console.WriteLine("Please enter your client number.");
            //cliNum = int.Parse(Console.ReadLine());


            //instansiate client
            Client client1 = new Client("client1", 13247);

            ////take in clients account info
            //Console.WriteLine("Please enter your account number.");
            //accNum = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter your initial deposit.");
            //initDeposit = decimal.Parse(Console.ReadLine());


            //create checking account
            Checking checking1 = new Checking(11214, 1000m);

            //create savings account
            Savings savings1 = new Savings(11214, 1000m);

            while (exit == false)
            {
                //ask user what to do
                Console.WriteLine("1. View Client Information \n2. View Account Balance \n3. Depsite Funds \n4. Withdraw Funds \n5. Exit");
                whatToDo = Console.ReadLine();

                //used to take in user input for sub menus
                string submenu;

                switch (whatToDo)
                {
                    //show user info
                    case "1":
                        Console.WriteLine(client1.GetClientInfo());
                        break;

                        //show account balances
                    case "2":
                        Console.WriteLine("1. Checking \n2. Savings");
                        submenu = Console.ReadLine();
                        if (submenu == "1")
                        {
                            Console.WriteLine("$" + checking1.Balance);
                        }
                        else if (submenu == "2")
                        {
                            Console.WriteLine("$" + savings1.Balance);
                        }
                        break;

                        //make deposite
                    case "3":
                        Console.WriteLine("1. Checking \n2. Savings");
                        submenu = Console.ReadLine();
                        if (submenu == "1")
                        {
                            Console.WriteLine("Please enter the amount to deposit");
                            checking1.Deposit(decimal.Parse(Console.ReadLine()));
                        }
                        else if (submenu == "2")
                        {
                            Console.WriteLine("Please enter the amount to deposit");
                            savings1.Deposit(decimal.Parse(Console.ReadLine()));
                        }
                        break;

                        //make withdraws
                    case "4":
                        Console.WriteLine("1. Checking \n2. Savings");
                        submenu = Console.ReadLine();
                        if (submenu == "1")
                        {
                            Console.WriteLine("Please enter the amount to withdraw");
                            checking1.Withdraw(decimal.Parse(Console.ReadLine()));
                        }
                        else if (submenu == "2")
                        {
                            Console.WriteLine("Please enter the amount to withdraw");
                            savings1.Withdraw(decimal.Parse(Console.ReadLine()));
                        }
                        break;


                        //exit application
                    case "5":
                        Environment.Exit(0);
                        break;

                        //does nothing if user enters invalid input                   
                    default:
                        break;
                }



            }

        }
    }
}
