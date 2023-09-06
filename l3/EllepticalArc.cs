namespace l3;

public class EllepticalArc : CPoint
{
    public double StartAngle ,EndAngle;

    public EllepticalArc()
    {
        Console.WriteLine("EllecticalArc successfully created");
    }

    ~EllepticalArc()
    {
        Console.WriteLine("EllecticalArc successfully destroyed");
    }

    public void SetAngles(double startAngle, double endAngle)
    {
        StartAngle = startAngle;
        EndAngle = endAngle;
    }

    public double[] GetAngles()
    {
        return new[] { StartAngle, EndAngle };
    }

    public void Show()
    {
        Console.WriteLine($"This is {GetType().Name} object with properties:\n" +
                          $"x = {x}\n" +
                          $"y = {y}\n" +
                          $"starting angle = { StartAngle }\n" +
                          $"ending angle = { EndAngle }\n");
    }

}