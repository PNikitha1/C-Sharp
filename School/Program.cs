using NPoco.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "hi", "Fdsfs", "42523", 'A', "A1", 53542);
            Console.WriteLine($"id: {s["id"]}");
            Console.WriteLine($"name: {s["name"]}");
            s["grade"] = 'B';
            s["class"] = "B1";
            Console.WriteLine(s.Id);
            s.DisplayStudent();
            s.Test();
            s.Show();
            Person p = new Student(3, "hey", "dfgdfg", "5345345",'E',"E3",41341);
            Console.WriteLine("Id "+ p[0]);
            Console.WriteLine("Name "+ p[1]);
            Console.WriteLine("Address "+ p[2]);
            Console.WriteLine("Phone "+ p[3]);
            p[0] = 342; p[1] = "new name";
            p.Test();
            p.Show();
            Teaching t = new Teaching(2, "hello", "dfgdfg", "5345345", 45345, "teacher", "maths", "MSc");
            t.Country = "USA";
            t.DisplayTeaching();
            
        }
    }
}
