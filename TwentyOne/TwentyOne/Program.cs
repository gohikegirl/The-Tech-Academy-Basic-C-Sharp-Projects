using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            //creation of new deck of cards
            //Deck deck = new Deck(); //creates an object called deck
            //deck.Cards = new List<Card>(); //indicates that the object will be a list full of cards

            //Card cardOne = new Card(); //creates first card to add to the deck, in this form uses constructor (see Card.cs)
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne); //adds the first card to the deck

            //original creation of new cards, individually
            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);

            //uses constructor that creates the deck first
            Deck deck = new Deck();
            deck = Shuffle(deck); //calls the method below that randomizes the order of the deck
            foreach(Card card in deck.Cards)
             {
                Console.WriteLine(card.Face + " of " + card.Suit);
             }
            Console.WriteLine(deck.Cards.Count);      
            Console.ReadLine();
            
        }

        public static Deck Shuffle(Deck deck) //creates public method without an object returning a class Deck
        {
            List<Card> TempList = new List<Card>(); //create a new list that can be filled with cards
            Random random = new Random(); //calls a randomizing method
            while (deck.Cards.Count > 0) //creates loop, removing cards from one list into another in until there are no more to move
            {
                int randomIndex = random.Next(0, deck.Cards.Count); //creates a bunch of indexes at random between 0 and 52
                TempList.Add(deck.Cards[randomIndex]); //creates new cards based on the cards from the original deck at random places determined by the index
                deck.Cards.RemoveAt(randomIndex); //removes corresponding cards from the original deck
            }
            deck.Cards = TempList; //changes the values of the original deck of cards to the new deck (based on the temp deck created)
            return deck; //sets the new deck with the now randomized card order<--this is called into the program lines above that print out the deck

        }
    }
}
