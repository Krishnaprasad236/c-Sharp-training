using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDay31
{
    internal class SwitchStatement
    {
        public void methodStatement()
        {
            Console.WriteLine("\n");
            Console.WriteLine("This is switch statement");
            Console.WriteLine("enter two number :");
            int a =Convert.ToInt32(Console.ReadLine());
            int b =Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("1.additon , 2.substraction , 3.multiplication,  4.division");
            Console.WriteLine("Eneter your choice :");
            int ch=Convert.ToInt32(Console.ReadLine());
            ConsoleKeyInfo s;
            Console.WriteLine("The result is :");
            while(true)
            {
                switch(ch)
                {
                    case 1:
                        Console.WriteLine(a+b);
                    break;
                    case 2:
                        Console.WriteLine(a-b);
                    break;
                    case 3:
                        Console.WriteLine(a*b);
                        break;
                        case 4:
                            Console.WriteLine(a/b);
                        break;
                    default: Console.WriteLine("invalide key");
                        break;
                }
                Console.WriteLine("do you want to exit(Y/n) :");
                s = Console.ReadKey();
                if(s.Key==ConsoleKey.Y)
                {
                    break;
                }
                else if(s.Key!=ConsoleKey.Y)
                {
                    Console.WriteLine();
                    methodStatement();
                }
                Console.Clear();
            }
        }
    }
}
