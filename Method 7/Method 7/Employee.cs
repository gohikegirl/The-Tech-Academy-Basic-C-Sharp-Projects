using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_7
{
    public class Employee : Person, IQuittable
    {
        public int id { get; set; }

        public override void sayName()
        {
            Console.WriteLine(firstName +" "+ lastName);
        }

        public void Quit()
        {
            Console.WriteLine("Enter the name of an employee who is quitting: ");
            string Name = Console.ReadLine();
            Console.WriteLine(Name + " is leaving the company.");
        }   
    }
}
