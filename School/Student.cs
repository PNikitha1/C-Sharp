using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Student : Person
    {
        char Grade;
        string Class;
        double Fees;

        public Student() { }
        public Student(int id, string name, string address, string phone, char grade, string sclass, double fees)
            : base(id, name, address, phone)
        {
            Grade = grade;
            Class = sclass;
            Fees = fees;
        }

        public void DisplayStudent()
        {
            Display();
            Console.WriteLine($"Grade: {Grade}, Class: {Class}, Fees: {Fees}");
        }
        // Method hiding/shadowing
        public new void Test()
        {
            Console.WriteLine("Test method in Student class");
        }

        public override void Show()
        {
            Console.WriteLine("Show method in Student class");
        }

        public char StudentGrade
        {
            get => Grade; set => Grade = value;
        }

        public object this[string propertyName]
        {
            get
            {
                return propertyName.ToLower() switch
                {
                    "id" => _Id,
                    "name" => Name,
                    "address" => Address,
                    "phone" => Phone,
                    "grade" => Grade,
                    "class" => Class,
                    "fees" => Fees,
                    _ => throw new ArgumentException("Invalid property name")
                };
            }
            set
            {
                switch (propertyName.ToLower())
                {
                    case "id":
                        _Id = (int)value;
                        break;
                    case "name":
                        Name = (string)value;
                        break;
                    case "address":
                        Address = (string)value;
                        break;
                    case "phone":
                        Phone = (string)value;
                        break;
                    case "grade":
                        Grade = (char)value;
                        break;
                    case "class":
                        Class = (string)value;
                        break;
                    case "fees":
                        Fees = (double)value;
                        break;
                    default:
                        throw new ArgumentException("Invalid property name");
                }
            }
        }
    }
}
