namespace l1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter X");
            string value = Console.ReadLine();
            double x;
            try
            {
                x = double.Parse(value);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Error: not numeral elements in X");
                return;
            }


            double result = Math.Pow(x, x + 3) + Math.Tan(x);

            Console.WriteLine(result);
        }
    }
}