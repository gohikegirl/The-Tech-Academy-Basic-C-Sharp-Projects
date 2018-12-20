using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card() //constructor--allows assignment of property states upon creation
        {
            Suit = "Spades";
            Face = "Two";
        }

        public string Suit { get; set; } //get and set the only functions that you can use with property
        public string Face { get; set; }
    }
}
