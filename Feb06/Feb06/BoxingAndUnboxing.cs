using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb06
{
    internal class BoxingAndUnboxing
    {
        public static void boxingExample()
        {
            string i = "krishna";
            object o = i;
            int a = 10;
            object b = a;
            a = 100;
            // Here we can convert the any value-type type to object 
            // The value of i can't affect the value 0f object 
            Console.WriteLine("The value-type value :"+i); //The value-type value: 0
            Console.WriteLine("The object-type value :" + o);// The object-type value: 987
            Console.WriteLine("The value-type value :" + a); //The value-type value: 100
            Console.WriteLine("The object-type value :" + b);// The object-type value: 10

        }

       public static void unboxingExm() 
        {
            //unboxing process can convert the object value(same) to value-type(same) value but we can't convert diffent types of date .
            string a = new string("Granite river lab");
             string f=(string)a;
            a = "krishna prasad";                               //output :
            Console.WriteLine("The value-type of value :"+f);// The value-type of value :Granite river lab
            Console.WriteLine("The object-type of value :" + a);// The object-type of value :krishna prasad
        }
    }
}
