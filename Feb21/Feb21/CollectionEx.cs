using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb21
{
    internal class CollectionEx
    {
        public void linkedListEx()
        {
            Console.WriteLine("LinkedList elements ");
            //it can't allows the hetrogeneous data and increase the array length at execution time . it allows the duplicate values 
            //we will add the element where evere we want based on the node 
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(20);
            list.AddLast(30);
            list.AddLast(100);

            LinkedListNode<int> node = list.Find(20);
            list.AddAfter(node, 20);
            list.AddBefore(node, 50);

            foreach(int i in list)
            {
                Console.WriteLine(i+" ");
            }

          
           
            Console.WriteLine("\n\n");
        }

        public void listEx()
        {
            //it can't allows the hetrogeneous data and increase the array length at execution time . it's allows the duplicate values 
            Console.WriteLine("list elements  ");
            List<int> lst = new List<int>() { 1, 2, 6, 9, 8, 4, 1, 2, 66, 55, 77, 11, 52, 365, 145 };
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] % 2 != 0)
                {
                    lst.RemoveAt(i);
                }

            }

            foreach (int i in lst)
            {
                Console.WriteLine("after  removing the odd numbers :" + i + " ");
            }

            Console.WriteLine(lst.Contains(9));
            Console.WriteLine("\n\n");
        }

        public void sortedsetEx()
        {
            //it can't allows the hetrogeneous data and increase the array length at execution time . it's allows the duplicate values, but in output only give the single value 
            SortedSet<int> ss=new SortedSet<int>();
            ss.Add(1);
            ss.Add(2);
            ss.Add(3);
            ss.Add(1);// this value not repeat 
            ss.Add(5);
            foreach(int s in ss)
            {
                Console.WriteLine(s+" ");
            }
            int[] arr=new int[ss.Count];
            foreach(int s in ss)
            {
                ss.CopyTo(arr);
            }
            Console.WriteLine("after copying the sorted elements ");
           foreach(int s in arr)
            {
                Console.WriteLine(s + " ");
            }
            ss.Clear();
            Console.WriteLine("after applying the clear() method if 1 is contains :"+ ss.Contains(1));
        }

    }
}
