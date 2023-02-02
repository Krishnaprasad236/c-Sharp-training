using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Feb02
{
    internal class FileStreamEx1
    {
        public void file()
        {
            FileStream f = new FileStream("D://Data//GRL-C-SHRAP//Feb01//Feb01/Program.cs", FileMode.OpenOrCreate);
            int i = 0;

            while((i=f.ReadByte())!=-1)
            {
                Console.Write((char)i);
            }
            Console.WriteLine();
            f.Close();
        }
    }
}
