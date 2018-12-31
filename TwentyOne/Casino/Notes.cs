using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Notes
    {
     //GUID (global unique identifier)
     // Can create this by using the following code:
        //Guid identifier = Guid.NewGuid();
        
        //CONSTANT
     //Creates a data type that remains constant--e.g. const string casinoName = "Grand Hotel and Casino"
     //Good for setting a value of a variable that you do not want to change and want to restrict
        
     //CONSTRUCTOR CALL CHAIN
    //Allows you to reuse constructors that have already been created (see Player class for example)--by having the constructor inherit at least some of the characteristics of the other constructor
    //Example: public Player (string name): this(name, 100)
        //{
        //} <---does not require an implementation
        //public Player(string name, int beginningBalance)<--the constructor that the Call Chain is drawing off of
    //Player newPlayer = new Player ("Jesse")
    //Another version of this is to use "var"
        //Can be used in place of creating the constructor call chain to shorten the typing related with typing out data types
            //var Player newPlayer = new Player ("Jesse")
        //However, it should be very clear what data type is being referred

    //LIBRARY
    //Can create one by clicking on Solution file and adding a new Solution--> Class Library
    //Creates a new file that looks like a Program file execept for a few differences
    //If creating a library out of another program, drag all files except the Program.cs to the library
    //Rename the namespaces of all .cs files to the new library name. If there is a class that is specific to a particular class of programs that will use the library, create a 
    //library.subnamespace entry for that class. Remember to add the using.namespace.subnamespace to the header if inheriting
    //Then go to original program and add a new Reference--look for library file (.dll) in the repository, namespace, bin, and debug folder

    //ASSEMBLIES
    //All code is either a library--compiled as a .dll--or an executed file--compiled as an .exe. The .exe is an assembly.
    //An assembly is pretty much what you get when you compile your C# code into an intermediate language (.exe)


    //NAMESPACES
    //A grouping mechanism that allows you to divide your code so that you can create subclasses and other ways of organizing your code
    //For instance, if you were to add ".BaseClasses" to the namespace "TwentyOne", you would need to add "using.TwentyOne.BaseClasses" to anything associated with the TwentyOne namespace
    //Namespaces (invoked with "using") make it unneccessary to always type in the namespaces explicitly everytime you wanted to use a method or object associated with it
    //If you create a name space that happens to be the same name as another namespace, you will need to define which higher namespace you mean to associate with 

    //DATETIME
    //Is a struct--cannot be nullable, must have a value (i.e., not reference)
    //Inputs are year, month, day, hour, minute, seconds
    //Can be used to create TimeSpans or other amounts of dates/times



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
