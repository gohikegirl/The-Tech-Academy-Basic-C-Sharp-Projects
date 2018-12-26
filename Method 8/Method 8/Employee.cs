using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_8
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public static string operator ==(Employee emp1, Employee emp2)
        {
            int sameSame = emp1.Id.CompareTo(emp2.Id);
            return sameSame.ToString();

        }

        public static string operator !=(Employee emp1, Employee emp2)
        {
            int sameSame = emp1.Id.CompareTo(emp2.Id);
            return sameSame.ToString();
        }
    }
}
