namespace l5v2;

public class Humancycle : IHuman, IMotorcycle
{
    public void Ride()
    {
        Console.WriteLine("Humancycle is riding");
    }

    public void Talk()
    {
        Console.WriteLine("Humancycle is talking");
    }

    public void CustomMethod()
    {
        Console.WriteLine("Custom method for Humancycle");
    }
}