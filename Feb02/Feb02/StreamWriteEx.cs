using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Feb02
{
    internal class StreamWriteEx
    {
        public void write()
        {
            FileStream f = new FileStream("d:///l.txt", FileMode.Create);
            //StreamWriter is a class ,it is used to wirte the data in crated file .
            StreamWriter s =new StreamWriter(f);
            s.Write("Granite river labs:" +
                "using System;  \r\nusing System.IO;  \r\npublic class StreamWriterExample  \r\n{  \r\n    public static void Main(string[] args)  \r\n    {  \r\n        FileStream f = new FileStream(\"e:\\\\output.txt\", FileMode.Create);  \r\n        StreamWriter s = new StreamWriter(f);  \r\n  \r\n        s.WriteLine(\"hello c#\");  \r\n        s.Close();  \r\n        f.Close();  \r\n     Console.WriteLine(\"File created successfully...\");  \r\n    }  \r\n}  ");
            s.Close();
            f.Close();
            Console.WriteLine("files created successfully");
        }

        public void streamReadex()
        {
            // FileStream used to create or open the file exist in our system .
            FileStream f = new FileStream("d://file.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);//reading the data present in the file tream object.
            string line1 = "";
            while((line1= s.ReadLine()) != null)
            {
                Console.WriteLine(line1);
            }
            s.Close() ;
            f.Close() ;
        }
    }
}
