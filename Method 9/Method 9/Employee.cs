using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_9
{
    public class Employee<T>
    {
        public string Name { get; set; }
        public int id { get; set; }
        public List<T> Things { get; set; }
    }
}
