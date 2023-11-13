namespace l5v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Humancycle humancycle = new Humancycle();

            humancycle.Ride();
            humancycle.Talk();
            humancycle.CustomMethod();

            IHuman human = new Humancycle();
            human.Talk();
            IMotorcycle motorcycle = new Humancycle();
            motorcycle.Ride();
        }
    }

}

