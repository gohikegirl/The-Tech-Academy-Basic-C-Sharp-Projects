using System;


namespace Insurace_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI(Yes/No)?");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool result = (age > 15 && dui == "No" && tickets < 4);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
