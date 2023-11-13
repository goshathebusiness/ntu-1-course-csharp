namespace l5v8
{
    class Program
    {
        static void Main(string[] args)
        {
            Multitool multitool = new Multitool();

            multitool.EatWithSpoon();
            multitool.EatWithFork();
            multitool.CustomMethod();

            IFork fork = new Multitool();
            fork.EatWithFork();
            ISpoon spoon = new Multitool();
            spoon.EatWithSpoon();
        }
    }

}

