using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_AdV01
{
    //Question11
    public class Person
    {
        public string Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }

    public class Student : Person
    {
    }

    public class Printer<T> where T : Person
    {
        public void Print(T person)
        {
            person.PrintName();
        }
    }
}
