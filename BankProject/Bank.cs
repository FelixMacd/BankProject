using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject
{
    class Bank
    {
        private string name;
        private const int MAX_ACCOUNT = 100;
        private Account[] accounts;
        private int accountsCreated = 0;

        public Bank(string n)
        {
            name = n;
            accounts = new Account[MAX_ACCOUNT];

        }

        public int createAccount(string name, string address, string type)
        {
            int accNo=-1;
            // Check type of account requird
            // create account
            // add to array at position accountsCreated.
            // check not out of range

            return accNo;
        }

        public bool withdraw(int a, double amount)
        {
            // check a < accounts created
            // accounts[a].withdraw(amount);

        }

        public void deposit(int a, double amount)
        {


        }

        public void printBalance(int accNo)
        {


        }





    }
}
