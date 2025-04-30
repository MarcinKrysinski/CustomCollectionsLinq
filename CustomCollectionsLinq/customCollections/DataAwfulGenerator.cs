namespace CustomCollectionsLinq;

public class DataAwfulGenerator
{
    public static IEnumerable<Person> GetPersons()
    {
        List<Person> persons = new List<Person>();
        persons.Add(new Person("Adam", 20));
        persons.Add(new Person("Zosia", 19));
        persons.Add(new Person("Ktoś", 25));
        return persons;
    }
}