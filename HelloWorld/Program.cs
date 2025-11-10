using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            int n = 34;
            Console.WriteLine($"The number is {n}");
            Console.WriteLine("The number is {0}", n);
            Console.Write("The username is: ");
            int username = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{username}");

            AccessModifiers obj = new AccessModifiers();
            obj.Test1();
            obj.Test5();
            obj.Test4();

        }
    }
}
