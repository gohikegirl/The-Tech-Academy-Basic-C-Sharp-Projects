using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature? (Enter in degrees Fahrenheit)");
            int temperature = Convert.ToInt32(Console.ReadLine());
            bool adjustNeeded = temperature == 60;

            switch (temperature)
            {
                case (55):
                    Console.WriteLine("Can you turn up the heater?");
                    Console.WriteLine("What is the temperature? (Enter in degrees Fahrenheit)");
                    temperature = Convert.ToInt32(Console.ReadLine());
                    break;
                case (59):
                    Console.WriteLine("Can you turn up the heater?");
                    Console.WriteLine("What is the temperature? (Enter in degrees Fahrenheit)");
                    temperature = Convert.ToInt32(Console.ReadLine());
                    break;
                case (65):
                    Console.WriteLine("Can you turn down the heater?");
                    Console.WriteLine("What is the temperature? (Enter in degrees Fahrenheit)");
                    temperature = Convert.ToInt32(Console.ReadLine()); ;
                    break;
                case (60):
                    Console.WriteLine("Wow!It is the perfect temp for sleeping.");
                    adjustNeeded = true;
                    break;
                default:
                    Console.WriteLine("I think we need to adjust the heater.");
                    Console.WriteLine("What is the temperature? (Enter in degrees Fahrenheit)");
                    temperature = Convert.ToInt32(Console.ReadLine());
                    break;
            }
            while (!adjustNeeded) ;
           
            Console.ReadLine();
        }
    }
}
