using System;

namespace AccessModifier
{
    internal class Program : HelloWorld.AccessModifiers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program p = new Program();
            p.Test1();
            p.Test5();
            p.Test3();
            
        }
    }
}