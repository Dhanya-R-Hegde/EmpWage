using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class UserCase10
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public UserCase10()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }

        public void computeEmpWage()
        {
            for(int i=0; i<numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while(totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch(empCheck)
                {
                    case IS_PART_TIME : empHrs = 4; break;
                    case IS_FULL_TIME: empHrs = 8; break;
                    default : empHrs = 0; break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day# : " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }

            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }

    //public class CompanyEmpWage
    //{
    //    public string company;
    //    public int empRatePerHour;
    //    public int numOfWorkingDays;
    //    public int maxHoursPerMonth;
    //    public int totalEmpWage;

    //    public CompanyEmpWage(string company, int empRateperHour, int numOfWorkingDays, int maxHoursPerMonth) 
    //    { 
    //        this.company = company;
    //        this.empRatePerHour = empRateperHour;
    //        this.numOfWorkingDays = numOfWorkingDays;
    //        this.maxHoursPerMonth = maxHoursPerMonth;
    //    }

    //    public void setTotalEmpWage(int totalEmpWage)
    //    {
    //        this.totalEmpWage = totalEmpWage;

    //    }

    //    public string toString()
    //    {
    //        return "Total Emp Wage for Company : " + this.company + " is " + this.totalEmpWage;
    //    }
    //}
}
