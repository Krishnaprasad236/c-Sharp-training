using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDay31
{
    class BreakStatement
    {
        public void statement()
        {
            Console.WriteLine("\n");
            Console.WriteLine("This is break statement :");

            for(int i=0;i<5;i++) 
            {
                for(int j=0;j<5;j++)
                {
                    if(j>i) 
                    {
                        break;
                    }
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
