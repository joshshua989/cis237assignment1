using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        public static int GetUserInput()
        {
            int selection;

            try
            {
                selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        return 1;
                        break;
                    case 2:
                        return 2;
                        break;
                    case 3:
                        return 3;
                        break;
                    case 4:
                        return 4;
                        break;
                    case 5:
                        return 5;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("**ERROR! Entry was not within specified range!");
                        Console.WriteLine("**Please try again...");
                        Console.WriteLine(Environment.NewLine);
                        PrintMenu();
                        GetUserInput();
                        break;
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("**ERROR! You must enter an integer value!");
                Console.WriteLine("**Please try again...");
                Console.WriteLine(Environment.NewLine);
                PrintMenu();
                GetUserInput();
            }
            return 0;
        }

        public static void PrintMenu()
        {
            Console.WriteLine("Please choose from the following options:");
            Console.WriteLine("[1]  LOAD FILE");
            Console.WriteLine("[2]  ADD ITEM");
            Console.WriteLine("[3]  SEARCH ITEM(S)");
            Console.WriteLine("[4]  LIST ITEM(S)");
            Console.WriteLine("[5]  EXIT" + Environment.NewLine);
            Console.Write("YOUR SELECTION:  ");
        }
    }
}
