using delegates_and_linq;

public delegate bool ComparePerson(Person person);
public delegate void Print(List<Person> people, string name);
public delegate void PrintLambda(List<Person> people, string name);

public class DelegatesAndLinq
{
    public static void Main(string[] args)
    {
        PersonService personService = new();

        Console.WriteLine(personService.Find(person => person.Name == "rares" || person.Name == "Manu").Name);
        Console.WriteLine(personService.Find(person => person.Age == 10).Name);

        foreach(Person p in personService.People)
        {
            Console.WriteLine(p.Age);
        }
        personService.printDelegate(personService.People, "Rares");


        PrintLambda printLambda = (people, name) =>
        {
            foreach (Person person in people)
            {
                if (person.Name == name)
                {
                    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                }
            }
        };
        printLambda(personService.People, "Manu");

        var names =personService.People.Where(person => person.Age > 14)
                            .OrderBy(person => person.Name)
                            .Select(person => person.Name).ToList();
        foreach (string name in names) {
            Console.WriteLine(name);
        }
    }
}
