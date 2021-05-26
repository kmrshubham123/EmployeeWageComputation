using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#### Welcome to the Employee Wage Computation ####");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.EmpWage();
        }
    }
}
