using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balanace { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); //adds a card to the first position of the players hand
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); //prints the name of the card just added
            Deck.Cards.RemoveAt(0); //removes the card officially from the larger deck

        }
    }
}
