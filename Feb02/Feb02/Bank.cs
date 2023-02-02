using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb02
{
    internal class Bank
    {
        public void intiat()
        {
            //custom exception handling and terminate the exception by using nested " try,catch" blocks
            Atm a= new Atm();
            try
            {
                a.acceptInput();
                a.verify();

            }
            catch(Exception e)
            {
                try
                {
                    a.acceptInput();
                    a.verify();
                }
                catch(Exception e1)
                {
                    try
                    {
                        a.acceptInput();
                        a.verify();
                    }
                    catch(Exception e2)
                    {
                        Console.WriteLine("your Atm card is blocked ");
                    }
                    finally
                    {
                        Console.WriteLine("your card resume from tomorrow");
                    }
                }

            }

        }
    }
}
