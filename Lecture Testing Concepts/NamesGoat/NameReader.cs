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
                    string[] data = reader.ReadLine().Split(',');
                    if (names.ContainsKey(data[0]))
                    {
                        if (data[1].Equals("F"))
                        {
                            names[data[0]].FemaleCount += int.Parse(data[2]);
                        }
                        else
                        {
                            names[data[0]].MaleCount += int.Parse(data[2]);
                        }
                    }
                    else 
                    {
                        NameData temp;
                        if (data[1].Equals("F"))
                        {
                            temp = new NameData(data[0], 0, int.Parse(data[2]));
                        }
                        else
                        {
                            temp = new NameData(data[0], int.Parse(data[2]), 0);
                        }
                        names.Add(data[0], temp);
                    }
                }
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message);
            }
        }

        public void ReadYears(int startYear, int endYear)
        {
            for (int i = startYear; i <= endYear; i++)
            { 
                Console.WriteLine("Reading in year: " + i);
                ReadYear(i);
            }
        }

        public void DisplayDictionary()
        {
            foreach (var name in names)
            {
                Console.WriteLine(name.Key);
            }
        }

        public void QueryTest()
        { 
            var johns = from name in names
                       where name.Key.Equals("Zelda")
                       select name;

            foreach (var john in johns)
            {
                Console.WriteLine($"{john.Key}, F: {john.Value.FemaleCount}, M: {john.Value.MaleCount}");
            }
        }

        public void MostPopular()
        { 
            var goat = from name in names
                       orderby name.Value.FemaleCount + name.Value.MaleCount descending
                       select name;

            Console.WriteLine($"{goat.First().Key} with {goat.First().Value.FemaleCount} females and {goat.First().Value.MaleCount} males.");
        }

        public void LeastPopular()
        {
            var goat = from name in names
                       orderby name.Value.FemaleCount + name.Value.MaleCount
                       select name;

            Console.WriteLine($"{goat.First().Key} with {goat.First().Value.FemaleCount} females and {goat.First().Value.MaleCount} males.");
        }

        public void LongestName()
        {
            var lName = from name in names
                        orderby name.Key.Length descending
                        select name;
            Console.WriteLine($"{lName.First().Key} is the longest name. ");
        }

        public void ShortestName()
        {
            var lName = from name in names
                        orderby name.Key.Length 
                        select name;
            Console.WriteLine($"{lName.First().Key} is the shortest name. ");
        }

        //read all years

    }
}
