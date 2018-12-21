using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Steps 1 and 2 in exercise
            Console.WriteLine(IntMethods.Method(i: 4));

            //Steps 3 and 4
            decimal Input = Convert.ToDecimal(4.34);
            Console.WriteLine(IntMethods.Method(d: Input));
           

            //Steps 5 and 6
            Console.WriteLine(IntMethods.Method("3"));
            Console.ReadLine();
        }
    }
}
