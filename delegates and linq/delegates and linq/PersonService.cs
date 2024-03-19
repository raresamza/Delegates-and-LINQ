using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace delegates_and_linq
{
    public class PersonService
    {

        

        private List<Person> people = new List<Person>() {
        new Person(1,"Rares",10),
        new Person(2,"Adi",15),
        new Person(3,"Manu",20)
        };

        public List<Person> People { get { return people; } set { people = value; } }

        public Person Find(ComparePerson comparePerson)
        {
            foreach (Person person in people)
            {
                if (comparePerson(person))
                {
                    return person;
                }
            }
            return null;
        }


        public Print printDelegate = delegate (List<Person> people, string name)
        {
            foreach (Person person in people)
            {
                if (person.Name == name)
                {
                    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                }
            }
        };
    }
}
