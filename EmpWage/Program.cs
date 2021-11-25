

// Calculate monthly wages till condition is reached 
using System;
namespace EmpWage5
{
    class Program
    {
        public static void Main(string[] args)
        {


            const int rate_per_hr = 20;
            int total_days = 20; ;

            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 0;

            int full_time_empHrs = 0;
            int part_time_empHrs = 0;

            int full_time_empWage;
            int part_time_empWage;


            Random random = new Random();
            int empCheck = random.Next(0, 2);

            Console.WriteLine("NO OF DAYS EMPLOYEE WORKED IN A MONTH: " + total_days);

            Random full = new Random();
            int fulltimedays = full.Next(0, 21);
            Console.WriteLine("NO OF DAYS FULL TIME EMPLOYEE WORKED: " + fulltimedays);

            Random part = new Random();
            int parttimedays = part.Next(0, 21);
            Console.WriteLine("NO OF DAYS PART TIME EMPLOYEE WORKED: " + parttimedays);

            if (empCheck == IS_FULL_TIME || empCheck == IS_PART_TIME)
            {
                full_time_empHrs = 16;
                part_time_empHrs = 8;

            }
            
           
            full_time_empWage = rate_per_hr * full_time_empHrs * fulltimedays;
            part_time_empWage = rate_per_hr * part_time_empHrs * parttimedays;
            Console.WriteLine("FULL TIME EMPLOYEE WAGE FOR A MONTH IS:" + full_time_empWage);
            Console.WriteLine("PART TIME EMPLOYEE WAGE FOR A MONTH IS:" + part_time_empWage);

        }
    }
}


