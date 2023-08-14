using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    internal class ManageBooksMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Manage Books:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Update Book");
            Console.WriteLine("3. Delete Book");
            Console.WriteLine("4. Back to Main Menu");

        }
        public string SelectMenu()
        {
            Console.Write("Enter the option you want to perform:");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Adding a book...");
                    return "managebooks";
                    break;

                case "2":
                    Console.WriteLine("Updating a book...");
                    return "managebooks";
                    break;

                case "3":
                    Console.WriteLine("Deleting a book...");
                    return "managebooks";
                    break;

                case "4":
                    return "main";
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    return "managebooks";
                    break;
            }
        }
    }
}
