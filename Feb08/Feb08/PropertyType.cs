using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb08
{
    internal class PropertyType
    {
        public string hideMethod { get => "krishna"; }

        private string location;

        public PropertyType(string locationname)
        {
            this.location = locationname;
        }
        public string locationName
        {
            get => location;
            set => location = value;
        }
    }
}
