using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{

    internal class ManageAccount : IMenu
    {
        private List<Account> listAccount;
        public IReadOnlyCollection<Account> ListAccount { get { return listAccount.AsReadOnly(); } }

        public ManageAccount()
        {
         if(listAccount == null)
            listAccount = new List<Account>();

        }
        public ManageAccount(Account account)
        {
            if (listAccount == null)
                listAccount = new List<Account>();
            listAccount.Add(account);
        }

        public void Display()
        {
            
            Console.WriteLine("\t\t\t\t\t===============Manage Account===============");
            Console.WriteLine("\t\t\t\t\t#           1. Add account                 #");
            Console.WriteLine("\t\t\t\t\t#           2. Update account              #");
            Console.WriteLine("\t\t\t\t\t#           3. Delete account              #");
            Console.WriteLine("\t\t\t\t\t#           4. Search account              #");
            Console.WriteLine("\t\t\t\t\t#           5. Display accounts            #");
            Console.WriteLine("\t\t\t\t\t#           6. Exit                        #");
            Console.WriteLine("\t\t\t\t\t============================================");
           
        }
        public string SelectMenu()
        {
            Console.Write("\t\t\t\t\t => Enter your option: ");
            string option = Console.ReadLine();         
            Account account = new Account();
            switch (option)
            {
                case "1":
                    Console.Write("\t\t\t\t\t => Please enter the number of accounts:");
                    int NumberOfAccount = int.Parse(Console.ReadLine());
                    /*int newAccountNumber;
                    if (listAccount.Count>0)
                    {
                        Account lastAccount = listAccount[listAccount.Count - 1];
                        newAccountNumber = lastAccount.AccountNumber;
                    }
                    else
                    {
                        newAccountNumber = 10001;   
                    } */
                    for (int i = 1; i <= NumberOfAccount; i++)
                    {                                             
                        Console.Write("\t\t\t\t\t\tEnter account number: ");
                        int numberAccount = int.Parse(Console.ReadLine());
                        Console.Write("\t\t\t\t\t\tEnter account name: ");
                        string nameAccount = Console.ReadLine();
                        Console.Write("\t\t\t\t\t\tEnter account balance: ");
                        double accountBalance = int.Parse(Console.ReadLine());
                        Console.Write("\t\t\t\t\t\tEnter account type: ");
                        string typeAccount = Console.ReadLine();
                        Console.Write("\t\t\t\t\t\tEnter desctription account type: ");
                        string desctriptionType = Console.ReadLine();
                        AccountType accountType = new AccountType(typeAccount, desctriptionType);

                        account = new Account(numberAccount,nameAccount, accountBalance, accountType);
                        listAccount.Add(account);
                        this.DisplayInforList();
                        /*Console.WriteLine(readOnlyAccounts);*/
                        Console.WriteLine("\t\t\t\t\t\t\t===============");
                    }
                  /*  this.DisplayInforList();*/
                   /* Console.WriteLine(ListAccount);*/
                 
                    
                    Console.ReadKey();
                    Console.Clear();
                    return "manageaccount";
                    break;

                case "2":
                    Console.WriteLine("Updating a account");
                    Console.Clear();
                    return "manageaccount";
                    break;

                case "3":
                    Console.WriteLine("Deleting a account");
                    Console.Clear();
                    return "manageaccount";
                    break;

                case "4":
                    Console.WriteLine("Search a account");
                    Console.Clear();
                    return "manageaccount";
                    break;
                case "5":
                   this.DisplayInforList();
                    foreach (var a in ListAccount)
                    {
                        a.printInfor();
                    }
                    Console.ReadKey();


                    Console.Clear();
                    return "manageaccount";
                    break;
                case "6":
                    Console.Clear();
                    return "main";
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    return "manageaccount";
                    break;
            }

        }
        public void DisplayInforList()
        {
            Console.WriteLine("List accouts: ");

            foreach (var a in ListAccount )
            {
                a.printInfor();
            }
            Console.ReadKey();
        }
    }
}
