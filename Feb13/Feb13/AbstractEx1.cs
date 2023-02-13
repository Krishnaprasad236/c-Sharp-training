using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Feb13
{
    class AbstractEx1:AbstractEx
    {
        public override void rectangle()
        {
            Console.WriteLine("enetr a length,breath and radius:");
             l=Convert.ToDouble(Console.ReadLine());
             b=Convert.ToDouble(Console.ReadLine());
             r=Convert.ToDouble(Console.ReadLine());

            if(l>-1 && b>-1)
            {
                Console.WriteLine("the area of the rectanlge is " + l * b);
            }
            else
            {
                Console.WriteLine("invalide inputs");
            }

            Console.WriteLine("circumeference of the rectangle is "+(2*l*b));
        }

        public override void square()
        {
            Console.WriteLine("the circumeference of the square is " + (l * l));
        }
        public override void circle()
        {
            Console.WriteLine("the area of the circle is " + (3.142 * r * r));
            Console.WriteLine("circumeference of the circle is " + (2 * 3.142 * r));
        }

        public override void triable()
        {
            Console.WriteLine("enter hight of the triangle :");
            h= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("the area of the trangle is " + (0.5 * b * h));

        }
    }
}
