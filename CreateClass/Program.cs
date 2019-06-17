using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Béla", DateTime.Now, Gender.Male);
            Console.WriteLine(person.ToString());
            Console.WriteLine();
            Console.ReadKey();

            Employee employee = new Employee("Jolika", DateTime.Now, Gender.Female, 100, "varrónő");
            employee.Room = new Room(11);
            Console.WriteLine(employee.ToString());
            Console.WriteLine();
            Console.ReadKey();

            Employee Kovacs = new Employee("Géza", DateTime.Now, Gender.Male, 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.Number = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}
