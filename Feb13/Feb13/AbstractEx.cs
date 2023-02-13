using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Feb13
{
    public abstract class AbstractEx
    {
       protected double l, b, r, h;
        public abstract void rectangle();
        public abstract void circle();
        public abstract void square();
        public abstract void triable();
    }
}
