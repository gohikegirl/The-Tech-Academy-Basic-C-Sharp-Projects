﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Notes
    {
        //I/O FILES
        //To create a text file with some text in it, create a string variable with text
        //Then use File.WriteAllText("@[insert file path], text");
        //Can be used on a string array as well
        //Many other methods exist--e.g., ReadAllText (set a variable with this function to get the values)
        //Example:
            // string text = "Here is some text.";
            //File.WriteAllText("C:\\Users\\egllenp\\Desktop\\TechAcademyProjects\\log.txt", text); //needs the "@" to denote that the backslashes are not escape characters but literally
        //Remember that one should use StreamWriter class to ensure that you don't unnecessarily create too many strings (StreamWriter disposes of strings once done)--see Dealer/IO text file creation for example
        
        //LOGGING
        //Putting some sort of entry into a file or database to record a particular action/transaction--e.g., errors, method calls
        //Logging function is Systems.IO part of the C# libraries--need to set this in by using "using System.IO;
        
        //

        //LAMBDA EXPRESSIONS
        //Consider int count = deck.Cards.Count(x=>x.Face==Face.Ace)
        //This is essentially asking to create a variable "count" that looks/loops through a deck of cards and
        //counts (which is a function of lists, which deck.Cards are) where each card (x) whose face (x.Face) is Ace (Face.Ace)
        //Can also apply functions to the lambda function as it loops around--for instance. int sum = numberList.Sum (x=> x+5)
        //This sums up all of the numbers in a list but first adding 5 to each item in the list
        //Another example is int sum=numberList.Min(); (finds the minimum value in a list)
        //You can string multiple lambda functions together in one element
        //NOTE: if you use a lambda expression, it is hard to debug because the computer cannot step through the code the way it can when you do it manually

        //ENUMS
        //enums are a data type that has a fixed set of options--e.g., days of the week--that one is trying to keep the possible instances of that data limited to
        //can name them within a class or in a main program
        //if limiting user inputs (in string form) to an enum, must use the ([enter enum])Enum.Parse(typeof(enter enum), [enter string variable])

        //CLASSES and STRUCTS
        //classes vs structs: structs are pretty much like classes except that they contain values not references
        //structs are good to use instead of classes when the value of an item in the struct/class there is not going to change ever
        //structs are not "nullable"--they must have a value
        //examples of structs are integers, boolean,
        //strings are always values

        //INTERFACES
        //Can create an interface instead (similar set up method) which allows a class to inherit properties and other things from more than just one other class
        //Denoted in nomenclature by preceding with an "I" (e.g., IWalkAway)
        //Once set up, can have a class linked to it by putting a comma after the name of the class from which properties are being inherited.

        //PROPERTIES
        //Values that are associated with the class and can have value assigned to them
        //Can include string, int, bool variables, lists, and dictionaries 
        //public [string/int/bool] [name] {get; set;}
        //public List<[type of data]> [name] {get; set}
        //public Dictionary<[data type], [_data type]> [name] { get; set; }<--dictionaries have a "_" before it 
        //Note: sometimes when setting up lists as public properties, you need to ensure that you will always have a list to fill when the property is called. 
        //can do so by setting up a private list (using _[name])) and then inserting it into the "get/set" part of the public property
        //and setting it to a value--e.g., {get {return _name;} set {_name = value;}}
        //Note: good to set something to private if you know that a method/object is going to be used within a single class
        

        //CONSTRUCTOR
        //Creates a new object within a class that can be called up within a program
        //Can be public or private
        //Takes inputs (e.g., public Player (string name, int beginninng balance))
        //In brackets below the initial line, create the properties of the class by setting their
        //value to the inputs of the constructor

        //CLASS
        //Creates a new category of code that can be called up repeatedly and with constant parameters
        //Start by adding a class to the project and naming it
        //Make public or private depending on how much you want others to be able to access
        //Can be assigned properties of varying sorts--e.g., status, lists, etc. (again public or private) with the ability to "get" and "set"
        //Can also create a Constructor--i.e. an object whose properties are set consistently each time the class is instantiated in a program
        //Can also create methods that are associated with the class
    }
}
