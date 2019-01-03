using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Fraud_Exception : Exception
    {
        public Fraud_Exception() //constructor based off of base
            : base() { }

        public Fraud_Exception(string message) //overloading
            : base()
        { }

       }
}
