using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb07
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Anonymouse types \n1.Lambda Expression \n2.anonymouse methods   :");
            AnonymouseEx anonymouseEx = new AnonymouseEx();
            anonymouseEx.lambdaExm();
            anonymouseEx.LambdaEx2();
            anonymouseEx.lamdbdaEx3();

            // Recursion is a process calling the function by it self . 
            Console.WriteLine("Recursion and Recursion method :");
            RecursionMethodEx rm = new RecursionMethodEx();
            rm.inputRecursion();


            AccessModifiers am= new AccessModifiers();
            Console.WriteLine(am.public1);
            Console.WriteLine(am.internal1);
            Console.WriteLine(am.protectedEx());
            Console.WriteLine(am.privateEx());

            //constructor 
            ConstructorAndThisWord ct=new ConstructorAndThisWord("constructor with this key word");
            Console.WriteLine(ct.name);


        }
    }
}
