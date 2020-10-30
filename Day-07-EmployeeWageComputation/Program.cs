using System;

namespace Day_07_EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!");
            //constants
            const int IS_PRESENT_PART_TIME = 1;
            const int IS_PRESENT_FULL_TIME = 2;
            const int IS_ABSENT = 0;
            const int EMP_RATE_PER_HOUR = 20;
            const int NUM_OF_WORKING_DAYS = 20;
            const int MAX_WORKING_HOURS_IN_A_MONTH = 100;
            //variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;
            ///While loop is used to check maximum working hours and number of working days.
            ///if it is true then it executes
            while (totalEmpHrs <= MAX_WORKING_HOURS_IN_A_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                ///Switch case is used to check whether employee 
                ///is working for part time or full time
                switch (random.Next(1, 3))
                {
                    case IS_PRESENT_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_PRESENT_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_ABSENT:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day " + totalWorkingDays + " : " + "Emp Hr: " + empHrs);
                empWage = EMP_RATE_PER_HOUR * empHrs;
                totalEmpWage += empWage;
            }
            Console.WriteLine("total employee wage for a month " + totalEmpWage);
        }
    }
}