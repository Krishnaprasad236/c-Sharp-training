using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb14
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Interfaces in C#  :");

          /*  InterfaceEx1 inter = new InterfaceEx1();
            inter.sum();
            inter.sub();
            inter.mul();
            inter.div();
            inter.modul();
            inter.percentage();*/

            FileEx file= new FileEx();
            file.createFile();


        }
    }
}
