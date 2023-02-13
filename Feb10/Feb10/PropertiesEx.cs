using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb10
{
    internal class PropertiesEx
    {
       
        private int accountNo;
        private string userName = "";
        private string userPassword = "";

        public int AccountNo
        { 
            get { return accountNo; }
            set { accountNo = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string UserPassoward
        {
            get { return userPassword; }
            set { userPassword = value; }
        }

        public void collect()
        {
           
            Diposite diposite= new Diposite();
            try
            {
                diposite.atm();
            }
            catch(Exception e)
            { 
                 try
                {
                    diposite.atm();
                }
                catch(Exception ex) 
                {
                    try
                    {
                        diposite.atm();
                    }
                    catch(Exception e2)
                    {
                        Console.WriteLine("your card is block");
                        Console.WriteLine("your card resume from tomorrow ");
                    }
                }
            }

        }

    }
}
