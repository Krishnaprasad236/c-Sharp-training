using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb08
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Strings in c# ");
            StringMethods sl = new StringMethods();
            sl.stringTest();
            Console.WriteLine("enter two word to comapre");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            sl.comparTest(s1,s2);
            sl.stringMethodsEx();
            sl.formateAlignment();


            //Expression bodied member : used for creating the memeber functions in simple and readable formate 
            Console.WriteLine("Expression bodied member :");
            MethodType ebm = new MethodType();//methode type has sigle expression with returntype and same return value 
            ebm.name = "Granite River labs";
            ebm.showMethod();

            //property type : it consists of properties and and set the value and get the value 
            PropertyType pt = new PropertyType("vijayawada");
            Console.WriteLine("by using the propery of the variable :" + pt.hideMethod);
            PropertyType ex = new PropertyType("guntur");
            Console.WriteLine("Property type by using the constructor  :" + ex.locationName);

            MethodType ebm1 = new MethodType("grl", "connect to the world");
            Console.WriteLine("Method type with string method =>" + ebm1.DisplayName());


            //Read-only type: it can implement the read only property 
            Console.WriteLine("Enter two numbers");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Read_only_Type rot = new Read_only_Type(a, b);
            Console.WriteLine("addition of two number :" + rot.Sum());
            Console.WriteLine("substraction of two numbers :" + rot.Sub());
            Console.WriteLine("multiplication of two number : " + rot.Mul());
            Console.WriteLine("division of two number : " + rot.Div());


            //indexer type : it also known ad smart array and use the class members
            IndexerEx i = new IndexerEx();
            i.indexerInput();


        }



    }
}
