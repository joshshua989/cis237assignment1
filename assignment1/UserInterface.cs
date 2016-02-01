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
            int userSelection;

            PrintMenu();

            try
            { userSelection = int.Parse(Console.ReadLine()); }
            catch
            { userSelection = 0; }

            if (CSVProcessor.fileLoaded == true)
            {
                while ((userSelection != 1) && (userSelection != 2) && (userSelection != 3)
                        && (userSelection != 4))
                {
                    Console.Clear();
                    Console.WriteLine("**ERROR**");
                    Console.WriteLine("INVALID ENTRY!");
                    Console.WriteLine("PLEASE TRY AGAIN.");
                    Console.WriteLine(Environment.NewLine);

                    PrintMenu();
                    try
                    { userSelection = int.Parse(Console.ReadLine()); }
                    catch
                    { userSelection = 0; }
                }
                return (userSelection + 1);
            }
            else
            {
                while ((userSelection != 1) && (userSelection != 2) && (userSelection != 3)
                        && (userSelection != 4) && (userSelection != 5))
                {
                    Console.Clear();
                    Console.WriteLine("**ERROR**");
                    Console.WriteLine("INVALID ENTRY!");
                    Console.WriteLine("PLEASE TRY AGAIN.");
                    Console.WriteLine(Environment.NewLine);

                    PrintMenu();
                    try
                    { userSelection = int.Parse(Console.ReadLine()); }
                    catch
                    { userSelection = 0; }
                }
                return (userSelection);
            }
            
        }

        public static void PrintMenu()
        {
            if (CSVProcessor.fileLoaded == true)
            {
                Console.WriteLine("What do you wish to do now?");
                Console.WriteLine("[1]  ADD ITEM");
                Console.WriteLine("[2]  SEARCH ITEM(S)");
                Console.WriteLine("[3]  LIST ITEM(S)");
                Console.WriteLine("[4]  EXIT" + Environment.NewLine);
                Console.Write("YOUR SELECTION:  ");
            }
            else
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
}