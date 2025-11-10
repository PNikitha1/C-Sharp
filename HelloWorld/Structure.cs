using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    struct Structure
    {
        int i;
        public Structure(int i)
        {
            this.i = i;
        }

        public void Display()
        {
            Console.WriteLine("Value of i: " + i);
        }

        static void Main()
        {
            Console.BackgroundColor= ConsoleColor.Green;
            Structure s = new Structure(10);
            s.Display();

            Structure s1;
            s1.i = 239;
            s1.Display();

            Structure s2 = new Structure();
            s2.Display();
        }
    }
}
