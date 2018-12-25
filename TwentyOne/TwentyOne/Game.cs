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
        public List<string> Players { get; set; } //sets up a characteristic of the class "Game"
        public string Name { get; set; }
        public string Deadler { get; set; }

        public abstract void Play(); //abstract method: sets up a method that must be implemented by all inheriting subclasses 
        //Must be part of an abstract class

        public virtual void ListPlayers() //sets up a method that is can be used on any Game (actually creates an implementation)
            //virtual method can be overridden when called
        {
            foreach(string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
