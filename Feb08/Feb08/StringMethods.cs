using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb08
{
    internal class StringMethods
    {
        string type = "c# ,string";
        string type1 = " join the two string";
        string s1 = "c# string";

        public void stringTest()
        {
            // Find the string lenght 
            Console.WriteLine(type);
            int lenght = type.Length;
            Console.WriteLine("length of the string is :" + lenght);

            //join the two strings
            string joins = string.Concat(type, type1);
            Console.WriteLine("joined strings are :" + joins);
        }

        public void comparTest(string s2, string s3)
        {
            //Compare the two strings by Equals() method
            bool compare = s2.Equals(s3);
            bool compare1 = type1.Equals(s1);

            Console.WriteLine("strings taken by the user :"+compare);
            Console.WriteLine(compare1);
        }

        public void stringMethodsEx()
        { 
            //Formate the strings
            Console.WriteLine("FORMATE METHOD");
            Program p = new Program();
            string d = "258.23";
            string formate = string.Format("the present time is: {0:t} and object value is: {1}", DateTime.Now, p);
            Console.WriteLine($"{formate}\n\n");

            Console.WriteLine("SPLIT Method :");
            string[] oper = { "# ,", "g" };
            int count = 2;
            string[] split = type.Split(oper, count, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in split)
            {
                Console.Write(s);
            }

            Console.WriteLine("\n\n");

            //Substring() method 
            Console.WriteLine("SUBSTRING METHOD :");
            string word = "Mahesh Chand is a founder of C# Corner";
            string subs = word.Substring(1, 12);
            Console.Write($"{subs}\n");

            //Compare() method 
            Console.WriteLine("Compare Method :");
            string a = new string("Granite river lab");
            string b = new string("Granite river lab");
            int compare = string.Compare(a, b);
            if (compare == 0)
            {
                Console.WriteLine("two strings are equal (0) :" + compare);
            }
            else if (compare == 1)
            {
                Console.WriteLine("string1 is greater than string2 (1) :" + compare);
            }
            else if (compare == -1)
            {
                Console.WriteLine("string1 is less than string (-1) :" + compare);
            }
            else
            {
                Console.WriteLine("value not found");
            }
            Console.WriteLine("\n\n");

            //Replace method
            Console.WriteLine("Replace Method :");
            string str1 = "GRL ";
            string str2 = "hello";
            string replace = str2.Replace('l', 'L');
            string replace1 = str1.Replace("GRL", "grl");
            Console.WriteLine($"original string is  {str2}  :"+replace);
            Console.WriteLine($"original string is  {str1}  :" + replace1);



        }

        public void formateAlignment()
        {
            string[] names = { "krishna", "prasad", "addanki", "mariyamma" };
            double[] salary = { 20000, 15000, 12000, 16000 };
            string[] location = { "guntur", "guntur", "guntur", "guntur" };
            int[] year = { 2023, 2023, 2023, 2023 };

            string emplist = string.Format("{0,-10} {1,-10} {2,-10} {3,15}\n", "Empname", "empsalary", "emplocation", "empyear");
            for (int i = 0; i < year.Length; i++)
            {
                emplist += string.Format("{0,-10} {1,-10} {2,-10} {3,15}\n", names[i], salary[i], location[i], year[i]);
                Console.WriteLine($"\n{emplist}");
            }
        }


    }
}
