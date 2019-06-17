using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        private int Salary;
        private string Profession;

        public Employee(string Name, DateTime Birthdate, Gender Gender, int Salary, string Profession) : base(Name, Birthdate, Gender)
        {
            this.Salary = Salary;
            this.Profession = Profession;
        }

        public Room Room { get; internal set; }

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
