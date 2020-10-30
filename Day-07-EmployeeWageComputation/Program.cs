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
            //variable
            int empHrs = 0;
            ///Here, switch case statement is used to 
            ///check employee wage
            ///if employee is present then it 
            ///executes the switch case 1
            ///if employee is absent then it 
            ////executes the switch case 2
            Random random = new Random();
            switch (random.Next(0, 3))
            {
                case IS_PRESENT_PART_TIME:
                    Console.WriteLine("Employee is present for part time");
                    empHrs = 4;
                    break;
                case IS_PRESENT_FULL_TIME:
                    Console.WriteLine("Employee is present for Full time");
                    empHrs = 8;
                    break;
                case IS_ABSENT:
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    break;
            }
            Console.WriteLine("Employee wage is " + 20 * empHrs);
        }
    }
}


