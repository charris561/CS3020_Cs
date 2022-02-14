using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NamesGoat
{
    public class NameReader
    {

        Dictionary<string, NameData> names = new Dictionary<string, NameData>();


        //read a year
        public void ReadYear(int year)
        {
            try
            {
                StreamReader reader = new StreamReader($"names\\yob{year}.txt");
                while (!reader.EndOfStream)
                { 
                    Console.WriteLine(reader.ReadLine());
                }
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message);
            }
        }


        //read all years

    }
}
