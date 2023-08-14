using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    internal class ManageAuthorsMenu:IMenu
    {
        public void Display()
        {
            Console.WriteLine("Manage Authors:");
            Console.WriteLine("1. Add Author");
            Console.WriteLine("2. Update Author");
            Console.WriteLine("3. Delete Author");
            Console.WriteLine("4. Back to Main Menu");

        }
        public string SelectMenu()
        {
            Console.WriteLine("Enter the option you want to perform:");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Adding an author...");
                    return "manageauthors";
                    break;

                case "2":
                    Console.WriteLine("Updating an author...");
                    return "manageauthors";
                    break;

                case "3":
                    Console.WriteLine("Deleting an author...");
                    return "manageauthors";
                    break;

                case "4":
                    return "main";
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    return "manageauthors";
                    break;
            }
        }
    }
}
