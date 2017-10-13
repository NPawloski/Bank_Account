using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Client
    {
        //create client info
        private string name;
        private int clientNumber;
        private int yearsCustomer;


        //returns client name
        public string Name
        {
            get { return this.name; }
        }

        //returns client number
        public int ClientNumber
        {
            get { return this.clientNumber; }
        }

        //constructor
        public Client()
        {

        }

        public Client(string name,int clientNumber)
        {
            this.name = name;
            this.clientNumber = clientNumber;
            yearsCustomer = 1;
        }

        //prints out clients info

        public string GetClientInfo()
        {
            return "Name: " + name + " Client Number: " + clientNumber + " Customer for " + yearsCustomer + " years. \n"; 
        }







    }
}

