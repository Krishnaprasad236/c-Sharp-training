using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Linq;

namespace Feb10
{
    internal class Diposite
    {
        int acc = 111;
        string name = "krishna";
        string pass = "Krishna@123";
        PropertiesEx propertiesEx = new PropertiesEx();
        public void atm()
        {

            Console.WriteLine("Enter account number :");
            int acc=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter user name :");
            string user=Console.ReadLine();
            Console.WriteLine("Enter Password  :");
            string pass=Console.ReadLine();
            PropertiesEx propertiesEx = new PropertiesEx();
            propertiesEx.AccountNo = acc;  
            propertiesEx.UserName = user;   
            propertiesEx.UserPassoward = pass;

            if (name == propertiesEx.UserName && pass == propertiesEx.UserPassoward)
            {
                Console.WriteLine("collect your money and thank you ");
            }
            else
            {
                Console.WriteLine("invalid input ! Please try agian ");
                throw new Exception(getMsg());
            }
        }
        public static string getMsg()
        {
            return "wrong input";
        }

    }
}
