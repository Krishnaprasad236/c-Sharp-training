using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb02
{
    internal class Atm
    {
        int accno = 111;
        string accpsw = "Akp@123";
        int uaccno;
        string uaccpsw = "";
        
        public void acceptInput()
        {
            Console.WriteLine();
            Console.WriteLine("Enter your acount number and account password :");
            uaccno=Convert.ToInt32(Console.ReadLine());
            uaccpsw = Console.ReadLine();
        }
        
        public void verify()
        {
            if(accno==uaccno && accpsw==uaccpsw)
            {
                Console.WriteLine("Take your money ");
            }
            else
            {
                InvalidInput i=new InvalidInput();
                Console.WriteLine(i.getMassege());
                //throwing the invlaid input data exception by using "throw" keyword
                throw new Exception(i.getMassege());
            }
        }
    }
}
