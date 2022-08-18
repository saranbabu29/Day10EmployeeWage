﻿using System;

namespace Day10EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int isFullTime = 0;
            int wagePerHour = 20;
            int empHr;

            Random random = new Random();
            int value = random.Next(0, 2);


            if (value == isFullTime)
            {
                empHr = 8;
                Console.WriteLine("Employee is Full Time and Daily Wage is " + (empHr * wagePerHour));
            }
            else
            {
                empHr = 4;
                Console.WriteLine("Employee is Part Time and Daily Wage is " + (empHr * wagePerHour));
            }
        }
    }
}