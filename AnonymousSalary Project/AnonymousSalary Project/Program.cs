using System;

namespace AnonymousSalary_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter Hourly Rate:");
            float hourlyRate1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Hours Worked Per Week:");
            float weeklyHours1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            

            Console.WriteLine("Person 2");
            Console.WriteLine("Enter Hourly Rate:");
            float hourlyRate2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Hours Worked Per Week:");
            float weeklyHours2 = Convert.ToSingle(Console.ReadLine());

            //It must then print to the screen “Annual salary of Person 1:” and write the exact salary below it.
            float Annual_1 = hourlyRate1 * weeklyHours1 * 52;
            float Annual_2 = hourlyRate2 * weeklyHours2 * 52;
            bool Annual_1v2 = Annual_1 > Annual_2;
            Console.WriteLine("Annual salary of Person 1: " + Annual_1);
            Console.WriteLine("Annual salary of Person 2: " + Annual_2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(Annual_1v2);
            Console.ReadLine();



            //It must then print to the screen “Annual salary of Person 2:” and write the exact salary below it

            //It must then print to the screen “Does Person 1 make more money than Person 2 ?” and write the true or false value of this statement below it.

        }
    }
}
