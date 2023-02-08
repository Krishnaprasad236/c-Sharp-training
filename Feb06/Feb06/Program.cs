using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Feb06
{
    internal class Program
    {
        public readonly struct Coords
        {
            public Coords(int x, int y)
            {
                X = x;
                Y = y;
            }
            public  double X { get; init; }//record class 
            public double Y { get; init; }//record class
            
            public override string ToString()=> $"({X}, {Y})";
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("boxing process :");
            BoxingAndUnboxing.boxingExample();
            Console.WriteLine("unboxing process :");
            BoxingAndUnboxing.unboxingExm();

            //Readonly struct 
            var p1=new Coords(1, 2);
            Console.WriteLine(p1);
            var p2 = p1 with { X = 10 };
            Console.WriteLine(p2);
            var p3=p1 with { X = 20 ,Y=40};
            Console.WriteLine(p3);
            
        }
    }
}
