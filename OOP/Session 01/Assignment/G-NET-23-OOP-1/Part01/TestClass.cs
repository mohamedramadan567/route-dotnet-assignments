using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_OOP_1.Part01
{
    internal class TestClass
    {
        public int prop01 { get; set; }

        public void PrintPublicMessage()
        {
            Console.WriteLine("I'm a public you can access me from any place you want :-)");
        }

        private void PrintPrivateMessage()
        {
            Console.WriteLine("I'm private you can't access me from outside the class :-(");
        }
    }
}
