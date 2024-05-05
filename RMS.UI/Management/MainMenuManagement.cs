using RMS.DAL.Models.Enums;
using RMS.UI.Management.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.UI.Management
{
    public class MainMenuManagement
    {
        public int MainMenu()
        {
            int selection = 0;
            do
            {
                Console.WriteLine("\nMAIN MENU \n");
                Console.WriteLine("1. Restaurant management.");
                Console.WriteLine("2. Customer management.");
                Console.WriteLine("3. Employee management.");
                Console.WriteLine("4. Food management.");
                Console.WriteLine("5. Menu management.");
                Console.WriteLine("6. Quit");
                Console.WriteLine("\nYour selection:");
                selection = int.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (selection > 6 || selection < 1);
            return selection;
        }
        public int SubMenu(int selectionType)
        {
            int selection = 0;
            string menuName = ((ManagementType)selectionType).ToString();
            do
            {
                Console.WriteLine($"\n{menuName} Menu \n");
                Console.WriteLine($"1. {menuName} Add.");
                Console.WriteLine($"2. {menuName} Get all.");
                Console.WriteLine($"3. {menuName} Get.");
                Console.WriteLine($"4. {menuName} Delete.");
                Console.WriteLine($"5. {menuName} Update.");
                Console.WriteLine($"6. Quit");
                Console.WriteLine("\nYour selection:");
                selection = int.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (selection > 6 || selection < 1);
            return selection;
        }


    }

}