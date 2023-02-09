using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb09
{
    internal class ArrayEx
    {
        public void singleDimentionEx()
        {
           
            Console.WriteLine("Enter array length :");
            int len=Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            int[] array1=new int[len];

            Console.WriteLine("Enter first elemnets");
            for(int i=0;i<array.Length;i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter second elements ");
            for(int j=0;j<array1.Length;j++)
            {
                array1[j]= Convert.ToInt32(Console.ReadLine());
            }
            int[] arr = new int[len];
            for(int i=0;i<array.Length;i++)
            {
                arr[i] = array[i] + array1[i];
            }

            Console.WriteLine("addition of two array are  :");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
        }

        public void minimumArrayEx()
        {
            int[] arra = { 12, -12, 35, 10, 65 };

            int min = arra[0];
           
            for(int i=0;i<arra.Length;i++)
            {
                Console.Write(arra[i]+" ");
                if (arra[i] < min)
                {
                    min = arra[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("minimum number is"+min);
        }
    }
}
