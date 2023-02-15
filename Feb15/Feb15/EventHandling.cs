using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb15
{
    public delegate void EventHandler(string msg);
    internal class EventHandling
    {
        public event EventHandler notify;
        public void doSomthing()
        {
            Console.WriteLine("work is going in ");
            notify?.Invoke("done somthing");
        }
    }
}
