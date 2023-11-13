namespace l4
{
    class Program
    {
        static void Main(string[] args)
        {
			var parallelogram = new Parallelogram();
            parallelogram.XSide = 10;
            parallelogram.YSide = 15;
            parallelogram.Show();

            var trapezoid = new Trapezoid();
            trapezoid.BottomBase = 15;
            trapezoid.TopBase = 5;
            trapezoid.LeftSide = 10;
            trapezoid.RightSide = 10;
            trapezoid.Show();

            Console.WriteLine($"{parallelogram.GetPerimeter()}, {trapezoid.GetPerimeter()}");
            Console.WriteLine(parallelogram == trapezoid);
        }
    }
}
