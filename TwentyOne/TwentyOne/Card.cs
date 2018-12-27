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

        public Suit Suit { get; set; } //get and set the only functions that you can use with property
        public string Face { get; set; }
    }
    public enum Suit //creates a group of options that must be selected when creating an 
        //instance of the data type. Note can look like a string but will actually take on the position
        //index of the list (or whatever index it is assigned)
    {
        Clubs, //add "=x" to assign different index
        Diamonds,
        Hearts,
        Spades
    }
}
