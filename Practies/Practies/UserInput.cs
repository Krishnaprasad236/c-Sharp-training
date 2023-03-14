using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practies
{
    internal class UserInput
    {
        public void input()
        {
            var data = new List<Dataset>();
            Console.WriteLine("enter the how many value wants to calculate :");
            int count = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < count; i++)
            {
                Console.Write("enter Distance in KM : ");
                double d = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Time in HOURS :");
                double t = Convert.ToDouble(Console.ReadLine());

                //adding the list of the data.
                data.Add(new Dataset { distance = d, time = t });
            }

            Measure m = new Measure();
            //passing the list data to speedCalculate() method for calculating the speed  
            m.speedCalculate(data);

            //using the StreamWriter class for the writing the data into a file and generate the file with the file name and path 
            using (var writer = new StreamWriter("D://DOCUMENT//SpeedData_" + DateTime.Now.ToString("dd_MM_yyyy_HH-mm-ss") + ".csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(data);
            }
        }
    }   
}
