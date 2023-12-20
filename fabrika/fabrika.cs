using System;

public class Factory
{
    public IProduct CreateProduct(string productType)
    {
        switch (productType.ToLower())
        {
            case "producta":
                return new ProductA();
            case "productb":
                return new ProductB();
            default:
                throw new ArgumentException("Unknown product type");
        }
    }
}

public interface IProduct
{
    void Display();
}
public class ProductA : IProduct
{
    public void Display()
    {
        Console.WriteLine("Product A");
    }
}

public class ProductB : IProduct
{
    public void Display()
    {
        Console.WriteLine("Product B");
    }
}
