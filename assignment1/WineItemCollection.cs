using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        public static string[] wineList;

        // CALLED FROM MENU -- WRITE DATA FILE INFO TO SCREEN
        public static void ListItems()
        {
            for (int index = 0; index < CSVProcessor.idList.Count; index++)
            {
                Console.WriteLine("         ID:  " + CSVProcessor.idList[index]);
                Console.WriteLine("DESCRIPTION:  " + CSVProcessor.descriptionList[index]);
                Console.WriteLine("  PACK SIZE:  " + CSVProcessor.packList[index]);
                Console.WriteLine();
            }

            Console.WriteLine(Environment.NewLine);
            // CALL USER PROMPT MENU
            Program.MainPrompt();
        }
    }
}




                    
