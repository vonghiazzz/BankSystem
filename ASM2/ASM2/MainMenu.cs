using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    internal class MainMenu: IMenu
    {
        public void Display()
        {
            Console.WriteLine("\t\t\t\t\t===============Main MENU===============");
            Console.WriteLine("\t\t\t\t\t#      1. Manage account              #");
            Console.WriteLine("\t\t\t\t\t#      2. Manage customer             #");
            Console.WriteLine("\t\t\t\t\t#      3. Manage employee             #");
            Console.WriteLine("\t\t\t\t\t#      4. Manage bank                 #");
            Console.WriteLine("\t\t\t\t\t#      5. Exit                        #");
            Console.WriteLine("\t\t\t\t\t=======================================");

        }
        public string SelectMenu()
        {
            Console.Write("\t\t\t\t\t => Enter your option: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    return "manageaccount";
                    break;

                case "2":
                    return "manageauthors";
                    break;
                case "3":
                    return "manageaccount";
                    break;
                case "4":
                    return "exit";
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    return "main";
                    break;
            }


        }
    }
}
