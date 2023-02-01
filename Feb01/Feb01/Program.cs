using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Feb01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter book name :");
            string name = Console.ReadLine();
            Console.WriteLine("enter author name :");
            string aname = Console.ReadLine();
            Console.WriteLine("Enter book title :");
            string tname = Console.ReadLine();
            Console.WriteLine("Enter book cost :");
            int bprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter salling price :");
            int sprice = Convert.ToInt32(Console.ReadLine());

            StaticAttributes s = new StaticAttributes(name, aname, tname, bprice, sprice);
            s.profit();

            //error :we can't call the static attribute by using object reference or by the methode name as shown below  
            //Console.Write("book count :" + s.saleCount);

            //calling static attribut by using class name 
            Console.WriteLine("book count :"+StaticAttributes.saleCount);


            //setter and getter  user for accessing the private date present in another class

            SetterAndGetter bahubali = new SetterAndGetter("bahubali", "rajamouli", "good");
            SetterAndGetter rowdy = new SetterAndGetter("rowdy", "puri", "bad");

            //rowdy.rating = "wrong";-->with out using the setter and getter it gives not accessable error

            Console.WriteLine(rowdy.Rating);//--> using the setter and getter for accessing the privete data
            Console.WriteLine(bahubali.Rating);


            //multithreading using static methods 
            
            Thread t1 = new Thread(new ThreadStart(Threading.threadeExm));
            Thread t2 = new Thread(new ThreadStart(Threading.myThread));
            Thread t3=new Thread(new ThreadStart(Threading.myThread));
            t1.Start();
            t2.Start();
            Thread.Sleep(3000);
            t3.Start();

            //For non-static method we have to create the object for the class and call by the refernce

            Threading nonstatic= new Threading();
            Thread nonstaticmethod = new Thread(new ThreadStart(nonstatic.nonStatic));
            nonstaticmethod.Start();







        }
    }
}
