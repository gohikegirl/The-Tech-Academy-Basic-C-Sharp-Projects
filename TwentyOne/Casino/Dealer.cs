using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); //adds a card to the first position of the players hand
            //create a log of every card that is dealt
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C: \Users\egllenp\Desktop\TechAcademyProjects\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
                
            }
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); //prints the name of the card just added
            Deck.Cards.RemoveAt(0); //removes the card officially from the larger deck

        }
    }
}
