namespace l3
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new CPoint();
            point.X = 14.1;
            point.Y = 36;
            point.Show();

            var eArc = new EllepticalArc();
            eArc.X = 0.2;
            eArc.Y = 12.556;
            eArc.StartAngle = 45;
            eArc.EndAngle = 66.6;
            eArc.Show();
        }
    }
}