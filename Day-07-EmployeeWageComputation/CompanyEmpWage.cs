using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;


namespace Day_07_EmployeeWageComputation
{
    public class CompanyEmpWage
    {
        //variables
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyEmpWage"/> class.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <param name="empRatePerHour">The emp rate per hour.</param>
        /// <param name="numOfWorkingDays">The number of working days.</param>
        /// <param name="maxHoursPerMonth">The maximum hours per month.</param>
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //this is used to refer the current instances
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        
        //this method returns the string itself
        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + " is: " + this.totalEmpWage;
        }
    }
}
