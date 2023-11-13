namespace l4v8;

public class Square : CGraphicsObject
{
    public double Side { set; get; }
	public override double GetPerimeter()
	{
		return Side * 4;
	}
}