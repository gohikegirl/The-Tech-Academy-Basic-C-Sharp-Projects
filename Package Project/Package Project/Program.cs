using System;


namespace Package_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of your package in lbs");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

            if (packageWeight > 50)
                {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
                Console.ReadLine();
                }
            else
                {
                Console.WriteLine("Please enter the length of the package in inches.");
                decimal packageLength = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the width of the package in inches.");
                decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

                if ((packageLength + packageWidth) > 50)
                    {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    decimal price = (packageLength + packageWidth) * packageWeight / 100;
                    Console.WriteLine("The cost to ship your package is " + price + ". Thank You.");
                    Console.ReadLine();
                      
                }
           
            }

                  
        }
    }
}
