using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Notes
    {

        //MVC Demo 2
        //Bundles --defined in the App Start folder and Bundle Config section of the Sol Expl--often point to the various bootstrap and jquery libraries in Scrips and Content
        //NuGet = application that manages the install and uninstall and version management of 3rd party libraries (Managing packages found under Tools)--will also 
        //automatically download and install any dependencies 
        //If you let Visual Studio automatically generate the projects, will store the packages that are needed for the application in its metadata
        //Can use intellisense to build up form quickly" @using (Html.BeginForm("SignUp", "Home", FormMethod.Post))"
        //Can create a signup method in controller that has parameters that perfectly match the inputs of the sign-up form (just create a strings)<--MVC will know to map those automatically to the input tags (via Model Binding)
        //Newsletter exercise should have a good example of creating a sign up page, writing to a DB, pulling info from the DB and displaying
        //VIEW MODELS
        //A model that is stripped down to only what you need to see and protect private info
        //You need to first create a new folder in the project that is clearly marked as for View Models
        //Then create a new class again named so that it is clear that is ia Vm and the set up only the properties that can be viewed
        //Then map the broader model mappings to the VM model mappings in the Controller (this can be done manually or through a library) and then pass only the VM to the View page

        //ENTITY FRAMEWORK
        //3rd party application that looks at your database and generates classes for every table in the Db and a props that corresponds to the columns in the table
        //creates a connect that is accessible to anywhere in your application
        //Using EF:
        //Remember to add a new item—class library, data, then ADO.Net Entity
        //Map to server and database desired with appropriate authentication
        //Allow the new Entity Model to set itself up and then right click and modify (if need to make changes to DB in meantime)
        //Will see bundles of files under the .edmx heading—includiing .cs files that correspond to the tables that we have built in the DB
        //Once changes are made to the objects created within these classes, can use methods to write them back to the DB.
        //Partial class only applies in certain context—e.g., Newsletter Context—want to keep special methods separate from this class bc this file is updated in its entirety everytime a new schema is uploaded
        //Connection string arising from this class is also logged in details in the webconfig file
        //Using in a controller to read:
        //To utilize the entity framework, you call the Entity with “using” and instantiate a new entity
        //Then create two lists—one based on the db.[tablename] and another based on the viewmodel
        //Then create a look where each item in the db table gets a corresponding element in the viewmodel list, the values of which are set by the db table and then added to the viewmodel list.
        //Using in a controller to write new info
        //call the entity with the using statement
        //create a new variable that becomes a new element/record in the database
        //map the inputs from the method calling in the info to the new element's properties
        //then add the new element to the db (db.Add([object]) and then save to the db (db.SaveChanges())
        //Creating a "Removed" flag 
        //Delete from table design and replace with a “Removed” column with a datetime datatype-flags areas where data was removed.
        //Then open .edmx file and update tables—then delete removed column from the model (will add Remove but NOT take out the removed column. Corresponding model/class files will now update. 

        //Using to unsubscribe
        //Create some mechanism in view to 1) identify the record or item to remove (preferably id--must be in viewmodel) 2)indicate initiation of an Unsubscribe method
        //Then create a method to unsubscribe that 1) Calls the connection Entity 2) creates a variable that corresponds to the record in the database needed (e.g., var signup = db.SignUps.Find(Id))
        //Then update the object (signup.Removed = DateTime.Now) and savechanges(db.SaveChanges())
        //Ensure that the method in the Index only shows those records that have NOT been removed
        //Option A: var signups = db.SignUps.Where(x=> x.Removed==null).ToList()<--putting this into the creation of the very list that is displayed
        //Option B: var signups = (from c in db.SignUps where c.Removed == null select<--uses Linq





        //MVC DEMO BUILD
        //Create page set up in MVC-->Set up DB with exactly corresponding properties as column names-->Create new MVC project with DB Mgmt
        //Then create a CONTROLLER page for the DB and put in the private variable _stringConnection in the class (but NOT in any method)
        //Before we make any database calls, we need a MODEL to map our results to. To do this, we are going to create a new class in our Models folder called Student. 
        //It is going to have properties that mirror our database table “Students” exactly
        //Then we update the Index (or other) method in the CONTROLLER file to conduct the call of the information from the BD
        //We also build an Index page that supports the details that we are calling from the DB and creates an option to add a student
        //We then build out an Add View (first the method in the controller and then the corresponding view)--note that the button that we 
        //have created of type "submit" then "posts" the form once clicked (just as the method specifies)
        //Also, you are allowed to have Controller methods with the same name as long as they are a different HTTP type. 
        //So you can have one method called Add that is a GET, and another called Add that is a POST. (As a note, all Controller methods 
        //are GETs unless otherwise specified). You can "decorate" your post method in the CONTROLLER by using a tag like [HttpPost]


        //MVC WORKSHOP
        //If you go to a webpage that is being powered by the MVC project that is created, can find the local host info
        //After the host info you can then list \xxxxx\xxxx <--this is called a route, which tells the browser and server which file or location it needs to go
        //Note: there is no .XXXX after the final word in the route
        // The first name after the host info is the first word in the Controller class (in this case, HomeController : Controller)
        //[thing_being_controlled][Controller].cs<--naming convention for controller docs
        //It then goes to the method that is being called (e.g., Contact) and returns a ActionResult (data type) called View, which looks in the Views Folders for a class file by the method name specified 
        //Will pull up a .cshtml file--anything highlighted in yellow will be C# code that needs to be rendered into HTML (bc browsers cannot understand C#)    
        //[Local host info]\home\index is the default route for a web application
        //To pass a method a parameter, must use the URL: /Home/Instructors/[number of object]

        //Part Three--Ex 1
        //Can create a log each time one logs into a home page by creating a string that is then written to a file using the System.IO.File.WriteAllText() function
        //Can also create a random number that is put into a ViewBag (a dynamic dictionary that can take in a bunch of data types and then be called to be published on a page)
        //ViewBag.[Enter name to be created] = [variable]
        //@ViewBag.[name created]
        //Even when you delete "everything" in a View page, you still have a bunch of whitespace left--this draws off of the Shared Folders styles and code
        //Various types of returns:    
        //When you type in "return View(["insert page"])" will call a method that gets the corresponding view<--if parentheses are empty, will automatically go to index
        //return Content("[text]")<--returns whatever text is in between the brackets
        //return RedirectToAction("[insert other method in controller");
        //Can also take in parameters into each controller method that then gets called up in logic later on

        //MODELS
        //To create a model, create an object within the controller file and pass it into the View()
        //Then you can pass into a model within the View file  by using "@model [insert name of object--you may need the entire namespace chain to denote what you want]
        //Then call it like any other variable--going by the name "Model"--will act like any class or object
        //Note: need to precede any C# logic with "@" to evoke Razor engine which highlights what needs to be rendered in HTML
        //By calling the model like an object--e.g., @Model.[Property]--you can make this dynamic data (i.e., it updates with whatever is being passed into the model properties elsewhere)




        //MVC
        //Stands for models, views, and controller--the major areas of the application and arranging framework
        //Includes bootsrap and other common libraries
        //Views contains files in .cshtml format (C# HTML)--C# is rendered in the server 
        //Controller inherits from a larger class of Controllers--stands on the frontline of the application routes incoming requests to the right place in the application
        //Note: MVC is a common term for organizing code, though other vendors have come up with different names for their code arranged like this


        //Web forms
        //Create new project in Web, ASP.Net Web forms
        //Has drag and drop view and autoupdate of underlying code, and hovering over objects provides you the object names

        //ASP.Net
        //Framework for making webpages--usually MVC, webforms, web applications



        //ENTITY
        //Created as a class and named an --usually means that the properties within that class map exactly to a database columns
        //See ADO.net example in the Program for how this can be useful (e.g., reading from a database to application)

        //DATABASE ACCESS
        //ADO helps to access databases and write them into C#
        //Visual Studio has SQL Server Object Explorer--can open this to create a table or view it in a UI similar to that of SQL Server
        //Can create a method within the main or other class to log things to a DB

        //First need to create a connection string: string connectionString = "[insert connection string--get by right clicking on DB in SQL SErver and getting Connection String]"

        //Then can create a query statment:
        //NOTE: SQL injection--should always check user inputs first before allowing query statements to be processed--can do so with parameterized queries
        //e.g, "INSERT INTO Exceptions (ExceptionType, ExceptionMessage, Timestamp) " +
        //"VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)";

        //Then create a using statement that incorporates the SqlConnection class and Sql commands to activate the connection and query strings
        //using SqlConnection connection - new SqlConnection(connectionString)<--takes the connection string derived from the DB
        //{SqlCommand command = new SqlCommand(queryString, connection)<--takes the query string and the new SqlConnection
        //command.Parameters.Add("@ExceptionType", SqlDbType.VarChar); <--names the placeholder from the INSERT statements and sets the data types that can be inserted to protect against injection
        //command.Parameters["@ExceptionType"].Value = ex.GetType().ToString(); <--/gets the type of exception that is collected when it is thrown and converts to string

        //Finally, open the connection, excecute the command under the set parameters and close the connection
        //connection.Open();
        //command.ExecuteNonQuery();
        //connection.Close();

        //EXCEPTION HANDLING
        //Entry or something that happens in a program that breaks up the ability of a program to progress forward
        //Can try to prevent these by using the try/catch combo
        //Can simmulate what happens to a user when a person does not have a debugging mode or app like Visual Studio
        //Better prevented from the start--for example:
        //exception handling loop for invalid entries
        // bool validAnswer = false;
        //int beginningBalance = 0;
        // while (!validAnswer)
        // {
        //   Console.WriteLine("And how much money did you bring today?");
        //   validAnswer = int.TryParse(Console.ReadLine(), out beginningBalance);
        //}
        //exception handling for specific conditions being met
        //if (condition)
        //{ throw new Exception();}
        //Also can wrap in a try (insert usual formula) and then catch with message and "return" to end
        //try
        //{
        //game.Play();
        //}
        //catch (Exception)
        //{
        //Console.WriteLine("An error occurred. Please contact your System Administrator.");
        //return;
        //}

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
        //Must have the same name as the class in which it is being created
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
