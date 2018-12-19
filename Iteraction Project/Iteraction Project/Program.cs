using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteraction_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a one-dimensional Array of strings.Ask the user to input some text.Create a loop that goes through each string in the Array, adding the user’s text to the string.Then create a loop that prints off each string in the Array on a separate line.
            //string[] dogs = { "Jarvis", "Zoey", "Fennel", "Pepsi", "Gibby" };
            //Console.Write("Enter the breeding company for these dogs.");
            //string breedCo = Console.ReadLine();

            //for (int d = 0; d < dogs.Length; d++)
            //{
            //    dogs[d] = dogs[d] +" "+ breedCo;
            //    Console.WriteLine(dogs[d]);
            //}
            //Console.ReadLine();

            //2.Create an infinite loop.
            //string[] fruits = { "apple", "orange", "banana", "dragonfruit", "ground cherry" };
            //Console.Write("Enter a flavor profile for these fruits: ");
            //string flavor = Console.ReadLine();
            //bool input = flavor != "0";

            //while (input==true)
            //{
            //    for (int d = 0; d < fruits.Length; d++)
            //    {
            //        fruits[d] = fruits[d] + " " + flavor;
            //        Console.WriteLine(fruits[d]);
            //    }
            //}
            //Console.ReadLine();


            //3.Fix the infinite loop so it will execute.
            //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

            //string[] fruits = { "apple", "orange", "banana", "dragonfruit", "ground cherry" };
            //Console.WriteLine("Enter a flavor profile for these fruits: ");
            //string flavor = Console.ReadLine();
            //bool input = flavor != "0";

            //while (input == true)
            //{
            //    for (int d = 0; d < fruits.Length; d++)
            //    {
            //        fruits[d] = fruits[d] + " " + flavor;
            //        Console.WriteLine(fruits[d]);
            //    }
            //    input = false;
            //}
            //Console.ReadLine();


            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            //string[] fruits = { "apple", "orange", "banana", "dragonfruit", "ground cherry" };
            //Console.WriteLine("Enter a flavor profile for these fruits: ");
            //string flavor = Console.ReadLine();
            //bool input = flavor != "0";

            //while (input == true)
            //{
            //    for (int d = 0; d <=4; d++)
            //    {
            //        fruits[d] = fruits[d] + " " + flavor;
            //        Console.WriteLine(fruits[d]);
            //    }
            //    input = false;
            //}
            //Console.ReadLine();



            //6.Create a List of strings where each item in the list is unique.Ask the user to select text to search for in the List.Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.

            //List<string> triathletes = new List<string>() { "Jelle", "Judith", "Peter", "Clara", "Jenn", "Michelle", "Alex", "Kathryn" };
            //List<string> searchResults = new List<string>();
            //Console.WriteLine("Enter the name of the athlete you are searching for: ");
            //string searchName = Console.ReadLine();

            //foreach (string triathlete in triathletes)
            //{
            //    if (searchName == triathlete)
            //    {
            //        Console.WriteLine(triathlete);
            //        searchResults.Add(triathlete);
            //    }

            //}
            //if (searchResults.Count == 0)
            //{
            //    Console.WriteLine("Sorry, no athletes by that name were found.");
            //}
            //Console.ReadLine();

            //8.Add code to that above loop that stops it from executing once a match has been found.
            //List<string> triathletes = new List<string>() { "Jelle", "Judith", "Peter", "Clara", "Jenn", "Michelle", "Alex", "Kathryn", "Jelle" };
            //List<string> searchResults = new List<string>();
            //Console.WriteLine("Enter the name of the athlete you are searching for: ");
            //string searchName = Console.ReadLine();
            //bool result = false;


            //    foreach (string triathlete in triathletes)
            //    {
            //        while (result == false)
            //        if (searchName == triathlete)
            //        {
            //            Console.WriteLine(triathlete);
            //            searchResults.Add(triathlete);
            //            result = true;
            //        }

            //    }
            //    if (searchResults.Count == 0)
            //    {
            //        Console.WriteLine("Sorry, no athletes by that name were found.");
            //    }
            //    Console.ReadLine();

            //9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
            //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.

            //List<string> triathletes = new List<string>() { "Jelle", "Judith", "Peter", "Clara", "Jenn", "Michelle", "Alex", "Kathryn", "Jelle" };
            //Console.WriteLine("Enter the name of the athlete you are searching for: ");
            //string searchName = Console.ReadLine();
            //bool hasFoundValue = false;

            //for (int j = 0; j < triathletes.Count; j++)
            //{

            //        if (searchName == triathletes[j])
            //        {
            //        Console.WriteLine(j);
            //        hasFoundValue = true;
            //        }
            //}
            //if (!hasFoundValue)
            //{
            //    Console.WriteLine("Sorry, no athletes by that name were found.");
            //}
            //Console.ReadLine();

            //11.Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.

            //List<string> triathletes = new List<string>() { "Jelle", "Judith", "Peter", "Clara", "Jenn", "Michelle", "Alex", "Kathryn", "Jelle" };

            //bool hasFoundValue = false;

            //for (int j = 1; j < triathletes.Count; j++)
            //{
            //    for (int i = 0; i < j; i++)
            //    { if (triathletes[i] == triathletes[j])
            //        {
            //            Console.WriteLine(triathletes[j] + " appears in this list at least twice.");
            //            hasFoundValue = true;
            //        }
            //    }
            //}
            //if (!hasFoundValue)
            //{
            //    Console.WriteLine("No athlete names appear more than once in this array");
            //}
            //Console.ReadLine();
        }
    }
}
