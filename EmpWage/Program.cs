
//To calculate Both part time and full time wage
using System;
namespace EmpWage1
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 0;
            const int rate_per_hr = 20;
            int part_time_empHrs = 0;
            int full_time_empHrs = 0;
            int full_time_empWage;
            int part_time_empWage;
            

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME || empCheck == IS_PART_TIME)
            {
                full_time_empHrs = 16;
                part_time_empHrs = 8;

            }
            

            full_time_empWage = rate_per_hr * full_time_empHrs;
            part_time_empWage = rate_per_hr * part_time_empHrs;
            Console.WriteLine("FULL TIME EMPLOYEE WAGE IS:" + full_time_empWage);
            Console.WriteLine("PART TIME EMPLOYEE WAGE IS:" + part_time_empWage);

        }
    }
}



