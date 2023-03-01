using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb21
{
    internal class GenericClassEx
    {
        public class CalculateGenaric<T>
        {
            public T a;
            public T b;
        }
       


        public void Addition()
        {
            Console.WriteLine("enter two elements :");
            double first=Convert.ToDouble(Console.ReadLine());
            double second=Convert.ToDouble(Console.ReadLine());
            CalculateGenaric<double> gc= new CalculateGenaric<double>();
            gc.a=first;
            gc.b=second;
           if(gc.a!=0)
            {
                Console.WriteLine(gc.a+gc.b);
            }
           else
            {
                Console.WriteLine("number not found");
            }
        }
    }
}
