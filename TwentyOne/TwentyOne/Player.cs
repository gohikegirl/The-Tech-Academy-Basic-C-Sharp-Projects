using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player //<T> creates a generic class of Player that becomes more specific when specific data is passed into T when called in main program
    {
        public List<Card> Hand { get; set; } //would replace <Card> with <T> if making more generic
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        //creates a new overloaded operator (math operator) that does something to another class or object--in this case, adds or substracts a new player
        //to the Game
        public static Game operator+(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator-(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
