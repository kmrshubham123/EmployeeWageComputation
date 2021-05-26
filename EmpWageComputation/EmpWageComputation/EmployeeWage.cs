﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    public class EmployeeWage
    {
        //constant
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOURS = 20;
        public const int IS_PART_TIME = 1;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;
        //variable
        int empHrs = 0;
        int empWage = 0;
        int totalEmpWage = 0;
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;
        
       
        public void TotalEmpWage()
        {
            
            
            while(totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Emp Wage :-" + empWage);

                int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOURS;
                Console.WriteLine("Total Emp Wage :-" + totalEmpWage);

            }



        }

    }
}
