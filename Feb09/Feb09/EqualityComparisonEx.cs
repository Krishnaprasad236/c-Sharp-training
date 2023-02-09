using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb09
{
    internal class EqualityComparisonEx
    {
        public int age { get; set; }
        public string name { get; set; }

        public void referenceEqual()
        {
            EqualityComparisonEx a = new EqualityComparisonEx() { age = 23, name = "krishna" };
            EqualityComparisonEx b = new EqualityComparisonEx() { age = 22, name = "prasad" };

            bool compareMothod = a.Equals(b);
            Console.WriteLine("string "+compareMothod);

            bool referValue=System.Object.ReferenceEquals(a, b);
            Console.WriteLine("referecne are equal ?:"+referValue);
            Console.Write("\n");
            b = a;
            referValue=System.Object.ReferenceEquals (a,b);

            Console.WriteLine("after assign value :" + referValue);
               compareMothod = a.Equals(b);
            Console.WriteLine("EqualReference by using string menthod   " + compareMothod);
            Console.Write("\n\n");

            string name1 = "grl";
            string name2 = "grl";

            bool valueEqual=name1.Equals(name2);
            Console.WriteLine("valueEqual " + valueEqual);




        }
    }
}
