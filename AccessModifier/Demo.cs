using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    internal class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            HelloWorld.AccessModifiers obj = new HelloWorld.AccessModifiers();
            obj.Test1();
        }
    }
}
