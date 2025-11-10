using System;

namespace School
{
    public class Person
    {
        protected int _Id;
        protected string Name, Address, Phone;

        public Person() { }

        public Person(int id, string name, string address, string phone)
        {
            _Id = id;
            Name = name;
            Address = address;
            Phone = phone;

        }

        public void Display()
        {
            Console.WriteLine($"ID: {_Id}, Name: {Name}, Address: {Address}, Phone: {Phone}, Country:{Country}");
        }

        public void Test()
        {
            Console.WriteLine("Test method in Person class");
        }

        public virtual void Show()
        {
            Console.WriteLine("Show method in Person class");
        }

        public int Id
        {
            get => _Id; set => _Id = value;
        }

        public string Country
        {
            get; set;
        } = "India";
        public object this[int index]
        {
            get
            {
                if (index == 0) return _Id;
                else if (index == 1) return Name;
                else if (index == 2) return Address;
                else if (index == 3) return Phone;
                else throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (index == 0) _Id = (int)value;
                else if (index == 1) Name = (string)value;
                else if (index == 2) Address = (string)value;
                else if (index == 3) Phone = (string)value;
                else throw new IndexOutOfRangeException("Invalid index");
            }
        }
    }
}