using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class TwentyOneGame : Game //set up so that now the TwentyOneGame class inherits the properties and methods from Game
    {
        public override void Play()
        {
            throw new NotImplementedException(); //sends out a message when method is called
        }

        public override void ListPlayers() //automatically pulls up the ListPlayers method from Game in a base form that can be 
            //modified with other code
        {
            Console.WriteLine("Welcome to Twenty One!");
            base.ListPlayers();
        }
    }
}
