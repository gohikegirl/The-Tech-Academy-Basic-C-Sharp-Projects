using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Interfaces
{
    interface IWalkAway //create interfaces to create an inheritance relationship that allows a class to inherit from more than
        //one other class
    {
        void WalkAway(Player player); //all interfaces are public
    }
}
