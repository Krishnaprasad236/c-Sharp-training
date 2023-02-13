using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb10
{
    internal class ReverseString
    {
        public void reverse()
        {
            Console.WriteLine("enter a string ");
            string n=Console.ReadLine();
            char[] array = n.ToCharArray();

            Array.Reverse(array);

            string n1 = new string(array);
            Console.WriteLine(n1);

            int len = n.Length;

            char[] c = new char[len];

            for(int i=0;i<c.Length;i++)
            {
                c[i] = n[i];
            }

            for(int i=0;i< len;i++)
            {
                Console.WriteLine(c[i]);
            }
            char[] c1= new char[len];
            for(int j=len;j<=0;j--)
            {
                c1[j] = c[j];
            }
            Console.WriteLine(c1);
        }
    }
}
