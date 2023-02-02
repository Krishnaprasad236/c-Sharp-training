using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb02
{
    internal class Demo2
    {
        public void bank()
        {
            // exception handling by using the try,catch block
            try
            {
                Console.WriteLine("Connection to the bank server ");
                Demo1 d1 = new Demo1();
                d1.atm();
            }
            catch (Exception e) 
            {
                Console.WriteLine("issue reached bank server"+e);
            }
            Console.WriteLine("Connection to main server is terminated ");
        }
    }
}
