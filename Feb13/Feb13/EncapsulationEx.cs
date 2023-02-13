using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb13
{
    internal class EncapsulationEx
    {
        private string userName = "krishna";
        private string password = "Krishna@123";

        public string UserName
        {
            get { return userName; }    
            set { userName = value; }   
        }

        public string Password
        {
            get { return password; }    
            set { password = value; }   
        }

        public void verify()
        {
            if(userName=="krishna" && password=="Krishna@123")
            {
                Console.WriteLine("your password is varified ");
            }
        }

    }
}
