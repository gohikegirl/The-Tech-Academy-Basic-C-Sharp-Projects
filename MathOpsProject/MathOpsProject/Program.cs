using System;

namespace MathOpsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10, 000, 000).
            Console.WriteLine("Enter an integer: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int product = userInput * 50;
            Console.WriteLine("The multiple of this number times 50 is: " + product + ". Hit any key to proceed.");
            Console.ReadLine();

            //2.Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.WriteLine("Enter an integer: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            int total = userInput2 + 25;
            Console.WriteLine("This number plus 25 is: " + total + ". Hit any key to proceed.");
            Console.ReadLine();

            //3.Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine("Enter an integer: ");
            int userInput3 = Convert.ToInt32(Console.ReadLine());
            double quotient = userInput3 / 12.5;
            Console.WriteLine("This number divided by 12.5 is: " + quotient + ". Hit any key to proceed.");
            Console.ReadLine();

            //4.Takes an input from the user, checks if it is greater than 50, and prints the true / false result to the console.
            Console.WriteLine("Enter an integer: ");
            int userInput4 = Convert.ToInt32(Console.ReadLine());
            bool valueCheck = userInput4 > 50;
            Console.WriteLine("Is this number greater than 50?" + valueCheck + ". Hit any key to proceed.");
            Console.ReadLine();
            //5.Takes an input from the user, divides it by 7, and prints the remainder to the console(tip: think % operator)
            Console.WriteLine("Enter an integer: ");
            int userInput5 = Convert.ToInt32(Console.ReadLine());
            int remainder7 = userInput5 % 7;
            Console.WriteLine("The remainder of this number divided by 7 is: " + remainder7 + ". Hit any key to end this program.");
            Console.ReadLine();
        }
    }
}
