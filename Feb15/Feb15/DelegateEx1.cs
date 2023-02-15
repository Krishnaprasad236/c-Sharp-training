using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb15
{
    public delegate void MyDelegate(string name);
    internal class DelegateEx1
    {
        public void getName(string name)
        {
            Console.WriteLine("my name is    :" + name);
        }
        public void getLocation(string location)
        {
            Console.WriteLine("My loction is :" + location);
        }
    }
}
