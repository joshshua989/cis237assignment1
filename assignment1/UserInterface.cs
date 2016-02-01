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
            // HANDLE USED TO STORE USER INPUT
            int userSelection;

            // DISPLAY OPTION MENU ON TERMINAL SCREEN
            PrintMenu();

            try
            // PARSE USER INPUT INTO VARIABLE
            { userSelection = int.Parse(Console.ReadLine()); }
            catch
            // IF BAD INPUT, SELECTION = DEFAULT VALUE
            { userSelection = 0; }

            // IF FILE ALREADY LOADED, DO NOT DISPLAY 'LOAD FILE' OPTION
            if (CSVProcessor.fileLoaded == true)
            {
                // IF USER DOES NOT SELECT A VALID INPUT, SHOW ERROR MSG, LOOP CONTINUES
                while ((userSelection != 1) && (userSelection != 2) && (userSelection != 3)
                        && (userSelection != 4))
                {
                    Console.Clear();
                    Console.WriteLine("**ERROR**");
                    Console.WriteLine("INVALID ENTRY!");
                    Console.WriteLine("PLEASE TRY AGAIN.");
                    Console.WriteLine(Environment.NewLine);

                    // REPRINT MENU OPTIONS
                    PrintMenu();
                    try
                    // PARSE IN USER SELECTION
                    { userSelection = int.Parse(Console.ReadLine()); }
                    catch
                    // DEFAULT VALUE IN BAD INPUT
                    { userSelection = 0; }
                }
                // RETURN USER SELECTION, HOWEVER 1 MUST BE ADDED TO THE VALUE TO COMPENSATE
                // FOR THE LOST MENU OPTION
                return (userSelection + 1);
            }
            else
            {
                // LOOP THAT WILL CONTINUE IF BAD INPUT IN MADE BY USER
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
                // IF GOOD INPUT, RETURN SELECTION
                return (userSelection);
            }
            
        }

        public static void PrintMenu()
        {
            // MENU OPTIONS TO DISPLAY IF FILE IS ALREADY LOADED
            if (CSVProcessor.fileLoaded == true)
            {
                Console.WriteLine("What do you wish to do now?");
                Console.WriteLine("[1]  ADD ITEM");
                Console.WriteLine("[2]  SEARCH ITEM(S)");
                Console.WriteLine("[3]  LIST ITEM(S)");
                Console.WriteLine("[4]  EXIT" + Environment.NewLine);
                Console.Write("YOUR SELECTION:  ");
            }
            // MENU OPTIONS TO DISPLAY IF FILE IS NOT ALREADY LOADED
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