using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static int userSelection;

        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO ~Wine Collection v1.0~!");
            Console.WriteLine("**********************************");
            Console.WriteLine("COMPANY:  CIS 237 [Advanced C#]");
            Console.WriteLine("DEVELOPER:  Joshua D. Ellen");
            Console.WriteLine("ASSIGNMENT:  1");
            Console.WriteLine("DATE:  02/01/2016");
            Console.WriteLine("-----------------------------------" + Environment.NewLine);
            
            MainPrompt();
        }

        public static void MainPrompt()
        {
            userSelection = UserInterface.GetUserInput();
            SelectionHandler();
        }

        static void SelectionHandler()
        {
            switch (userSelection)
            {
                case 1:
                    CSVProcessor process = new CSVProcessor();
                    break;
                case 2:

                    break;
                case 3:
                    
                    break;
                case 4:
                    Console.Clear();
                    WineItemCollection.ListItems();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}