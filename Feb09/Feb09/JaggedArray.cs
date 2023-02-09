using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb09
{
    internal class JaggedArray
    {
        public void arrayCreation()
        {
            Console.WriteLine("Enter firs array length ");
            int len=Convert.ToInt32(Console.ReadLine());

            int[][] array= new int[len][];

            Console.WriteLine("Entr second array Length :");
            for (int i=0; i < array.Length; i++)
            {
                array[i] = new int[Convert.ToInt32(Console.ReadLine())];
            }

            Console.WriteLine("eneter elements :");
            for(int i=0;i<array.Length;i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(" class of :" + i +"  enter student age: " + j +" :");
                    array[i][j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            for (int i=0;i<array.Length;i++)
            {
                for(int j = 0; j < array[i].Length;j++)
                {
                    Console.Write("student ages No "+j+": "+array[i][j] +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
