using Day_07_EmployeeWageComputation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    public class EmpWageBuilder
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!");
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
        }
    }
}
