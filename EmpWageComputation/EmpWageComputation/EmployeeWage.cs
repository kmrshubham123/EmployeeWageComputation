using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    public class EmployeeWage
    {
        //constant
        const int IS_FULL_TIME = 2;
        const int EMP_RATE_PER_HOURS = 20;
        const int IS_PART_TIME = 1;
        //variable
        int empHrs = 0;
        int empWage = 0;
        public void TotalEmpWage()
        {
            Random random = new Random();
            int empCheck= random.Next(0, 2);

            if (empCheck == IS_PART_TIME)
            
            {
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HOURS;
            Console.WriteLine("Emp Wage :-" +empWage);
        }

    }
}
