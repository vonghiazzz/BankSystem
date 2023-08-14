using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    internal class ManageAccountType:IMenu
    {
        public void Display()
        {
            Console.WriteLine("\t\t\t\t\t============Manage Account Type=============");
            Console.WriteLine("\t\t\t\t\t#           1. Add a account               #");
            Console.WriteLine("\t\t\t\t\t#           2. Update a account            #");
            Console.WriteLine("\t\t\t\t\t#           3. Delete a account            #");
            Console.WriteLine("\t\t\t\t\t#           4. Search a account            #");
            Console.WriteLine("\t\t\t\t\t#           5. Display all accounts        #");
            Console.WriteLine("\t\t\t\t\t#           6. Exit                        #");
            Console.WriteLine("\t\t\t\t\t============================================");

        }
        public string SelectMenu()
        {
            Console.Write("\t\t\t\t\t => Enter your option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Adding a account type");
                    Console.Clear();
                    return "manageaccounttype";
                    break;

                case "2":
                    Console.WriteLine("Updating a account type");
                    Console.Clear();
                    return "manageaccounttype";
                    break;

                case "3":
                    Console.WriteLine("Deleting a account type");
                    Console.Clear();
                    return "manageaccounttype";
                    break;

                case "4":
                    Console.WriteLine("Search a account type");
                    Console.Clear();
                    return "manageaccounttype";
                    break;
                case "5":
                    Console.WriteLine("Display account types");
                    Console.Clear();
                    return "manageaccounttype";
                    break;
                case "6":
                    Console.Clear();
                    return "main";
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    return "manageaccounttype";
                    break;
            }
        }
    }
}
