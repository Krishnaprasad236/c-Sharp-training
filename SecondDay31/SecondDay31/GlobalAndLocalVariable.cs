using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDay31
{
     class GlobalAndLocalVariable
    {
        string empname="", emploction="";
        int empage, empsalary;

       public void global()
        {
            Console.WriteLine();
            Console.WriteLine("This is local and global variables ");
            Console.Write("Enetr employee name :");
            empname = Console.ReadLine();
            Console.Write("Enter employee age :");
            empage=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter employee location :");
            emploction = Console.ReadLine();
            Console.Write("Enter employee salary :");
            empsalary= Convert.ToInt32(Console.ReadLine());
        }

        public void local()
        {
            Console.WriteLine($"The employee details are: \n{empname} \n{empage} \n{emploction} \n{empsalary}");
        }

        public void globalLocal()
        {
            Console.WriteLine("\n");
            Console.Write("enter Employee basic salary :");
            double salary=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enetr empolyee HRA ");
            double hra=Convert.ToDouble(Console.ReadLine());
            
            if(salary<=15000)
            {
                Console.WriteLine("you dont have any pf amount");
            }
            else if(salary>15000)
            { 
                //basic pf percentage
                double pf = 0.0367;
                double pfamount = pf * salary;
                double totalsalary=pfamount+hra+salary;
                Console.WriteLine($"your pf amount is : \n {pfamount} \n total salary is : {totalsalary}");

            }
            //error :we con't access the local block variable form the outside
            // Console.WriteLine($"your pf amount is : \n {pfamount} \n total salary is : {totalsalary}");


            Console.WriteLine() ;
            Console.WriteLine($"your actual salary is : {salary} \n HRA is :{hra}");
        }

    }
}
