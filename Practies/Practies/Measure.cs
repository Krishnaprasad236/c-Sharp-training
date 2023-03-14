using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Practies
{
    internal class Measure//this class used to find the speed , the data received by the UserInput class
    {
        public void speedCalculate(List<Dataset> data)
        {
            foreach (var dataset in data)
            {
                dataset.speed=dataset.distance/dataset.time;
            }

            //passing the stored data to ShowResult class for display the data for verifying if the data correct or not 
            ShowResult s = new ShowResult();
            s.display(data);
        }
    }
}
