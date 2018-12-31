using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //creates an "abstract" class--is never created as an object in the main program, 
        //as it is only used to pass on a general set of characteristics to inherting classes
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } } //sets up a characteristic of the class "Game"
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
        

        public abstract void Play(); //abstract method: sets up a method that must be implemented by all inheriting subclasses 
        //Must be part of an abstract class

        public virtual void ListPlayers() //sets up a method that is can be used on any Game (actually creates an implementation)
            //virtual method can be overridden when called
        {
            foreach(Player player in Players)
            {
                Console.WriteLine(player.Name);
            }

        }
        
    }
}
