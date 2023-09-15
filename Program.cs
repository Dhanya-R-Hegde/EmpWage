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

        static void Main(string[] args)
        {
            UC1();
            UC2();
            UC3();

        }
    }
}
