using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb15
{
    internal class EventSubscriber
    {
        public void onNotify(string msg)
        {
            Console.WriteLine("Received notification "+msg);
        }
    }
}
