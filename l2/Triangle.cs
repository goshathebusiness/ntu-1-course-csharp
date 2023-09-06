namespace l2;

public class Triangle
{
    private
        double a, b, c;

    public Triangle()
    {
        Console.WriteLine($"Triangle was successfully created");
    }
    ~Triangle()
    {
        Console.WriteLine($"Triangle was successfully destroyed");
    }

    public void SetASide(double value) {a = value;}
    public double GetASide() {return a;}

    public void SetBSide(double value) {b = value;}
    public double GetBSide() {return b;}

    public void SetCSide(double value) {c = value;}
    public double GetCSide() {return c;}

    public double GetSquare()
    {
        double perimeter = a + b + c;
        return Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
    }

}