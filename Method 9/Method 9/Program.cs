using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> Emp1 = new Employee<string>();
            Emp1.Name = "Alex";
            Emp1.id = 100;
            Emp1.Things = new List<string> { "pen", "pencil", "desk", "chair", "laptop" };

            Employee<int> Emp2 = new Employee<int>();
            Emp2.Name = "Michelle";
            Emp2.id = 101;
            Emp2.Things = new List<int> { 1, 2, 3, 4, 5 };

            foreach (string thing in Emp1.Things)
            {
                Console.WriteLine(thing);
            }

            foreach(int thing in Emp2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
