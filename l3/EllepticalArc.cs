namespace l3;

public class EllepticalArc : CPoint
{
    public double StartAngle
    {
        get;
        set;
    }
    public double EndAngle
    {
        get;
        set;
    }

    public EllepticalArc()
    {
        Console.WriteLine("EllecticalArc successfully created");
    }

    ~EllepticalArc()
    {
        Console.WriteLine("EllecticalArc successfully destroyed");
    }


    public new void Show()
    {
        Console.WriteLine($"This is {GetType().Name} object with properties:\n" +
                          $"x = {X}\n" +
                          $"y = {Y}\n" +
                          $"starting angle = { StartAngle }\n" +
                          $"ending angle = { EndAngle }\n");
    }

}