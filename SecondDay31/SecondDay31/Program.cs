using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDay31
{
    internal class Program
    { 
        public static void Main(string[] args) 
        {
            Console.WriteLine("enter length of the array: ");
            int lenght=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter radius of the cirle");
            int[] radi=new int[lenght];
            for(int i=0;i<radi.Length;i++)
            {
                radi[i]=Convert.ToInt32(Console.ReadLine());
            }
            double pi = 3.142;
            //object creation of the statement loop
            CircleCircumference circle=new CircleCircumference();
            circle.radius(radi,pi);

            //object creation of the break statement 
            BreakStatement breakStatement=new BreakStatement();
            breakStatement.statement();

            //object creation for switch statement 
            SwitchStatement switchs=new SwitchStatement();
            switchs.methodStatement();

            //object creation of string interpolation for static methode 
            StringInterpolation.inter();

            //object creation of global and local variables 
            GlobalAndLocalVariable gl=new GlobalAndLocalVariable();
            gl.global();
            gl.local();
            gl.globalLocal();

        }
    }
}
