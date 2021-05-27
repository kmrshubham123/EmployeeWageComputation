using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    class EmployeeWage
    {
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int IS_PART_TIME = 1;
        public const int NUM_OF_WORKING_DAYS = 20;  


        public void EmpWage()
        {
            int EmpHrs = 0, Wage = 0, TotalEmpWage = 0;

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        EmpHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        EmpHrs = 8;
                        break;
                    default:
                        EmpHrs = 0;
                        break;
                }
                Wage = EmpHrs * EMP_RATE_PER_HOUR;
                TotalEmpWage += Wage;
                Console.WriteLine("Wage: " + Wage);
                Console.ReadLine();
            }
            Console.WriteLine("Total Emp Wage : " + TotalEmpWage);
        }
    }
}