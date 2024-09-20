namespace MyTests.DataSamples;

public struct Person
{
    public string FullName { get; set; }
    public string Name { get; set; }
    public byte Age { get; set; }

    public Person(string fullName, string name, byte age)
    {
        FullName = fullName;
        Name = name;
        Age = Age;
    }
}

public interface IPerson2
{
    public string FullName { get; set; }
    public string Name { get; set; }
    public byte Age { get; set; }
}

public class MyPerson : IPerson2
{
    public string FullName { get; set; }
    public string Name { get; set; }
    public byte Age { get; set; }

    public MyPerson(string fullName, string name, byte age)
    {
        FullName = fullName;
        Name = name;
        Age = age;
    }
}