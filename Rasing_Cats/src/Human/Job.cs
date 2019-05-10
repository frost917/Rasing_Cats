using System;
using System.Collections.Generic;

namespace Rasing_Cats
{
    public class Job
    {
        private string name;
        private double salary;
        private string info;

        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        public string Info { get => info; set => info = value; }

        public Job(string name, double salary, string info)
        {
            Name = name;
            Salary = salary;
            Info = info;
        }
    }
}
