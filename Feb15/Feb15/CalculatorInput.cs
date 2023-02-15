using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Feb15
{
    public delegate void Calculatior(double a,double b);
    internal class CalculatorInput
    {
        public event Calculatior OnNotification;
        public void eventNotification()
        {
            Console.WriteLine("Eneter two numbers  :");
            double first=Convert.ToDouble(Console.ReadLine());
            double second=Convert.ToDouble(Console.ReadLine());
            //Invoke() method used to call the method which is present in the other class by using the delegate with same return type and signature 
            OnNotification.Invoke(first,second);
        }
    }
}
