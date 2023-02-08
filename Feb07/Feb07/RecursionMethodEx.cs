using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb07
{
    internal class RecursionMethodEx
    {



        public int divisionCount(double num)
        {
            int count = 0;
            if (num > 0 && num % 2 == 0)
            {
                count++;
                num /= 2;
                return count += divisionCount(num);
            }
            return count;
        }
        public int sumRecursion(int a, int b)
        {
            int sum = a;
            if (a < b)
            {
                a++;
                return sum += sumRecursion(a, b);
            }
            return sum;
        }
        public void inputRecursion()
        {
            Console.WriteLine("Enter a number :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b number :");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = sumRecursion(a, b);

            Console.WriteLine(sum);

            Console.WriteLine("Enter a number :");
            double num = Convert.ToDouble(Console.ReadLine());
            int count = divisionCount(num);

            Console.WriteLine(count);
        }






    }
}
