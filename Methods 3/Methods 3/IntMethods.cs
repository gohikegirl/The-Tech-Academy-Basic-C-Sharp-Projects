using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_3
{
    class IntMethods
    {
        public static int Method (int i)
        {
            return i * i;
        }

        public static int Method (decimal d)
        {
            decimal mResult = d + d;
            return Convert.ToInt32(mResult);
           
        }

        public static int Method (string s)
        {
            int cResult = Convert.ToInt32(s);
            return cResult*cResult;

        }
    }
}
