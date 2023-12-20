using System;

public interface IPrototype<T>
{
    T Clone();
}

public class ConcretePrototype : IPrototype<ConcretePrototype>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ConcretePrototype(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public ConcretePrototype Clone()
    {
        return new ConcretePrototype(Id, Name);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}");
    }
}

class Program
{
    static void Main()
    {
        ConcretePrototype original = new ConcretePrototype(1, "Original");

        ConcretePrototype clone = original.Clone();

        Console.WriteLine("Original Object:");
        original.DisplayInfo();

        Console.WriteLine("Cloned Object:");
        clone.DisplayInfo();

        Console.ReadKey();
    }
}
