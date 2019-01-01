using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your age here: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                bool invalidAnswer = userInput <= 0;
                if (invalidAnswer==true)
                {
                    throw new ArgumentOutOfRangeException();
                }
                DateTime Today = DateTime.Today;
                DateTime YearofBirth = Today.AddYears(userInput * -1);
                Console.WriteLine("Your birth year is {0}.", YearofBirth.Year);
                Console.ReadLine();
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("You have entered an invalid entry. Please enter an integer that is 1 or greater.");
                Console.ReadLine();
                return;
            }
            
            catch (Exception)
            {
                Console.WriteLine("Error alert. Please contact your System Administrator for further instruction.");
                Console.ReadLine();
                return;
            }
            
            

        }
    }
}
