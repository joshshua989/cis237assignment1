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
        // HANDLE TO DETERMINE WHETHER FILE HAS BEEN LOADED OR NOT
        public static bool fileLoaded;
        // COUNTER VARIABLE
        private int index;

        // LISTS TO STORE FILE VALUES
        public static List<string> idList = new List<string>();
        public static List<string> descriptionList = new List<string>();
        public static List<string> packList = new List<string>();


        // LOCATION OF DATA FILE
        private StreamReader reader = new StreamReader(
            File.OpenRead(@"../../../datafiles/WineList.csv")
            );

        // CSV FILE PROCESSOR - READ IN
        public CSVProcessor()
        {
            WineItemCollection.wineList = new string[6000];
            index = 0;

            // WHILE THERE IS STILL DATA TO BE READ IN..CONTINUE LOOP
            while (!reader.EndOfStream)
            {
                // READ DATA LINE INTO VARIABLE: 'LINE'
                var line = reader.ReadLine();
                // 'VALUES' VARIABLE WILL SPLIT DATA IN 'LINE' VARIABLE
                var values = line.Split(',');

                // ADD DATA TO LISTS
                idList.Add(values[0]);
                descriptionList.Add(values[1]);
                packList.Add(values[2]);
                
                WineItem wineItem = new WineItem(values[0], values[1], values[2]);
                index++;
            }

            // ARBITRARY MSG TO DISPLAY ONCE FILE LOAD IS COMPLETE
            Console.WriteLine("100%...File Load Complete!");
            Console.WriteLine(Environment.NewLine);
            // ADJUST FILE LOAD HANDLE
            fileLoaded = true;
            // REPROMPT USER FOR INPUT
            Program.MainPrompt();
        }
    }
}
