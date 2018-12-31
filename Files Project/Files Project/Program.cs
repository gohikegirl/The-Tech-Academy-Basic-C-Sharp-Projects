using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number that we can log to our text file: ");
            string userInput = Console.ReadLine();
            File.WriteAllText(@"C: \Users\egllenp\Desktop\TechAcademyProjects\log-proj.txt", userInput);
            string userOutput = File.ReadAllText(@"C:\Users\egllenp\Desktop\TechAcademyProjects\log-proj.txt");
            Console.WriteLine("Thank you. Your text file now reads {0}.", userOutput);
            Console.ReadLine();
        }
    }
}
