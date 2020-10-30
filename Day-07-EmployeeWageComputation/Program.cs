using System;

namespace Day_07_EmployeeWageComputation
{
    class Program
    { 
            //constants
            public const int IS_FULL_TIME = 1;
            public const int IS_PART_TIME = 2;

        /// <summary>
        /// Computes the emp wage.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <param name="empRatePerHour">The emp rate per hour.</param>
        /// <param name="numOfWorkingDays">The number of working days.</param>
        /// <param name="maxHoursPerMonth">The maximum hours per month.</param>
        /// <returns></returns>
        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            Random random = new Random();
            ///While loop is used to check maximum working hours and number of working days.
            ///if it is true then it executes
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                int empCheck = random.Next(0, 3);
                totalWorkingDays++;
                switch (empCheck)
                {
                    case 2:
                        empHrs = 4;
                        break;
                    case 1:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day:" + totalWorkingDays + " Emp hrs " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            return totalEmpWage;
        }

        //main function
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!");
            computeEmpWage("DMart", 20, 2, 10);
            computeEmpWage("Reliance", 10, 4, 20);
        }
    }
}

    
