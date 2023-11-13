namespace l4v8
{
    class Program
    {
        static void Main(string[] args)
        {
			var octagon = new Octagon();
            octagon.Side = 6;
            octagon.Show();

            var square = new Square();
            square.Side = 4;
            square.Show();

            Console.WriteLine($"{octagon.GetPerimeter()}, {square.GetPerimeter()}");
            Console.WriteLine(octagon / square);
        }
    }
}
