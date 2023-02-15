using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb14
{
    internal class InterfaceEx1 : AbstractEx, InterFaceEx
    { 
        double a=Convert.ToInt32(Console.ReadLine());
        double b=Convert.ToInt32(Console.ReadLine());
        public  void sum()
        {
            Console.WriteLine("interface method implementation :"+(a+b));
        }

        public  void sub()
        {
            Console.WriteLine("interface method implementation :"+(a-b));
        }
        public void mul()
        {
            Console.WriteLine("interface method implementation :"+(a * b));
        }

        public override void percentage()
        {
            Console.WriteLine("abstract methods extended : "+((a+b)/100)+"%");
        }
        public override void div()
        {
            Console.WriteLine("abstract methods extended :" + (a /b));
        }

        public override void modul()
        {
            Console.WriteLine("abstract methods extended :" + (a %b));
        }
    }
}
