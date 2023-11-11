namespace l3v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new CPoint();
            point.X = 517;
            point.Y = 168;
            point.Show();

            var cArc = new CircularArc();
            cArc.X = 1515;
            cArc.Y = 1024;
            cArc.Radius = 5;
            cArc.CentralAngle = 30;
            cArc.ArcLength = 15;
            cArc.Show();
        }
    }
}