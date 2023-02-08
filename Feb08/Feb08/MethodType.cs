using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb08
{
    internal class MethodType
    {
        public string name { get; set; }

        public void showMethod() => Console.WriteLine("mathod type :" + name);//Mehtod type 


        string firstname;
        string lastname;
        public MethodType()
        {

        }

        //method type with strong methods  
        public MethodType(string firstName, string lastName)
        {
            this.firstname = firstName;
            this.lastname = lastName;
        }

        public string DisplayName() => $"{firstname} {lastname}".ToUpper();
    }
}
