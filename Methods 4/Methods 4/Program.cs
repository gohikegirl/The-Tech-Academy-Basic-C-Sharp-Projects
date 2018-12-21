using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Method instance = new Method();
            Console.WriteLine("Enter in a number to be your intial input: ");
            int inputA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter in a second number, if desired (not required): ");
            string inputB = Console.ReadLine();

            if (inputB =="")
            {
                int outputAB = Method.mMichelle(inputA);
                Console.WriteLine("The mMichelle method has transformed your inputs to {0}", outputAB);
            }
            else
            {
                int outputAB = Method.mMichelle(inputA, Convert.ToInt32(inputB));
                Console.WriteLine("The mMichelle method has transformed your inputs to {0}", outputAB);
            }
                     
            
            Console.ReadLine();
            
        }
    }
}
