using System;

namespace Day_07_EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!");
            //constants
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            const int IS_PART_TIME = 1;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            //Checks if employee works full time
            //or part time
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}