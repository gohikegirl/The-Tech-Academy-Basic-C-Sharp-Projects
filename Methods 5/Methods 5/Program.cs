using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods divide = new Methods();
            Console.WriteLine("Enter a number to divide by 2: ");
            int input = Convert.ToInt32(Console.ReadLine());
            divide.Divide2(input, out int result);
            Console.WriteLine(result);
           

            int statOutput = staticMethods.Divide4(input);
            Console.WriteLine(statOutput);
            Console.ReadLine();
        }
    }
}
