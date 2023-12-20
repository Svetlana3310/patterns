using System;

class Product
{
    public string Part1 { get; set; }
    public string Part2 { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Part1: {Part1}, Part2: {Part2}");
    }
}

abstract class Builder
{
    public abstract void BuildPart1();
    public abstract void BuildPart2();
    public abstract Product GetResult();
}

class ConcreteBuilder : Builder
{
    private Product product = new Product();

    public override void BuildPart1()
    {
        product.Part1 = "Part1 built";
    }

    public override void BuildPart2()
    {
        product.Part2 = "Part2 built";
    }

    public override Product GetResult()
    {
        return product;
    }
}

class Director
{
    private Builder builder;

    public Director(Builder builder)
    {
        this.builder = builder;
    }

    public void Construct()
    {
        builder.BuildPart1();
        builder.BuildPart2();
    }
}

class Program
{
    static void Main()
    {
        Builder builder = new ConcreteBuilder();

        Director director = new Director(builder);

        director.Construct();

        Product product = builder.GetResult();

        product.ShowInfo();
    }
}
