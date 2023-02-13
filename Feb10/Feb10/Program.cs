using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Properties in C#");
            PropertiesEx properties = new PropertiesEx();
            properties.collect();

            ReverseString tring= new ReverseString();
            tring.reverse();
        }
    }
}
