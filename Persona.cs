using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phenov_test_program
{
    class Person
    {
        public Person(string firstName, string lastName) //конструктор
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() //переопределение метода родителя через перезапись
        {
            return FirstName + " " + LastName;
        }

        public new bool Equals(Object obj) //переопределение метода родителя через копию
        {
            Person person = (Person)obj;
            return (FirstName == person.FirstName) && (LastName == person.LastName);
        }

        static public string ComparePersons(Person person1, Person person2) //сравнение 2-х объектов по параметрам или это один объект
        {
            bool equalParams = person1.Equals(person2); // местная копия
            Object personobj = person1;
            bool fullEqual = personobj.Equals(person2); // родительский метод

            if (fullEqual)
                return "Absolutely, full equal.";
            if (equalParams)
                return "Not absolutely, params equal.";

            return "Absolutely no, not equal";
        }

        public string ComparePersons(Person person) //без статического метода
        {
            bool equalParams = Equals(person); // местная копия            
            bool fullEqual = base.Equals(person); // родительский метод

            if (fullEqual)
                return "Absolutely, full equal.";
            if (equalParams)
                return "Not absolutely, params equal.";

            return "Absolutely no, not equal";
        }

        public string FirstName { get; set; } //свойства
        public string LastName { get; set; }
    }
}
