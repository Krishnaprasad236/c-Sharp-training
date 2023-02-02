using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb02
{
    internal class ThreadingAndMultiThreading
    {
        public void threadEx1()
        {
            Thread t=Thread.CurrentThread;
            t.Name = "main tread";
            Console.WriteLine(t.Name);
            Console.WriteLine(t.IsAlive);
        }

        public static void threadEx2()
        {
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
