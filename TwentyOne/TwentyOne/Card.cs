using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        //public Card() //constructor--allows assignment of property states upon creation
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}

        public Suit Suit { get; set; } //get and set the only functions that you can use with property
        public Face Face { get; set; }

        public override string ToString() //custom ToStringMethod
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
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
    public enum Face
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    
}
