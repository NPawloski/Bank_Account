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
            bool exit = false;
            bool changeUser = true;
            string whatToDo;
            int currentUser = 0;

            List<string> userNames = new List<string>();

            List<Client> clients = new List<Client>();
            List<Checking> checkingAccounts = new List<Checking>();
            List<Savings> savingsAccounts = new List<Savings>();





            while (exit == false)
            {

                while (changeUser == true)
                {
                    //taking in user info
                    Console.WriteLine("Please enter your username.");
                    name = Console.ReadLine().ToUpper();

                    //check to see if username already exists
                    if (userNames.Contains(name) == true)
                    {
                        currentUser = userNames.IndexOf(name);
                        changeUser = false;
                    }
                    //if username does not exist, add it to the list and create the account
                    else
                    {
                        Console.WriteLine("Please enter your client number.(6 digits)");
                        cliNum = int.Parse(Console.ReadLine());

                        currentUser = userNames.Count;

                        userNames.Add(name);

                        //instansiate client
                        clients.Add(new Client(name,cliNum));


                        //create checking account
                        checkingAccounts.Add(new Checking(cliNum, 1000m));

                        //create savings account
                        savingsAccounts.Add(new Savings(cliNum, 1000m));

                        changeUser = false;
                    }
                }


                //ask user what to do
                Console.WriteLine("1. View Client Information \n2. View Account Balance \n3. Depsite Funds \n4. Withdraw Funds \n5. Exit");
                whatToDo = Console.ReadLine();

                //used to take in user input for sub menus
                string submenu;

                switch (whatToDo)
                {
                    //show user info
                    case "1":
                        Console.WriteLine(clients[currentUser].GetClientInfo());
                        break;

                    //show account balances
                    case "2":
                        Console.WriteLine("1. Checking \n2. Savings");
                        submenu = Console.ReadLine();
                        if (submenu == "1")
                        {
                            Console.WriteLine("$" + checkingAccounts[currentUser].Balance);
                        }
                        else if (submenu == "2")
                        {
                            Console.WriteLine("$" + savingsAccounts[currentUser].Balance);
                        }
                        break;

                    //make deposite
                    case "3":
                        Console.WriteLine("1. Checking \n2. Savings");
                        submenu = Console.ReadLine();
                        if (submenu == "1")
                        {
                            Console.WriteLine("Please enter the amount to deposit");
                            checkingAccounts[currentUser].Deposit(decimal.Parse(Console.ReadLine()));
                        }
                        else if (submenu == "2")
                        {
                            Console.WriteLine("Please enter the amount to deposit");
                            savingsAccounts[currentUser].Deposit(decimal.Parse(Console.ReadLine()));
                        }
                        break;

                    //make withdraws
                    case "4":
                        Console.WriteLine("1. Checking \n2. Savings");
                        submenu = Console.ReadLine();
                        if (submenu == "1")
                        {
                            Console.WriteLine("Please enter the amount to withdraw");
                            checkingAccounts[currentUser].Withdraw(decimal.Parse(Console.ReadLine()));
                        }
                        else if (submenu == "2")
                        {
                            Console.WriteLine("Please enter the amount to withdraw");
                            savingsAccounts[currentUser].Withdraw(decimal.Parse(Console.ReadLine()));
                        }
                        break;


                    //    //allows user to chnge accounts or make a new one
                    //case "5":
                    //    changeUser = true;
                    //    break;

                    //exit application
                    case "5":
                        exit = true;
                        break;

                    //does nothing if user enters invalid input                   
                    default:
                        break;
                }



            }

        }


    }
}
