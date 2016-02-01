using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        public static bool fileLoaded;
        private int index;

        private StreamReader reader = new StreamReader(
            File.OpenRead(@"../../../datafiles/WineList.csv")
            );

        public CSVProcessor()
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                string id = values[0];
                string description = values[1];
                string pack = values[2];

                WineItem wineItem = new WineItem(id, description, pack);
                WineItemCollection.wineList[index];
                index++;
            }

            Console.WriteLine("100%...File Load Complete!");
            Console.WriteLine(Environment.NewLine);
            fileLoaded = true;
            Program.MainPrompt();
        }
    }
}
