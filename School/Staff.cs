using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Staff : Person
    {
        double Salary;
        string Designation;

        public Staff() { }
        public Staff(int id,string name,string address,string phone,double salary,string designation) : base(id, name, address, phone)
        {
            Salary = salary;
            Designation = designation;
        }

        public void DisplayStaff()
        {
            Display();
            Console.WriteLine($"Salary: {Salary}, Designation: {Designation}");
        }
    }
}
