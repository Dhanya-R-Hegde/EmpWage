namespace EmployeeWageProblem
{
    public class Program
    {

        static int random()
        {
            Random randomNumber = new Random();
            int randomNum = randomNumber.Next(0, 3);
            return randomNum;
        }

        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HOURS_IN_MONTH = 100;
        public static int empHrs;
        public static int empWage;
        public static int totalEmpWage = 0;
        public static int empCheck = random();

        static void UC1() //Check Employee Presence
        {
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is not present");
        }

        static void UC2() //Check Daily Employee Wage
        {
            if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            else
                empHrs = 0;

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Daily Wage is : " + empWage);
        }

        static void UC3() //Check daily employee wage also for part time employee
        {
            if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            else if (empCheck == IS_PART_TIME)
                empHrs = 4;
            else
                empHrs = 0;

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Daily Wage is : " + empWage);
        }

        static void UC4() //Check daily employee wage using switch case
        {
            switch (empCheck)
            {
                case IS_FULL_TIME: empHrs = 8; break;
                case IS_PART_TIME: empHrs = 4; break;
                default: empHrs = 0; break;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Daily Wage is : " + empWage);
        }

        static void UC5() //Calculate wages for a month having 20 working days
        {
            for (int day = 1; day <= NUM_OF_WORKING_DAYS; day++)
            {
                switch (empCheck)
                {
                    case IS_FULL_TIME: empHrs = 8; break;
                    case IS_PART_TIME: empHrs = 4; break;
                    default: empHrs = 0; break;
                }

                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Day : " + day + "  Emloyee Wage : " + empWage);
            }

            Console.WriteLine("Total monthly employee wage is : " + totalEmpWage);
        }

        static void UC6() //Calculate wages for a month having 20 working days or for total working hours of 100
        {
            int totalEmpHours = 0, totalWorkingDays = 0;

            while (totalEmpHours <= MAX_HOURS_IN_MONTH && totalWorkingDays <= NUM_OF_WORKING_DAYS)
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
            totalEmpWage = totalEmpHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total employee wage is : " + totalEmpWage);
        }

        static void UC8(string company) //Calculate wages for a month having 20 working days or for total working hours of 100 for multiple companies
        {
            int totalEmpHours = 0, totalWorkingDays = 0;

            while (totalEmpHours <= MAX_HOURS_IN_MONTH && totalWorkingDays <= NUM_OF_WORKING_DAYS)
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
            totalEmpWage = totalEmpHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total employee wage for company " + company + " is " + totalEmpWage);
        }

        static void Main(string[] args)
        {
            UC1();
            UC2();
            UC3();
            UC4();
            UC5();
            UC6();
            UC8("Adobe");
        }
    }
}
