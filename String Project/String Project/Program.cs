using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenate three strings.
            //Convert a string to uppercase.
            string a = "How are ";
            string b = "you, ";
            Console.WriteLine("Enter your name:");
            string c = Console.ReadLine();
            string d = c.ToUpper();
            string fullString = a + b + d + "?";
            Console.WriteLine(fullString);
            Console.ReadLine();


            //Create a Stringbuilder and build a paragraph of text, one sentence at a time
            StringBuilder exercise = new StringBuilder();
            exercise.Append("\t Welcome to the Tech Academy. You are about embark on an exciting new career journey.");
            exercise.Append("\n The program will take you through a series of educational modules, each covering a different topic.");
            exercise.Append("\n We hope you take the time to complete each course and ensure that you have a comprehensive understanding of the basics of computing.");
            exercise.Append("Don't hesitate to let us know if you run into problems. \n \n We hope you enjoy the course!");
            Console.WriteLine(exercise);
            Console.ReadLine();

            
        }
    }
}
