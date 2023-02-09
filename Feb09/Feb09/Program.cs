using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb09
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Arraye in c# :");
            ArrayEx array = new ArrayEx();
            array.singleDimentionEx();
            Console.Write("\n\n");
            array.minimumArrayEx();
            Console.Write("\n\n");

            //equality comparision is used compare the value types and reference types
            Console.WriteLine("equality comparision is used compare the value types and reference types");
            EqualityComparisonEx equalityComparison = new EqualityComparisonEx();
            equalityComparison.referenceEqual();
            Console.Write("\n\n");


            JaggedArray jarray= new JaggedArray();
            jarray.arrayCreation();
        }
    }
}
