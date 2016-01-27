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
        private StreamReader reader = new StreamReader(
            File.OpenRead(@"    C:\Users\Josh\Documents\GitHub\cis237assignment1\datafiles\WineList.csv     ")
            );

        public CSVProcessor()
        {
            List<string> idList = new List<string>();
            List<string> descriptionList = new List<string>();
            List<string> packList = new List<string>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                idList.Add(values[0]);
                descriptionList.Add(values[1]);
                packList.Add(values[2]);
            }

            Console.WriteLine("100%...File Load Complete!");
        }
    }
}
