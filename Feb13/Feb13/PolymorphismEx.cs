using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb13
{
    internal class PolymorphismEx
    {
        public string a = "egale";
        public string b = "bird ";
        public virtual void bird()
        {
           Console.WriteLine(string.Concat(a,b));
        }
    }
}
