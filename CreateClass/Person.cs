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
        private string Name;
        private DateTime Birthdate;
        private Gender Gender;

        public Person(string Name, DateTime Birthdate, Gender Gender)
        {
            this.Name = Name;
            this.Birthdate = Birthdate;
            this.Gender = Gender;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nBirthdate: " + Birthdate + "\nGender: " + Gender;
        }
    }
}
