using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmployeeWage BigBazaar = new EmployeeWage("BigBazzar", 20, 2, 10);
            EmployeeWage Trends = new EmployeeWage("Trends ", 10, 4, 20);
            BigBazaar.computeEmpWage();
            Console.WriteLine(BigBazaar.tostring());
            Trends.computeEmpWage();
            Console.WriteLine(Trends.tostring());



        }
    }
}