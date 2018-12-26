using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Person1 = new Employee();
            Person1.Name = "Michelle";
            Person1.Id = 101;
            Employee Person2 = new Employee();
            Person2.Name = "Alex";
            Person2.Id = 102;

            //Console.WriteLine(Person1.Id.CompareTo(Person2.Id));
            //Console.ReadLine();

            string result = Person1 == Person2;
            if (result == "0")
            {
                Console.WriteLine("This is the same person");
            }
            else
            {
                Console.WriteLine("This is not the same person");
            }
            Console.ReadLine();

            //if (Person2.Id == Person1.Id)
            //{
            //    Console.WriteLine("This is the same person");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("This is not the same person");
            //    Console.ReadLine();
            //}
        }
        
    }
}
