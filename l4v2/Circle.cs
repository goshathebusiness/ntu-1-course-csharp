namespace l4v2;

public class Circle : CGraphicsObject
{
    public double Radius { set; get; }

    public override double GetArea()
    {
        return Math.PI * (Radius * Radius);
    }
}
