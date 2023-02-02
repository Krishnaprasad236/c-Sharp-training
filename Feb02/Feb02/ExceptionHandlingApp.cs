using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb02
{
    internal class ExceptionHandlingApp
    {
        public static void Main(string[] args)
        {
            // Exception handling by using try catch block
             Demo2 d2 = new Demo2();
            d2.bank();

            //Custome exception handling 
            Bank b= new Bank();
            b.intiat();

            //checked and unchecked keywords
            CheckedAndUnchecked cu=new CheckedAndUnchecked();
            cu.check();//-->"checked" keyword can check intergral type of exception is occure or not and exccute with exception
            cu.uncheck();//-->"unchecked" keyword can't check integral type of exception and gives the output

            FileStreamEx1 fl= new FileStreamEx1();
            fl.file();

            // FILES I/O CLASSES 
            // --> StreamWrite is a class used to write stream of the objects 
            StreamWriteEx se = new StreamWriteEx();
            se.write();
            se.streamReadex();

            //-->Textwrite and read classes used to write the text in a file 
           TextWriteRead textWrite= new TextWriteRead();
            textWrite.textExp();
           textWrite.textReadExp();

            //THREADING AND MULTI THEADING 
            //-->Threading is line of excution present in the memory .Here default Thread is present i.e main stack it is hold the main method

            ThreadingAndMultiThreading th=new ThreadingAndMultiThreading();
            th.threadEx1();
            Thread t1 = new Thread(new ThreadStart(ThreadingAndMultiThreading.threadEx2));
            Thread t2 = new Thread(new ThreadStart(ThreadingAndMultiThreading.threadEx2));
            t1.Start();
            Thread.Sleep(5000);
            t2.Start();

        }
    }
}
