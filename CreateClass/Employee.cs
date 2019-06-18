using System;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        public Room Room { get; internal set; }
        public int Salary { get; set; }
        public string Profession { get; set; }

        public Employee(string Name, DateTime Birthdate, Gender Gender, int Salary, string Profession) : base(Name, Birthdate, Gender)
        {
            this.Salary = Salary;
            this.Profession = Profession;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee) MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }

        public override string ToString()
        {
            return base.ToString() + "\nSalary: " + Salary + "\nProfession: " + Profession + "\nRoom: " + Room.Number;
        }

    }
}
