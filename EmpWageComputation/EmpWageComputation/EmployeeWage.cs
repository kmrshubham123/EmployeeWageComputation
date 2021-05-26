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
        public void CaseEmpWage()
        {
            Random random = new Random();
            int empCheck= random.Next(0, 2);
            switch(empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;

                case IS_FULL_TIME:
                    empHrs = 8;
                    break;

                default:
                    empHrs = 0;
                    break;

            }

            empWage = empHrs * EMP_RATE_PER_HOURS;
            Console.WriteLine("Emp Wage :-" +empWage);
        }

    }
}
