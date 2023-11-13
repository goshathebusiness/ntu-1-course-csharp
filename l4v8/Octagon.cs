namespace l4v8;

public class Octagon : CGraphicsObject
{
    public double Side { set; get; }

    public override double GetPerimeter()
    {
        return 8 * Side;
    }
}