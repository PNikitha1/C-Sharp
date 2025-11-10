using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class AccessModifiers
    {
        public void Test1()
        {
            Console.WriteLine("Public Access Modifier");
        }

        private void Test2()
        {
            Console.WriteLine("Private Access Modifier");
        }
        protected void Test3()
        {
            Console.WriteLine("Protected Access Modifier");
        }   
        internal void Test4()
        {
            Console.WriteLine("Internal Access Modifier");
        }
        protected internal void Test5()
        {
            Console.WriteLine("Protected Internal Access Modifier");
        }

        static void Main()
        {
            AccessModifiers obj = new AccessModifiers();
            obj.Test1();
            obj.Test2();        
            obj.Test3();
            obj.Test4();
            obj.Test5();
        }
    }
}
