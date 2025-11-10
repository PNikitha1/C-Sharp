using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Teaching : Staff
    {
        string Subject;
        string Qualification;

        public Teaching() { }
        public Teaching(int id,string name,string address, string phone,double salary,string designation,string sub,string qual):base(id,name, address, phone, salary, designation)
        {
            Subject = sub;
            Qualification = qual;
        }

        public void DisplayTeaching()
        {
            DisplayStaff();
            Console.WriteLine($"Subject: {Subject}, Qualification: {Qualification}");
        }
    }
}
