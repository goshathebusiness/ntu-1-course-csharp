namespace l5
{
    class Program
    {
        static void Main(string[] args)
        {
            Pegasus pegasus = new Pegasus();

            pegasus.Fly();
            pegasus.Gallop();
            pegasus.CustomMethod();

            IBird bird = new Pegasus();
            bird.Fly();
            IHorse horse = new Pegasus();
            horse.Gallop();
        }
    }

}

