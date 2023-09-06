namespace l3;

public class CPoint : CGraphicsObject
{
    public double x, y;


    public CPoint()
    {
        Console.WriteLine("CPoint successfully created");
    }

    ~CPoint()
    {
        Console.WriteLine("CPoint successfully destroyed");
    }

    public void SetCords(double xCord, double yCord)
    {
        x = xCord;
        y = yCord;
    }

    public double[] GetCords()
    {
        return new[] { x, y };
    }

    public void Show()
    {
        Console.WriteLine($"This is {GetType().Name} object with properties:\n" +
                          $"x = {x}\n" +
                          $"y = {y}");
    }

}