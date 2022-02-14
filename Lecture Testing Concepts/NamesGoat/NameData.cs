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
        int makeCount;
        int femaleCount;

        public NameData(string name, int makeCount, int femaleCount)
        {
            this.Name = name;
            this.MakeCount = makeCount;
            this.FemaleCount = femaleCount;
        }

        public string Name { get => name; set => name = value; }
        public int MakeCount { get => makeCount; set => makeCount = value; }
        public int FemaleCount { get => femaleCount; set => femaleCount = value; }
    }
}
