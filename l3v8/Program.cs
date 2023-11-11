namespace l3v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new CPoint();
            point.X = 7637;
            point.Y = 11;
            point.Show();

            var brokenLineGraph = new BrokenLineGraph(2);
            brokenLineGraph.X = 491;
            brokenLineGraph.Y = 581;

            brokenLineGraph.CreatePointInGraph(1, 1,2);
            brokenLineGraph.CreatePointInGraph(2,52,62);

            brokenLineGraph.Show();
        }
    }
}