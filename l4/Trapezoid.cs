namespace l4;

public class Trapezoid : CGraphicsObject
{
    public double TopBase { set; get; }
    public double BottomBase { get; set; }
    public double LeftSide { get; set; }
	public double RightSide { get; set; }

	public override double GetPerimeter()
	{
		return TopBase + BottomBase + LeftSide + RightSide;
	}
}