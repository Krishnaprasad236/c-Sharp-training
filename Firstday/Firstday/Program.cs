using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstday
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("enter first number :");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number :");
            int b=Convert.ToInt32(Console.ReadLine());

            Addition sum=new Addition();
            Console.WriteLine("sum of two number : "+sum.sum(a, b));

            Substarction substarction=new Substarction();
            
            Console.WriteLine("substraction of two number :"+substarction.sub(a, b));

            Multiplication multiplication=new Multiplication(); 
            Console.WriteLine("multiplcation of two numbers :"+multiplication.mul(a, b));
           

            Division division=new Division();
            Console.WriteLine("dividion of two numbers :"+division.div(a,b));

        }
    }
}
