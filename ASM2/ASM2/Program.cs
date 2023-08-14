using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public interface IMenu
    {
        void Display();
        string SelectMenu();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IMenu Menu = MenuFactory.CreateMenu("main");
            while (true)
            {
                // Hiển thị Main Menu và chọn loại menu cần quản lý
                Menu.Display();
                string menuType = Menu.SelectMenu();
                Menu = MenuFactory.CreateMenu(menuType);


            }
        }
        
    }
}
