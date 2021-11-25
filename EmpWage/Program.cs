//check employee is present or absent

using System;
namespace EmpWage
{
    class UC1
    {
        public static void Main(string[] args)
        {
            const int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("EMPLOYEE IS PRESENT");
            }
            else
            {
                Console.WriteLine("EMPLOYEE IS ABSENT");
            }

        }
    }
}
