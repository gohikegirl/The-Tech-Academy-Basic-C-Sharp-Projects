using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_7
{
    public class Employee : Person
    {
        public override void sayName()
        {
            Console.WriteLine(firstName +" "+ lastName);
        }
    }
}
