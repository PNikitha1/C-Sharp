using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    interface IInterface1
    {
        void Show();
        void Test();
    }
    interface IInterface2
    {
        void Show();
        void Test();
    }
    internal class InterfaceClass : IInterface1,IInterface2
    {
        public void Show()
        {
            Console.WriteLine("Show method");
        }

        void IInterface1.Test()
        {
            Console.WriteLine("Test method from IInterface1");
        }

        void IInterface2.Test()
        {
            Console.WriteLine("Test method from IInterface2");
        }
        static void Main()
        {
            InterfaceClass obj = new InterfaceClass();
            obj.Show();
            ((IInterface1)obj).Test();
            ((IInterface2)obj).Test();
            IInterface1 i1 = obj;
            IInterface2 i2 = obj;
            i1.Test();
            i2.Test();
        }
    }
}
