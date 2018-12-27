using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExp_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();
                       
            Employee Emp1 = new Employee();
            Emp1.fName = "Joe";
            Emp1.lName = "Anderson";
            Emp1.ID = 100;
            Employees.Add(Emp1);
            Employee Emp2 = new Employee();
            Emp2.fName = "Jenn";
            Emp2.lName = "Lee";
            Emp2.ID = 101;
            Employees.Add(Emp2);
            Employee Emp3 = new Employee();
            Emp3.fName = "Alex";
            Emp3.lName = "Aguilera";
            Emp3.ID = 102;
            Employees.Add(Emp3);
            Employee Emp4 = new Employee();
            Emp4.fName = "Joe";
            Emp4.lName = "Gold";
            Emp4.ID = 103;
            Employees.Add(Emp4);
            Employee Emp5 = new Employee();
            Emp5.fName = "Michelle";
            Emp5.lName = "Lee";
            Emp5.ID = 104;
            Employees.Add(Emp5);
            Employee Emp6 = new Employee();
            Emp6.fName = "Mike";
            Emp6.lName = "Li";
            Emp6.ID = 105;
            Employees.Add(Emp6);
            Employee Emp7 = new Employee();
            Emp7.fName = "Joe";
            Emp7.lName = "Clinch";
            Emp7.ID = 106;
            Employees.Add(Emp7);
            Employee Emp8 = new Employee();
            Emp8.fName = "Jelle";
            Emp8.lName = "Vd";
            Emp8.ID = 107;
            Employees.Add(Emp8);
            Employee Emp9 = new Employee();
            Emp9.fName = "Judith";
            Emp9.lName = "Boschini";
            Emp9.ID = 108;
            Employees.Add(Emp9);
            Employee Emp10 = new Employee();
            Emp10.fName = "Nancy";
            Emp10.lName = "Goh";
            Emp10.ID = 109;
            Employees.Add(Emp10);

            List<Employee> Joe1 = new List<Employee>();
            foreach (Employee employee in Employees)
            {
                if (employee.fName == "Joe")
                {
                    Joe1.Add(employee);
                }
            }
            foreach (Employee joe in Joe1)
            {
                Console.WriteLine(joe.fName + " " + joe.lName);

            }
            Console.ReadLine();

            List<Employee> Joe2s = Employees.Where(x => x.fName == "Joe").ToList();
            foreach (Employee joey in Joe2s)
            {
                Console.WriteLine(joey.fName + " " + joey.lName);
            }
            Console.ReadLine();

            List<Employee> EmpsGtr5 = Employees.Where(x => x.ID > 105).ToList();
            foreach (Employee Emp in EmpsGtr5)
            {
                Console.WriteLine(Emp.fName + " " + Emp.lName);
            }
            Console.ReadLine();

        }
    }
}
