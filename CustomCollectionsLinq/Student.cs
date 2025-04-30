namespace CustomCollectionsLinq;

public class Student
{
    private string name;
    private int age;
    private double grade;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public double Grade
    {
        get { return grade; }
        set { grade = value; }
    }

    public Student(string name, int age, double grade)
    {
        this.name = name;
        this.age = age;
        this.grade = grade;
    }

    public override string ToString()
    {
        return name + ", " + age + ", " + grade;
    }
}