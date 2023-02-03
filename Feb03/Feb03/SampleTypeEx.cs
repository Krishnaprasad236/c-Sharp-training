using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb03
{
    internal class SampleTypeEx
    {
        string student = "";
        string sloaction = "";
        public static void sizeFind() 
        {
            Console.WriteLine($"size of int {sizeof(int)}");
            Console.WriteLine($"size of long={sizeof(long)},\nsize of int short={sizeof(short)},\nsize of int sbyte={sizeof(sbyte)}\nsize of int char={sizeof(char)}\nsize of int double={sizeof(double)}\nsize of int decimal={sizeof(decimal)}\nsize of int bool={sizeof(bool)}");
        }

        public static void intEx()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine(a -b);
        }
    }
}
