using System;


namespace StudentReportProj
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            int currentPage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'");
            bool helpNeeded = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveFdbk = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string otherFdbk = Console.ReadLine();
            Console.WriteLine("How many hours did you study today ?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");
            Console.ReadLine();   

        }
    }
}
