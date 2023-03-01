using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Feb21.GenericClassEx;
using static System.Net.Mime.MediaTypeNames;

namespace Feb21
{
    internal class GenericClassEx1
    {
        public class Contetnt<T>
        {
            string sender;
            public T message;
            public Contetnt(string sender, T message)
            {
                this.sender = sender;
                this.message = message;
            }

            public string getSender()
            {
                return sender;
            }
            public T getValue()
            {
                return message;
            }
        }


        public void genericInput()
        {
            Contetnt<string > input = new Contetnt<string>("krishna","hello");
            Contetnt<string> input1 = new Contetnt<string>("krishna","C:/Users/GRL/Downloads/test.png");
            Console.WriteLine(input1.getSender()+ input1.getValue());
        }
    }
}