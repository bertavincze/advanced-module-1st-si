using System;

namespace CreateClass
{
    public enum Gender { Male, Female };

    class Person
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public Gender Gender { get; set; }

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
