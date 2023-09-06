namespace l1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri1 = new Triangle();

            tri1.SetASide(3);
            tri1.SetBSide(4);
            tri1.SetASide(8);

            Console.WriteLine(tri1.GetASide());

            Console.WriteLine(tri1.GetSquare());

            tri1.SetASide(35);

            Console.WriteLine(tri1.GetSquare());
        }
    }
}