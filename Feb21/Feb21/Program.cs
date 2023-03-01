using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Feb21.GenericClassEx1;

namespace Feb21
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* Console.WriteLine("collection frame work");
             CollectionEx al = new CollectionEx();
             Console.WriteLine("System.Collection.Generic :");
             al.linkedListEx();
             al.listEx();
             al.sortedsetEx();
             Console.WriteLine("\n\n");
             CollectionEx1 al1 = new CollectionEx1();
             Console.WriteLine("System.Collection :".ToUpper());
             al1.arrayListEx();
             al1.sortedListEx();
             al1.queueEx();
             al1.stackEx();
             al1.hashTableEx();*/
            int[] ints= { 26,53,69,45 };
            string[] ints2 = { "kri", "pra", "sad" };
            Console.WriteLine("Generic classess");
            GenericClassEx genericClass= new GenericClassEx();
          /*  genericClass.Addition();*/
            GenericClassEx1 genericClass1= new GenericClassEx1();   
            genericClass1.genericInput();
        }
    }
}
