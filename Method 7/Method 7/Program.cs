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
            Person person = new Employee();
            person.firstName = "Sample";
            person.lastName = "Student";
            person.sayName();
            Console.ReadLine();
        }
    }
}
