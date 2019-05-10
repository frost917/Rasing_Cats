using System;

namespace Rasing_Cats
{
    class Money
    {
        private double balance;
        private double salary;

        public double Balance { get => balance; set => balance = value; }
        public double Salary { get => salary; set => salary = value; }

        public Money(double balance, int job)
        {
            Balance = balance;
            Salary = JobList.Jobs[job].Salary;
        }
    }
}
