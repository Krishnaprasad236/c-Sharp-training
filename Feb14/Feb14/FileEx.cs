using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb14
{
    internal class FileEx
    {
        private object stram;

        public void createFile()
        {
            string write = "interfaces are used to achive the multiple inheritance ";
            File.WriteAllText("D://filename.txt", write);
            string read =  File.ReadAllText("D://filename.txt");
            Console.WriteLine(read);
            bool exist=File.Exists("D://filename.txt");
            Console.WriteLine(exist);
        }
    }
}
