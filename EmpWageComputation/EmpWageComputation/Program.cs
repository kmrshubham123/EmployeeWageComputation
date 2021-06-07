using EmpWageComputation;
using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("BigBazaar", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Trends", 10, 4, 10);
            empWageBuilder.addCompanyEmpWage("FaceBook", 20, 10, 10);
            empWageBuilder.computeEmpWage();



        }
    }
}