using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    internal class Account
    {
       /* private static int id = 100000;*/
        /*public static readonly int ID = accountNumber++;*/
        private int accountNumber;


        private string accountName;
        private double accountBalance;
        private AccountType accountType;

        public int AccountNumber { get { return accountNumber; } set { accountNumber = value; } }

        public string AccountName { get { return accountName; } set { accountName = value; } }

        public double AccountBalance { get { return accountBalance; } set { accountBalance = value; } }


        public AccountType AccountType { get { return accountType; } set { accountType = value; } }


        public Account(int accountNumber, string accountName, double accountBalance, AccountType accountType)
        {
           this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.accountBalance = accountBalance;
            this.accountType = accountType;
        }

        public Account()
        {
            this.accountNumber = 0;
            this.accountName = "";
            this.accountBalance = 0;
            this.accountType = new AccountType();
        }



        public void printInfor()
        {
            Console.WriteLine("\t\t\t\t\t\tAccount Number: " + this.accountNumber);
            Console.WriteLine("\t\t\t\t\t\tAccount Name: " + this.accountName);
            Console.WriteLine("\t\t\t\t\t\tAccount Balance: " + this.accountBalance);
            Console.WriteLine("\t\t\t\t\t\tAccount type: " + AccountType.TypeCode + ":" + AccountType.TypeCodeDescription);
            Console.WriteLine('\n');
        }
        public void add(Account account)
        {
            Account account1 = new Account();
            account.add(account1);
        }
    }
}
