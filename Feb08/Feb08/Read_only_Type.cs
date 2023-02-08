using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb08
{
    internal class Read_only_Type
    {

        //Read-only Property
        double a;
        double b;
        public Read_only_Type(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Sum() => a + b;
        public double Sub() => a - b;
        public double Mul() => a * b;
        public double Div() => a / b;
    }
}
