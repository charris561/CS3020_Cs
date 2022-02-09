using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimStudent2
{

    class Program
    {
        public static void Main(string[] args) 
        {
            Student student = new Student();
            student.Name = "Test Name";
            Console.WriteLine($"student.Name = {student.Name}");
        }
    }

}