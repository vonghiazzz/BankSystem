using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    internal class MenuFactory
    {
        public static IMenu CreateMenu(string menuType)
        {
            switch (menuType.ToLower())
            {
                case "main":
                    return new MainMenu();

                case "managebooks":
                    return new ManageBooksMenu();

                case "manageauthors":
                    return new ManageAuthorsMenu();
                case "manageaccount":
                    return new ManageAccount();
                case "manageaccounttype":
                    return new ManageAccountType();
                case "manageemployee":
                    return new ManageEmployee();
                case "managecustomer":
                    return new ManageCustomer();
                default:
                    throw new ArgumentException("Invalid menu type.");
            }
        }
    }
}
