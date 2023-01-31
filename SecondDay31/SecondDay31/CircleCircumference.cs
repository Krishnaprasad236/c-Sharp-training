using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SecondDay31
{
    internal class CircleCircumference
    {
        public void radius(int[] radi ,double pi)
        {
            Console.WriteLine("\n");
            Console.WriteLine("This is statement declaration in a block");
            for (int i=0;i<radi.Length;i++)
            {
                double circumference = radi[i]*2*pi;
                Console.WriteLine("Radius of circle is : " + radi[i] +"  circumferecnce of the circle is : "+circumference);
            }
            Console.WriteLine();
        }
    }
}
