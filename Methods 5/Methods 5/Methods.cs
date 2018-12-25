using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_5
{
    class Methods
    {
        public void Divide2 (int i, out int result) //create void method and method with output parameter
        {

            int dresult = i / 2;
            result = dresult;
            
        }
        public static int Divide2(int a, int b) //overload
        {
            return (a + b)/2;
        }

        
    }
}
