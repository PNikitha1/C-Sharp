using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal enum Enumerations
    {
        Monday,Tuesday,Wednesday=12,Thursday,Friday=42
    }

    class EnumDemo
    {
        static void Main()
        {
            Enumerations e= Enumerations.Monday;
            Console.WriteLine(e);
            Console.WriteLine((int)e);
            e = (Enumerations)1;
            Console.WriteLine(e);

            foreach (var day in Enum.GetValues(typeof(Enumerations)))
            {
                Console.WriteLine(day + " = " + (int)day);
            }

            foreach (var day in Enum.GetNames(typeof(Enumerations)))
            {
                Console.WriteLine(day);
            }
        }
    }
}
