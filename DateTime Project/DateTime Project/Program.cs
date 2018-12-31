using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime curDateTime = DateTime.Now;
            Console.WriteLine(curDateTime); 
            Console.WriteLine("Enter a number of hours that you want to add to the date and time now: ");
            double userInput = Convert.ToDouble(Console.ReadLine());
            DateTime newDateTime = curDateTime.AddHours(userInput);
            Console.WriteLine(newDateTime);
            Console.ReadLine();
                


        }
    }
}
