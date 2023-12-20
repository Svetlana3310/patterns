using System;

public interface IOldInterface
{
    void Request();
}

public class OldClass : IOldInterface
{
    public void Request()
    {
        Console.WriteLine("OldClass handles request.");
    }
}

public interface INewInterface
{
    void NewRequest();
}

public class Adapter : INewInterface
{
    private readonly IOldInterface oldObject;

    public Adapter(IOldInterface oldObject)
    {
        this.oldObject = oldObject;
    }

    public void NewRequest()
    {
        oldObject.Request();
    }
}

public class Client
{
    public void DoWork(INewInterface newObject)
    {
        newObject.NewRequest();
    }
}

class Program
{
    static void Main()
    {
        IOldInterface oldObject = new OldClass();
        INewInterface adaptedObject = new Adapter(oldObject);
        Client client = new Client();
        client.DoWork(adaptedObject);
    }
}
