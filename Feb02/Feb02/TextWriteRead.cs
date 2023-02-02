using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb02
{
    internal class TextWriteRead
    {
        public void textExp()
        {
            //CreateText() it used to creat the text file the specified directory 
            using (TextWriter tw = File.CreateText("d://h.txt")) 
            {
                tw.Write("hello world ");
                tw.WriteLine("THIS IS GRL CONNECT TO THE WORDL");
            }
            Console.WriteLine("DATA CREATION SUCCESSFULLY....");
        }

        public void textReadExp()
        {
            using(TextReader tr=File.OpenText("d://h.txt"))
            {
                // ReadToEnd() it used to read the all data present in the text 
                Console.WriteLine(tr.ReadToEnd());
            }
            Console.Write("data collection successfully ..");
        }
    }
}
