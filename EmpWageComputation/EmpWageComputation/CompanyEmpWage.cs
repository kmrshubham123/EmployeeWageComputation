using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    interface IComputeEmpWage
    {
        void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonths);
        void computeEmpWage();
        int getTotalWage(string company);
    }
    class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;


        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //Constructor
            this.company = company;
            this.empRatePerHour= empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string tostring()
        {
            return "Total Employee wage for Company : " + this.company + " is " + this.totalEmpWage;
        }
    }
}
