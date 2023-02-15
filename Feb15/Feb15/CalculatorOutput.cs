using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Feb15
{
    internal class CalculatorOutput
    {
        public void notficationR(double a,double b)
        {
            Console.WriteLine("Enter your choice :");
            Console.WriteLine("1.ADDTION\n2.SUBSTRACTION \n3.MULTIPLICATION \n4.DIVISION");
            int key=Convert.ToInt32(Console.ReadLine());

            switch(key)
            {
                case 1:
                    Console.WriteLine("the addition of twp numbers      : " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("The substraction of two numbes   :" + (a - b));
                    break;
                case 3:
                    Console.WriteLine("The multiplication of two numbes :" + (a * b));
                    break;
                case 4:
                    Console.WriteLine("The division of two numbes       :" + (a / b));
                    break;
                default:
                    ConsoleKeyInfo s = Console.ReadKey();
                    if (s.Key == ConsoleKey.Y)
                    {
                        break;
                    }
                    break;
            }
        }
    }
}
