



// Calculate monthly wages till conditions
using System;
namespace EmpWage5
{
    class Program
    {
        public static void Main(string[] args)
        {


            const int RATE_PER_HR = 20;
            const int TOTAL_WORKING_HRS = 100;
            const int TOTAL_DAYS = 20;


            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 0;

            int full_time_empHrs;
            int part_time_empHrs;

            int full_time_empWages = 0;
            int part_time_empWages = 0;


            Random random = new Random();
            int empCheck = random.Next(0, 2);

            Console.WriteLine("NO OF DAYS EMPLOYEE WORKED IN A MONTH: " + TOTAL_DAYS);

            Random full = new Random();
            int fulltimedays = full.Next(0, 21);

            Random part = new Random();
            int parttimedays = part.Next(1, 21);
            Console.WriteLine("NO OF DAYS FULL TIME EMPLOYEE WORKED: " + fulltimedays);
            Console.WriteLine("NO OF DAYS PART TIME EMPLOYEE WORKED: " + parttimedays);
            for (int i = 1; i <= TOTAL_DAYS; i++)
            {
                for (int j = 1; j <= TOTAL_WORKING_HRS; j++)
                {
                    if (empCheck == IS_FULL_TIME || empCheck == IS_PART_TIME)
                    {
                        full_time_empHrs = 16;
                        part_time_empHrs = 8;
                        full_time_empWages += RATE_PER_HR * full_time_empHrs * fulltimedays;
                        part_time_empWages += RATE_PER_HR * part_time_empHrs * parttimedays;

                    }
                }
            }


            Console.WriteLine("FULL TIME EMPLOYEE WAGE FOR A MONTH IS:" + full_time_empWages);
            Console.WriteLine("PART TIME EMPLOYEE WAGE FOR A MONTH IS:" + part_time_empWages);
        }
    }

}




