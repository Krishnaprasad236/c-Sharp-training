using System.Xml.Serialization;
using System.Xml;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XmlReaderWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //private void button2_Click(object sender, EventArgs e)
        //{
        //    List<XmlRead> p1 = new List<XmlRead>();
        //    XmlSerializer serializer = new XmlSerializer(typeof(List<XmlRead>));
        //    p1.Add(new XmlRead() { Supply_Type = "Fixed", Peak_Current = "100% IOC", Voltage = "5000 mV", Max_Current = "3000 mA", Debounce = "20 msec", Threshold = "3900 mA" });
        //    p1.Add(new XmlRead() { Supply_Type = "Fixed", Peak_Current = "100% IOC", Voltage = "9000 mV", Max_Current = "3000 mA", Debounce = "20 msec", Threshold = "3900 mA" });
        //    p1.Add(new XmlRead() { Supply_Type = "Fixed", Peak_Current = "100% IOC", Voltage = "15000 mV", Max_Current = "3000 mA", Debounce = "20 msec", Threshold = "3900 mA" });
        //    p1.Add(new XmlRead() { Supply_Type = "Fixed", Peak_Current = "100% IOC", Voltage = "20000 mV", Max_Current = "5000 mA", Debounce = "20 msec", Threshold = "3900 mA" });
        //    p1.Add(new XmlRead() { Supply_Type = "Fixed", Peak_Current = "100% IOC", Voltage = "28000 mV", Max_Current = "5000 mA", Debounce = "20 msec", Threshold = "3900 mA" });

        //    using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\MCvoltage.xml", FileMode.Create, FileAccess.Write))
        //    {
        //        serializer.Serialize(fs, p1);
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            {
                List<XmlRead> p1 = new List<XmlRead>();
                XmlSerializer serializer = new XmlSerializer(typeof(List<XmlRead>));


                using (FileStream fs = new FileStream("D:\\KRISHNA\\MCvoltage.xml", FileMode.Open, FileAccess.Read))
                {

                    p1 = (List<XmlRead>)serializer.Deserialize(fs) ;
                }
                //dataGridView2.DataSource = p1;
                dataGridView1.DataSource= p1;
            }
            /* catch (Exception ex)
            {
                 ex.Source = "Error";
            }*/
        }
    }
}