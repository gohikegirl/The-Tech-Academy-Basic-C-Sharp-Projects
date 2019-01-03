using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Casino;
using Casino.TwentyOne;


namespace TwentyOne
{
    class Program
    {

        static void Main(string[] args)
        {

            //BRINGING IT ALL TOGETHER
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}. Start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            if (playerName.ToLower()=="admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.ID + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.ReadLine();
            }

            //exception handling loop
            bool validAnswer = false;
            int beginningBalance = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out beginningBalance); //takes the user input and tries to see if it can convert to an integer and gives a true or false
                if (!validAnswer) Console.WriteLine("Pleae enter digits only, no decimals.");
            }


            Console.WriteLine("Hello, {0}. Would you like to join a game of Twenty One?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, beginningBalance);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C: \Users\egllenp\Desktop\TechAcademyProjects\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (Fraud_Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;

                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");

            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }
        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = "INSERT INTO Exceptions (ExceptionType, ExceptionMessage, Timestamp) VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString(); //gets the type of exception that is collected when it is thrown and converts to string
                command.Parameters["@ExceptionMessage"].Value = ex.Message; 
                command.Parameters["@Timestamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        //ADO.Net Example
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, Timestamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) //<--reads through each entry in SQL table, creates a new object and maps the data to the object
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.ID = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["Timestamp"]);
                    Exceptions.Add(exception); //adds the new object to the List Exceptions
                }
                connection.Close(); //closes the connection
            }
            return Exceptions; //returns the output expected by the method
        }

    }

            //METHOD ONE: CREATION OF NEW DECK OF CARDS WITH INDIVIDUAL CARD CREATION
            //Deck deck = new Deck(); //creates an object called deck
            //deck.Cards = new List<Card>(); //indicates that the object will be a list full of cards

            //METHOD ONE-A = CREATION OF NEW CARD INDIVIDUALLY (NOW REPLACED BY DECK METHOD)
            //Card cardOne = new Card(); //creates first card to add to the deck, in this form uses constructor (see Card.cs)
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";
            //deck.Cards.Add(cardOne); //adds the first card to the deck


            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);


            //CREATES NEW GAME OF TWENTY-ONE FROM A BROADER, MORE GENERIC CLASS OF GAMES
            //Game game = new TwentyOneGame(); //can also start with Game game = new TwentyOneGame()--this is an example of polymorphism (can create a new object in an inherited class)
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game = game + player;//can replace with "game += player"
            ////helpful for adding subclasses into a broader superclass

            ////game.ListPlayers();
            ////game.Play(); //called from TwentyOneGame and only accessible from that class
            //Console.ReadLine();

            //METHOD 3: CREATES NEW DECK WHICH IS THEN SHUFFLED INTO RANDOM ORDER A NUMBER OF TIMES
            //Deck deck = new Deck();
            //int timesShuffled = 0; //creates variable that is the receiver of the "out" from the method below
            //deck = Shuffle(deck: deck, timesShuffled: out timesShuffled, times: 3); //calls the method below that randomizes the order of the deck--can add a ",x" that changes the default parameter
            //deck = Shuffle(deck, 3); //calls the method that allows randomization of the deck multiple times
            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.Write("Times shuffled {0}", timesShuffled); //brackets designate that we want to insert the value of the following variable
            //Console.ReadLine();
        

        //METHOD: SHUFFLE
        //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1) //creates public method without an object returning a class Deck and creates OPTIONAL parameter by giving a default value
        //                                                                            //also has an optional paramater (default value, always at the end of the parameters) and an out parameter that passes a value to a variable named in the program
        //{
        //    timesShuffled = 0; //sets the variable  that is an output of this method at a value of 0
        //    for (int i = 0; i < times; i++)
        //    {
        //        timesShuffled++;
        //        List<Card> TempList = new List<Card>(); //create a new list that can be filled with cards
        //        Random random = new Random(); //calls a randomizing method
        //        while (deck.Cards.Count > 0) //creates loop, removing cards from one list into another in until there are no more to move
        //        {
        //            int randomIndex = random.Next(0, deck.Cards.Count); //creates a bunch of indexes at random between 0 and 52
        //            TempList.Add(deck.Cards[randomIndex]); //creates new cards based on the cards from the original deck at random places determined by the index
        //            deck.Cards.RemoveAt(randomIndex); //removes corresponding cards from the original deck
        //        }
        //        deck.Cards = TempList; //changes the values of the original deck of cards to the new deck (based on the temp deck created)
        //    }

        //    return deck; //sets the new deck with the now randomized card order<--this is called into the program lines above that print out the deck

        //}
        //public static Deck Shuffle(Deck deck, int times) //creates second public method that allows user to shuffle multiple times
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    
}


