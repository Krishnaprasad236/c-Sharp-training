using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb07
{
    internal class AnonymouseEx
    {
        delegate double Sum(double num, double num1);
        delegate double Sub(double a, double b);
        delegate double Mul(double x, double y);
        delegate double Div(double num2, double num3);

        public int RollNo
        {
            get; set;
        }
        public string? Name
        {
            get; set;
        }

        public void lambdaExm()
        {
            Console.WriteLine("enter two numbers :");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            //sum
            Sum getSum = (x, x1) => a + b;
            double j = getSum(a, b);
            Console.WriteLine("Addition of two numbers " + j);
            //sub
            Sub getSub = (x, x1) => x - x1;
            double j1 = getSub(a, b);
            Console.WriteLine("Substraction of two numbers " + j1);
            //mul
            Mul getMul = (x, x1) => x * x1;
            double j2 = getMul(a, b);
            Console.WriteLine("multiplocation of two numbers " + j2);
            //div
            Div getDiv = (x, x1) => x / x1;
            double j3 = getDiv(a, b);
            Console.WriteLine("division of two numbers " + j3);
        }

        public void LambdaEx2()
        {
            List<double> a = new List<double>() { 23, 65, 45, 98, 555, 123565, 987, 100, 23654 };
            Console.WriteLine("the list is ");
            foreach (var x in a)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            //lambda expression for finding square 
            var squer = a.Select(x => x * x);
            Console.WriteLine("The squere of the numbers :");
            foreach (var x in squer)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            //lambda expression for finding divisible by 3 
            var div = a.FindAll(x => (x % 3) == 0);
            Console.WriteLine("divisible by 3");
            foreach (var x in div)
            {
                Console.Write(x + " ,");
            }
            Console.WriteLine();
        }

        public void lamdbdaEx3()
        {
            List<AnonymouseEx> studentList = new List<AnonymouseEx>()
            {
                new AnonymouseEx{RollNo=1,Name="prudhvi" },
                new AnonymouseEx{RollNo=2,Name="yohan" },
                new AnonymouseEx{RollNo=3,Name="kishor"},
                new AnonymouseEx{RollNo=4,Name="krishna"}
            };

            var sortDetails = studentList.OrderBy(x => x.Name);
            Console.WriteLine("order list based on names :");
            foreach (var student in sortDetails)
            {
                Console.WriteLine(student.RollNo + " " + student.Name);
            }
        }
    }
}
