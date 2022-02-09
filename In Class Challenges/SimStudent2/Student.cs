using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimStudent2
{
    public class Student
    {
        private string name;
        private float gpa;
        private double money;
        private int energy;
        private int happiness;
        private int fullness;

        public string Name { get => name; set => name = value; }

        public float Gpa
        {
            get => default;
            set
            {
            }
        }

        public double Money
        {
            get => default;
            set
            {
            }
        }

        public int Energy
        {
            get => default;
            set
            {
            }
        }

        public int Happiness
        {
            get => default;
            set
            {
            }
        }

        public int Fullness
        {
            get => default;
            set
            {
            }
        }

        public void Work()
        {
            throw new System.NotImplementedException();
        }

        public void Chill()
        {
            throw new System.NotImplementedException();
        }

        public void Eat()
        {
            throw new System.NotImplementedException();
        }

        public void Party()
        {
            throw new System.NotImplementedException();
        }

        public void Sleep()
        {
            throw new System.NotImplementedException();
        }

        public void Study()
        {
            throw new System.NotImplementedException();
        }
    }
}