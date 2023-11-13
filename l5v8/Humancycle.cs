namespace l5v8;

public class Multitool : IFork, ISpoon
{
    public void EatWithSpoon()
    {
        Console.WriteLine("Eating soup");
    }

    public void EatWithFork()
    {
        Console.WriteLine("Eating salad with mayo and breadcrumbs");
    }

    public void CustomMethod()
    {
        Console.WriteLine("Custom method for Multitool");
    }
}