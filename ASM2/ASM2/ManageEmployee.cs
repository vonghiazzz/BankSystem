using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    internal class ManageEmployee : IMenu
    {
        public void Display()
        {
            Console.WriteLine("\t\t\t\t\t===============Manage Employee===============");
            Console.WriteLine("\t\t\t\t\t#           1. Add a employee               #");
            Console.WriteLine("\t\t\t\t\t#           2. Update a employee            #");
            Console.WriteLine("\t\t\t\t\t#           3. Delete a employee            #");
            Console.WriteLine("\t\t\t\t\t#           4. Search a employee            #");
            Console.WriteLine("\t\t\t\t\t#           5. Display all employees        #");
            Console.WriteLine("\t\t\t\t\t#           6. Exit                         #");
            Console.WriteLine("\t\t\t\t\t=============================================");

        }
        public string SelectMenu()
        {
            Console.Write("\t\t\t\t\t => Enter your option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Adding a employee");
                    Console.Clear();
                    return "manageemployee";
                    break;

                case "2":
                    Console.WriteLine("Updating a employee");
                    Console.Clear();
                    return "manageemployee";
                    break;

                case "3":
                    Console.WriteLine("Deleting a employee");
                    Console.Clear();
                    return "manageemployee";
                    break;

                case "4":
                    Console.WriteLine("Search a employee");
                    Console.Clear();
                    return "manageemployee";
                    break;
                case "5":
                    Console.WriteLine("Display all employees");
                    Console.Clear();
                    return "manageemployee";
                    break;
                case "6":
                    Console.Clear();
                    return "main";
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    return "manageemployee";
                    break;
            }
        }
    }
}