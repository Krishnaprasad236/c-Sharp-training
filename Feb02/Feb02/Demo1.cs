using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb02
{
    internal class Demo1 
    {
        public void atm()
        {
           try
            {
                Console.WriteLine("Eneter two numbers :");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(a / b);
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Issue occured in bank atm & Resolve it");
            }
            finally
            {
                Console.WriteLine("connection bank server terminated ");
            }
        }
        
    }
}
