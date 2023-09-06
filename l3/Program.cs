namespace l3
{
    class Program
    {
        static void Main(string[] args)
        {
            CPoint point = new CPoint();
            point.SetCords(14.1, 36);
            point.Show();

            EllepticalArc eArc = new EllepticalArc();
            eArc.SetCords(0.2, 12.556);
            eArc.SetAngles(45, 66.6);
            eArc.Show();

        }
    }
}