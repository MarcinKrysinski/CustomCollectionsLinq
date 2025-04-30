namespace CustomCollectionsLinq;

public class Person
{
    private string Name { get; set; }
    private int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine($"Tworze: Name: {Name}, Age: {Age}");
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}