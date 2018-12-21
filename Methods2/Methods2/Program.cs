using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            IntMethods instance = new IntMethods();
            IntMethods.oddFunc(4,5);
            IntMethods.oddFunc(a: 4, b: 5);
            Console.ReadLine();
         

        }
    }
}
