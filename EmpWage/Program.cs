//Employee Wage added
    using System;
namespace EmpWage2
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int IS_FULL_TIME = 1;
            const int RATE_PER_HR = 20;
            int empHrs;
            int empWage;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * RATE_PER_HR;
            Console.WriteLine("Employee wage is:" + empWage);
        }
    }
}

