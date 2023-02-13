using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb13
{
    internal class InheritanceEx
    {
       public int[] productId = { };
        public string[] pName = { };
       public double[] productPrice = { };

        public void baseClass()
        {
            Console.WriteLine("enter product list :");
            int len=Convert.ToInt32(Console.ReadLine());
                 productId = new int[len];
            Console.WriteLine("enter product id :");
            for(int i=0;i<productId.Length;i++)
            {
                productId[i]= Convert.ToInt32(Console.ReadLine());
            }

            pName = new string[len];
            Console.WriteLine("enter product name :");
            for(int i=0;i<pName.Length;i++)
            {
                pName[i] = Console.ReadLine();
            }

            productPrice = new double[len];
            Console.WriteLine("enter price if the Product :");
            for(int j=0;j<productPrice.Length;j++)
            {
                productPrice[j]= Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
