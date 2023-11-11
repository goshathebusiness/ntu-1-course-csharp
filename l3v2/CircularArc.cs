namespace l3v2;

public class CircularArc : CPoint
{
    public double Radius
    {
        get;
        set;
    }
    public double CentralAngle
    {
        get;
        set;
    }
    public double ArcLength
    {
        get;
        set;
    }

    public CircularArc()
    {
        Console.WriteLine("CircularArc successfully created");
    }

    ~CircularArc()
    {
        Console.WriteLine("CircularArc successfully destroyed");
    }


    public new void Show()
    {
        Console.WriteLine($"This is {GetType().Name} object with properties:\n" +
                          $"x = {X}\n" +
                          $"y = {Y}\n" +
                          $"radius = { Radius }\n" +
                          $"central angle = { CentralAngle }\n" +
                          $"arc length = { ArcLength }\n");
    }

}