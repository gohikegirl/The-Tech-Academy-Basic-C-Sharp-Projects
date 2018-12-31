using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck() //creates a constructor
        {
            //still individually based construction of cards within the larger constructor (not very efficient)
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);

            //new approach to creating a deck--creates a new list of cards all in a nested loop
            Cards = new List<Card>();
            List<Suit> Suits = new List<Suit>() { Suit.Clubs, Suit.Hearts, Suit.Diamonds, Suit.Spades };
            List<Face> Faces = new List<Face>()
            {
                Face.Two,Face.Three,Face.Four,Face.Five,Face.Six,Face.Seven,Face.Eight,Face.Nine,Face.Ten, Face.Jack,Face.Queen, Face.King, Face.Ace
            };

            foreach (Face face in Faces)
            {
                foreach (Suit suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public Deck Shuffle(Deck deck, out int timesShuffled, int times = 1) //creates public method without an object returning a class Deck and creates OPTIONAL parameter by giving a default value
                                                                             //also has an optional paramater (default value, always at the end of the parameters) and an out parameter that passes a value to a variable named in the program
        {
            timesShuffled = 0; //sets the variable  that is an output of this method at a value of 0
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>(); //create a new list that can be filled with cards
                Random random = new Random(); //calls a randomizing method
                while (Cards.Count > 0) //creates loop, removing cards from one list into another in until there are no more to move
                {
                    int randomIndex = random.Next(0, Cards.Count); //creates a bunch of indexes at random between 0 and 52
                    TempList.Add(Cards[randomIndex]); //creates new cards based on the cards from the original deck at random places determined by the index
                    Cards.RemoveAt(randomIndex); //removes corresponding cards from the original deck
                }
                Cards = TempList; //changes the values of the original deck of cards to the new deck (based on the temp deck created)
            }
            return deck;

        }
    }
}
    
    

    


