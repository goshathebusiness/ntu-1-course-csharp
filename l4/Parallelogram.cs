namespace l4;

public class Parallelogram : CGraphicsObject
{
    public double XSide { set; get; }
    public double YSide { set; get; }

    public double GetPerimeter()
    {
        return (2 * XSide) + (2 * YSide);
    }

}