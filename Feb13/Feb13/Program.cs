using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb13
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            //Encapsulation is technique to protect the seccitive data from outer user by using "private" keyword.
            Console.WriteLine("encapsulation  :");
            EncapsulationEx en = new EncapsulationEx();
            Console.WriteLine(en.UserName + " " + en.Password);
            en.verify();
            Console.WriteLine("\n\n");
            //Inheritance is a a process of aquaring the fields and methods form parent calss (base class) to child call(drived class)
            //Here,we created on object of the child class and access the methods from parent class and child class by creating only one class object 
            Console.WriteLine("Inheritance :");
            InheritanceEx1 inheritance = new InheritanceEx1();
            inheritance.baseClass();
            inheritance.display();
            Console.WriteLine("\n\n");
            //Polymorphism means "Many forms" which means we can use the one method declared in perent classs that method reuse in chiled class also .
            Console.WriteLine("Polymorphism :");
            PolymorphismEx pol =new PolymorphismEx();
            PolymorphismEx pol1=new PolymorphismEx1();
            pol.bird();
            pol1.bird();
            Console.WriteLine("\n\n");
            //Abstract is the hide the data from outer user by using the "abstract" key word .It has non-impemented methods and
            //we can't create the object for this class
            Console.WriteLine("Abstraction");
            AbstractEx1 ab = new AbstractEx1();
            ab.rectangle();
            ab.circle();
            ab.square();
            ab.triable();


        }
    }
}
