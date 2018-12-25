using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //code for Method 7 (polymorphism)
            Person person = new Employee();
            person.firstName = "Sample";
            person.lastName = "Student";
            person.sayName();
            Console.ReadLine();

            //code for Method 7b (interfaces)
            IQuittable person2 = new Employee();
            person2.Quit();
            Console.ReadLine();

        }
    }
}
