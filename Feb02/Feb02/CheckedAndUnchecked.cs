using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb02
{
    internal class CheckedAndUnchecked
    {
        public void check()
        {
            Console.WriteLine();
            checked
            {
                Console.WriteLine(int.MaxValue);
                int val=int.MaxValue;
               // Console.WriteLine(val+2);
            }
        }
        public void uncheck()
        {
            unchecked
            {
                int val1 = int.MaxValue;
                Console.WriteLine(val1 + 2);
            }
        }
    }
}
