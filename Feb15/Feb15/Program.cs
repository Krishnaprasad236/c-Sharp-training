using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Feb15.DelegatesEx;

namespace Feb15
{
    internal class Program
    {
         
        public static void Main(string[] args)
        {
           
            int age;
            Console.WriteLine("Delegates in C# :");
            //Delegates are refere to method . This are used for pass the method as parameter .
            //For creating the delegate use the "delegate" keyword .
            DelegatesEx del = new DelegatesEx();
            Student deleEx = new Student(del.student1);
            Console.WriteLine("Enter student ID ,NAME AND AGE ");
            int id = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            deleEx(id, name, age);
            Console.WriteLine("\n\n");

            Console.WriteLine("Enter employee id, name and age ,experience :");
            int id1 = Convert.ToInt32(Console.ReadLine());
            string name1 = Console.ReadLine();
            int salary = Convert.ToInt32(Console.ReadLine());
            double ex = Convert.ToDouble(Console.ReadLine());
            Employee delEmp = new Employee(employeeDetials);
            delEmp(id1, name1, salary, ex);
            Console.WriteLine("\n\n");

            DelegateEx1 delmy = new DelegateEx1();
            MyDelegate delTest = new MyDelegate(delmy.getName);
            delTest("krishna");
            MyDelegate delTest2 = new MyDelegate(delmy.getLocation);
            delTest2("guntur");
            Console.WriteLine("\n\n");

            //mutlicasting is the process of passing the two methods at a time and give the output .
            Console.WriteLine("multicast delegate ");
            MyDelegate delMulti = new MyDelegate(delmy.getName);
            delMulti += delmy.getLocation;
            delMulti("this is multicasting");
            Console.WriteLine("\n\n");

            EventHandling eh = new EventHandling();
            EventSubscriber es = new EventSubscriber();
            eh.notify += es.onNotify;
            eh.doSomthing();
            Console.WriteLine("\n\n");

            CalculatorInput sb= new CalculatorInput();
            CalculatorOutput rc= new CalculatorOutput();
            sb.OnNotification += rc.notficationR;
            sb.eventNotification();
        }
    }
}
