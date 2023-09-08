 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class UserCase9
    {
        static int random()
        {
            Random randomNumber = new Random();
            int randomNum = randomNumber.Next(0, 3);
            return randomNum;
        } 

        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public static int empCheck = random();

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public UserCase9(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth) //public for this constructor is required to make the object accessible in other classes
        {
            this.company = company; //'this' keyword is not supported by a static block
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void UC9() //Save the total wage by company
        {
            int empHrs = 0, totalEmpHours = 0, totalWorkingDays = 0;

            while (totalEmpHours <= this.maxHoursPerMonth && totalWorkingDays <= this.numOfWorkingDays)
            {
                totalWorkingDays++;

                switch (empCheck)
                {
                    case IS_FULL_TIME: empHrs = 8; break;
                    case IS_PART_TIME: empHrs = 4; break;
                    default: empHrs = 0; break;
                }

                totalEmpHours += empHrs;
                Console.WriteLine("Day : " + totalWorkingDays + "  Emloyee Hours : " + empHrs);
            }
            this.totalEmpWage = totalEmpHours * this.empRatePerHour;
            Console.WriteLine("Total employee wage is : " + this.totalEmpWage);
        }

        public string toString()
        {
            return "Total Employee Wage for Company : " + this.company + " is " + this.totalEmpWage;
        }
    }
}
