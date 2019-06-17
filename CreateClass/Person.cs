using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public enum Gender { Male, Female };

    class Person
    {
        string name;
        DateTime birthdate;
        Gender gender;

        public Person(string name, DateTime birthdate, Gender gender)
        {
            this.name = name;
            this.birthdate = birthdate;
            this.gender = gender;
        }

        public override string ToString()
        {
            return "Name: " + this.name + "\nBirthdate: " + this.birthdate + "\nGender: " + this.gender;
        }
    }
}
