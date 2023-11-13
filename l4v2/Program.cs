namespace l4v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Radius = 8.88;
            circle.Show();

            var trapezoid = new Trapezoid();
            trapezoid.BottomBase = 15;
            trapezoid.TopBase = 5;
            trapezoid.Height = 9.56;
            trapezoid.Show();

            Console.WriteLine($"{circle.GetArea()}, {trapezoid.GetArea()}");
            Console.WriteLine(circle - trapezoid);
        }
    }
}