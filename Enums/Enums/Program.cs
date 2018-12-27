using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a day of the week: ");
            string userInput = Console.ReadLine();
            try
            {
                DaysofWeek input = (DaysofWeek)Enum.Parse(typeof(DaysofWeek), userInput);
                Console.WriteLine("Thank you. " + input + " is a valid day of the week.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }

        }           
        public enum DaysofWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

    }
}
