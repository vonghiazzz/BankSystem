using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    internal class ManageCustomer : IMenu
    {
        public void Display()
        {
            Console.WriteLine("\t\t\t\t\t===============Manage Customer================");
            Console.WriteLine("\t\t\t\t\t#           1. Add a customer                #");
            Console.WriteLine("\t\t\t\t\t#           2. Update a customer             #");
            Console.WriteLine("\t\t\t\t\t#           3. Delete a customer             #");
            Console.WriteLine("\t\t\t\t\t#           4. Search a customer             #");
            Console.WriteLine("\t\t\t\t\t#           5. Display all customers         #");
            Console.WriteLine("\t\t\t\t\t#           6. Exit                          #");
            Console.WriteLine("\t\t\t\t\t==============================================");
        }
        public string SelectMenu()
        {
            Console.Write("\t\t\t\t\t => Enter your option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Adding a customer");
                    Console.Clear();
                    return "managecustomer";
                    break;

                case "2":
                    Console.WriteLine("Updating a customer");
                    Console.Clear();
                    return "managecustomer";
                    break;

                case "3":
                    Console.WriteLine("Deleting a customer");
                    Console.Clear();
                    return "managecustomer";
                    break;

                case "4":
                    Console.WriteLine("Search a customer");
                    Console.Clear();
                    return "managecustomer";
                    break;
                case "5":
                    Console.WriteLine("Display all customers");
                    Console.Clear();
                    return "managecustomer";
                    break;
                case "6":
                    Console.Clear();
                    return "main";
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    return "managecustomer";
                    break;
            }
        }
    }
}
