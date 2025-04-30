namespace CustomCollectionsLinq;

public class DataBetterGenerator
{
    public static IEnumerable<Person> GetPersons()
    {
        yield return new Person("John", 24);
        yield return new Person("Jane", 25);
        yield return new Person("Juan", 26);
    }
}