using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practies
{
    internal class ShowResult
    {
        public void display(List<Dataset> d)
        {
            foreach (var dataset in d)
            {
                Console.WriteLine($"Distance ={dataset.distance} KM\nTime= {dataset.time} HOURS\nspeed= {dataset.speed} KM/HR");
                Console.WriteLine();
            }
        }
    }
}
