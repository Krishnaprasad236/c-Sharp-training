using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb21
{
    internal class CollectionEx1
    {
        public void arrayListEx()
        {
            //it can allows the hetrogeneous data and increase the array length at execution time . it allows the duplicate values 
            ArrayList al = new ArrayList();
            al.Add(20);
            al.Add(30);
            al.Add(1.325);
            al.Add("krishna");
            al.Add(60);
            Console.WriteLine("index value " + al.IndexOf(60));
            Console.WriteLine("ArrayList Elements are :");
            foreach (var i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n\n");
        }
        public void queueEx()
        {
            //it can allows the hetrogeneous data and increase the array length at execution time . it's allows the duplicate values 
            // Enqueue() method used for adding the elements 
            //it execute the first-in-first-out mechanism 
            Console.WriteLine("Queue elements");
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue("connect to the world ");
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(3);
            q.Dequeue();//this method removes the first element of the queue 
            foreach (var qlist in q)
            {
                Console.WriteLine(qlist + " ");
            }
            Console.WriteLine(q.Contains(1));
        }
        public void sortedListEx()
        {
            //it can allows the hetrogeneous data and increase the array length at execution time . it's not allows the duplicate values 
            Console.WriteLine("sortedlist elements ");
            SortedList sList = new SortedList();
            Console.WriteLine("sortedList Elements :");
            sList.Add(522017, "Lalupuram");
            sList.Add(522001, "chuttuguntta");
            sList.Add(522002, "Brodipet");
            sList.Add(522019, "Prathipadu");
            /* sList.Add(522001, "chuttuguntta");this data not added */

            ICollection key = sList.Keys;

            foreach (var i in key)
            {
                Console.WriteLine("Area pincode :" + i + " " + "Area name  :" + sList[i]);
            }
            Console.WriteLine();
        }


        public void stackEx()
        {
            //it can allows the hetrogeneous data and increase the array length at execution time . it allows the duplicate values 
            //it execute the last-in-first-out mechanism 
            Console.WriteLine("Stack elements :");
            Stack stack= new Stack();
            stack.Push(1);//this method add the elements in last of the stack
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(1);
            stack.Push("string value");
            stack.Pop();//this method remove the firts elements of the stack
           /* Output:
            Stack elements :
                4
                3
                2
                1*/

            foreach (var s in stack)
            {
                Console.WriteLine(s+" ");
            }
        }

        public void hashTableEx()
        {
            Console.WriteLine("HashTable Elemants :");

            //it can allows the hetrogeneous data and increase the array length at execution time . it's not allows the duplicate values 
            //it compare the hash code of the object based on that generate the output 
            Hashtable ht = new Hashtable();
            ht.Add(1,"student id one");
            ht.Add(2, "student id two");
            ht.Add(3, "student id three");
            ht.Add(4, "student id four ");
            ht.Add(5, "student id five");
            ht.Add(0.1, "student id six");
            ICollection key = ht.Keys;

            foreach (var hash in key)
            {
                Console.WriteLine(hash+" " + ht[hash]);
            }
        }
    }
}
