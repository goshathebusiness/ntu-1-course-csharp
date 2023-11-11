namespace l3v2;

public class CPoint : CGraphicsObject
{
    public CPoint()
    {
        Console.WriteLine("CPoint successfully created");
    }

    ~CPoint()
    {
        Console.WriteLine("CPoint successfully destroyed");
    }

    public new void Show()
    {
        Console.WriteLine($"This is {GetType().Name} object with properties:\n" +
                          $"x = {X}\n" +
                          $"y = {Y}");
    }

}