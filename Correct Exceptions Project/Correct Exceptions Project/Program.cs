using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correct_Exceptions_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> Integers = new List<int>() { 2, 4, 5, 7, 8, 9, 10, 12, 16 };
                Console.Write("Enter a number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                foreach (int integer in Integers)
                {
                    decimal result = Convert.ToDecimal(integer) / Convert.ToDecimal(input);
                    Console.WriteLine(result);
                    Console.ReadLine();
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a number only.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Test of continued execution.");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
