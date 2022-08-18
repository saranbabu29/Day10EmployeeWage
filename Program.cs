using System;

namespace Day10EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 0;
            int wagePerHour = 20;
            int empHr;

            Random random = new Random();
            int value = random.Next(0, 2);


            if (value == isPresent)
            {
                empHr = 8;
                Console.WriteLine("Employee is Present and Wage is " + (empHr * wagePerHour));
            }
        }
    }
}
