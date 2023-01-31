using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDay31
{
    internal class StringInterpolation
    {
        public static void inter()
        {
            Console.WriteLine("\n");
            Console.WriteLine("This is string interpolation");
            var date= DateTime.Now;
            Console.WriteLine("Enter student details : ");
            Console.Write("Enter name :");
            string name = Console.ReadLine();
            Console.Write("Enter age :");
            int age =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter student location :");
            string location = Console.ReadLine();
            Console.WriteLine($"The student deatils are\n name:{name}\n age: {age}\n location :{location}\n joining date {date.DayOfYear}");
        }
    }
}
