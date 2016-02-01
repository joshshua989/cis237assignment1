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

        public static void ListItems()
        {
            int index = 0;
            foreach (string e in WineItemCollection.wineList)
            {
                var line = WineItemCollection.wineList[index];
                Console.WriteLine(line.Split(','));
                index++;
            }

            Console.WriteLine(Environment.NewLine);
            Program.MainPrompt();
        }
    }
}




                    
