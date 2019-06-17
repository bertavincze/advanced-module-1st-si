using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person
    {
        int salary;
        string profession;
        Room room;

        public Employee(string name, DateTime birthdate, Gender gender, int salary, string profession, Room room) : base(name, birthdate, gender)
        {
            this.salary = salary;
            this.profession = profession;
            this.room = room;
        }

        public override string ToString()
        {
            return base.ToString() + "\nSalary: " + salary + "\nProfession: " + profession + "\nRoom: " + room.getNumber();
        }
    }
}
