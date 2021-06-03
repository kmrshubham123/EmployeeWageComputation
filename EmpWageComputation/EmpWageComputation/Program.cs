using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.ComputeEmpWage("BIG_BAZAAR", 20,2,10);
            employeeWage.ComputeEmpWage("TRENDs", 20, 2, 10);

        }
    }
}