using System;
namespace EmpWage1
{
    class Program
    {
        public static void Main(string[] args)
        {


            const int rate_per_hr = 20;

            int full_time_empHrs = 0;
            int part_time_empHrs = 0;
            int full_time_empWage;
            int part_time_empWage;


            Random random = new Random();
            int empCheck = random.Next(0, 2);

            switch (empCheck)
            {
                case 0:
                    full_time_empHrs = 16;
                    break;
                case 1:
                    part_time_empHrs = 8;
                    break;
                default:
                    break;

            }
            full_time_empWage = rate_per_hr * full_time_empHrs;
            part_time_empWage = rate_per_hr * part_time_empHrs;
            Console.WriteLine("FULL TIME EMPLOYEE WAGE IS:" + full_time_empWage);
            Console.WriteLine("PART TIME EMPLOYEE WAGE IS:" + part_time_empWage);

        }
    }
}


