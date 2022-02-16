using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesGoat
{
    internal class NameData
    {
        string name;
        int maleCount;
        int femaleCount;

        public NameData(string name, int maleCount, int femaleCount)
        {
            this.Name = name;
            this.MaleCount = maleCount;
            this.FemaleCount = femaleCount;
        }

        public string Name { get => name; set => name = value; }
        public int MaleCount { get => maleCount; set => maleCount = value; }
        public int FemaleCount { get => femaleCount; set => femaleCount = value; }
    }
}
