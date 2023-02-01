using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Feb01
{
    internal class Threading
    {
        public static void threadeExm()
        {
            Thread t = Thread.CurrentThread;
            

            t.Name= "GRL connect to world";
            Console.WriteLine(t.Name);
        }
        public static void myThread()
        {
            for (int i = 0; i < 10; i++)
            { 
                Console.WriteLine("Granite River Labs ");
            }
        }

        public void nonStatic()
        {
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    if(j<i)
                    {
                        Console.Write(i);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
