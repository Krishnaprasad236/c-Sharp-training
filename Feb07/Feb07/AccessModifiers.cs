using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb07
{
    internal class AccessModifiers
    {
        public string public1 ="public modifier";
        protected string protected1 = "protected modifier";
        private string private1 ="private modifier";
        internal string internal1 = "internal modifier ";

        public string protectedEx()
        {
            return protected1;
        }

        public string privateEx()
        {
            return private1;
        }
    }
}
