using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //sample type are interger ,chgaracter and bool data member it can store the interdata,UTF-16 FORMATE values,true or fals 
            Console.WriteLine("Types and variables in c#");
            Console.WriteLine("sample tyeps,enum type,struct type ,nullable type");
            Console.WriteLine("SAMPLE TYPES (byte):");
            SampleTypeEx.sizeFind();
            SampleTypeEx.intEx();


            //enums are interger tyoe of enumeration by using the "enum" keyword for specifying the enum members 
            Console.WriteLine("ENUM:");
            EnumTypeEx et=new EnumTypeEx();
            et.dayMeeting();

        }
    }
}
