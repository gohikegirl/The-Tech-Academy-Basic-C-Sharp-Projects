using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number that you'd like to perform actions on: ");
            int Input = Convert.ToInt32(Console.ReadLine());

            int Method1 = MathMethods.AddFunc(Input);
            Console.WriteLine("The output of method 1 is " + Method1);
            int Method2 = MathMethods.SquareFunc(Input);
            Console.WriteLine("The output of method 2 is " + Method2);
            int Method3 = MathMethods.Divide(Input);
            Console.WriteLine("The output of method 3 is " + Method3);
            Console.ReadLine();
            
        }
    }
}
