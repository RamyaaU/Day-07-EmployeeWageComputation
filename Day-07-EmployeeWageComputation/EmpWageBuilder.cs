using Day_07_EmployeeWageComputation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    public class EmpWageBuilder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation");
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
        }
    }
}