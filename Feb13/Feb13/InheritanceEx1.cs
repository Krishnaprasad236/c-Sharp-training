using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb13
{
    internal class InheritanceEx1:InheritanceEx
    {
        public void display()
        {

            for(int i=0;i<productId.Length;i++)
            {
                Console.WriteLine("Product id  :"+ productId[i] + " product name  :" + pName[i] + " product price  :"+ productPrice[i]);
            }
            Console.WriteLine();
        }
    }
}
