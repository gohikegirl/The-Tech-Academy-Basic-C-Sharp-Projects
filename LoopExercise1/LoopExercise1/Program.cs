using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you're happy and you know it clap your hands. (write 'clap' until you're sick of it)");
            string happyOrNot = Console.ReadLine();
            bool NotYetSickOfIt = happyOrNot == "clap";

            while (NotYetSickOfIt == true)
            {
                switch (happyOrNot)
                {
                    case "clap":
                        Console.WriteLine("If you're happy and you know it clap your hands. (write 'clap' until you're sick of it)");
                        happyOrNot = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Sorry to hear you're sick of it. We will stop asking now.");
                        NotYetSickOfIt = false;
                        break;
                                       
                 }
            }
            Console.ReadLine();

     
        }
    }
}
