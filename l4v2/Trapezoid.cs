namespace l4v2;

public class Trapezoid : CGraphicsObject
{
    public double TopBase { set; get; }
    public double BottomBase { get; set; }
    public double Height { get; set; }

    public override double GetArea()
    {
        return ((TopBase + BottomBase) / 2) * Height;
    }
}