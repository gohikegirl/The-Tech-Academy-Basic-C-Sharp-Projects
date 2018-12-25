using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Game
    {
        public List<string> Players { get; set; } //sets up a characteristic of the class "Game"
        public string Name { get; set; }
        public string Deadler { get; set; }

        public void ListPlayers() //sets up a method that is can be used on any Game
        {
            foreach(string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
