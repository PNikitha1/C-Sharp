using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class NonTeaching: Staff
    {
        string Dname;
        int MgrId;
        public NonTeaching() { }

        public NonTeaching(int id, string name, string address, string phone, double salary, string designation, string dname, int mgrid) : base(id, name, address, phone, salary, designation)
        {
            Dname = dname;
            MgrId = mgrid;
        }

        public void DisplayNonTeaching()
        {
            DisplayStaff();
            Console.WriteLine("Department Name:" + Dname + ", Manager ID:" + MgrId);
        }
    }
}
