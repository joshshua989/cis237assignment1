// JOSHUA D ELLEN
// CIS 237
// 02-01-2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        // INT HANDLE THAT RECORDS USER INPUT FOR MENU OPTIONS
        static int userSelection;

        // MAIN LINE
        static void Main(string[] args)
        {
            // WELCOME MESSAGE - DISPLAYS ONCE
            Console.WriteLine("WELCOME TO ~Wine Collection v1.0~!");
            Console.WriteLine("**********************************");
            Console.WriteLine("COMPANY:  CIS 237 [Advanced C#]");
            Console.WriteLine("DEVELOPER:  Joshua D. Ellen");
            Console.WriteLine("ASSIGNMENT:  1");
            Console.WriteLine("DATE:  02/01/2016");
            Console.WriteLine("-----------------------------------" + Environment.NewLine);
            
            // CALL MAIN MENU PROMPT
            MainPrompt();
        }

        public static void MainPrompt()
        {
            // PRINT MENU AND COLLECT USER INPUT - STORES IN VARIABLE 'USERSELECTION'
            userSelection = UserInterface.GetUserInput();

            // CALL SWITCH STATEMENT TO CONTROL PATH FOR USER SELECTION
            SelectionHandler();
        }

        // SWITCH STATEMENT TO HANDLE USER INPUT FOR MENU OPTIONS
        static void SelectionHandler()
        {
            switch (userSelection)
            {
                case 1:
                    // LOADS CSV FILE
                    CSVProcessor process = new CSVProcessor();
                    break;
                case 2:

                    break;
                case 3:
                    
                    break;
                case 4:
                    // CLEAR TERMINAL SCREEN
                    Console.Clear();

                    // DISPLAYS A LIST OF WINE ITEMS TO TERMINAL
                    WineItemCollection.ListItems();
                    break;
                case 5:
                    // TERMINATES THE APPLICATION
                    Environment.Exit(0);
                    break;
            }
        }
    }
}