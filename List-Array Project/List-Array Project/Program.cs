using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Array_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
            string[] FabFiveNames = new string[] { "Michelle", "Alex", "Jenn", "Jelle", "Bingyune" };
            Console.WriteLine("Pick a person from the Fab Five at random--select a number from 0-4.");
            int selection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FabFiveNames[selection]);
            Console.ReadLine();

            //2.Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
            int[] IntList = new int[] { 10, 20, 30, 40, 50, 60 };
            Console.WriteLine("Pick a from the array--select a number from 0-4.");
            int input = Convert.ToInt32(Console.ReadLine());
           
            //3.Add in a message that displays when the user selects an index that doesn’t exist.
            if (input <0 || input> 5 )
            {
                Console.WriteLine("Invalid input. Please restart the program enter a number between 0 and 4.");
                Console.ReadLine();
            } 
            else
            {
                Console.WriteLine(IntList[input]);
                Console.ReadLine();
            }
            //4.Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.
            List<string> movies = new List<string>();
            movies.Add("The Green Lantern");
            movies.Add("Shawshank Redemption");
            movies.Add("Good Will Hunting");
            movies.Add("Black Panther");
            movies.Add("Thor");

            Console.WriteLine("Pick a movie at random. Select a number between 0 and 4.");
            Console.WriteLine(movies[Convert.ToInt32(Console.ReadLine())]);
            Console.ReadLine();

        }
    }
}
