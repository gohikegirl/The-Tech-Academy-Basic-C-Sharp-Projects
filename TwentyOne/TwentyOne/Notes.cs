using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Notes
    {
        //LAMBDA EXPRESSIONS
        //Consider int count = deck.Cards.Count(x=>x.Face==Face.Ace)
        //This is essentially asking to create a variable "count" that looks/loops through a deck of cards and
        //counts (which is a function of lists, which deck.Cards are) where each card (x) whose face (x.Face) is Ace (Face.Ace)
        //Can also apply functions to the lambda function as it loops around--for instance. int sum = numberList.Sum (x=> x+5)
        //This sums up all of the numbers in a list but first adding 5 to each item in the list
        //Another example is int sum=numberList.Min(); (finds the minimum value in a list)
        //You can string multiple lambda functions together in one element
        //NOTE: if you use a lambda expression, it is hard to debug because the computer cannot step through the code the way it can when you do it manually


        //enums are a data type that has a fixed set of options--e.g., days of the week--that one is trying to keep the possible instances of that data limited to
        //can name them within a class or in a main program
        //if limiting user inputs (in string form) to an enum, must use the ([enter enum])Enum.Parse(typeof(enter enum), [enter string variable])
        
        //classes vs structs: structs are pretty much like classes except that they contain values not references
        //structs are good to use instead of classes when the value of an item in the struct/class there is not going to change ever
        //structs are not "nullable"--they must have a value
        //examples of structs are integers, boolean,
        //strings are always values
        
    }
}
