namespace l5;

public class Pegasus : IBird, IHorse
{
    public void Fly()
    {
        Console.WriteLine("Pegasus flying");
    }

    public void Gallop()
    {
        Console.WriteLine("Pegasus galloping");
    }

    public void CustomMethod()
    {
        Console.WriteLine("Custom method for Pegasus");
    }
}