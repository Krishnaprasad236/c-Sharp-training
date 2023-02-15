using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Feb15
{
    public delegate void Student(int id, string name, int age);
    public delegate void Employee(int id, string name, int salary, double experiance);
    internal class DelegatesEx
    {
        public void student1(int id, string name, int age)
        {
            Console.WriteLine("student ID  id  :"+id);
            Console.WriteLine("student NAME is :"+ name);
            Console.WriteLine("student AGE is  :"+age);
        }
        public static void employeeDetials(int id,string name,int salary,double experiance)
        {
            if(experiance >=3)
            {
                Console.WriteLine("Employee ID is     :" + id);
                Console.WriteLine("Employee NAME is   :" + name);
                Console.WriteLine("Employee salary is :" + salary);
                Console.WriteLine("salay increamented 5% ");
            }
            else
            {
                Console.WriteLine("not eligible ");
            }
        }


    }
}
