using System.Collections;

namespace l6v8
{
    class Program
    {
        delegate void ShowMethod();

        static void Main(string[] args)
        {
			var square = new Square();
            square.Side = 10;

            var brokenLineGraph = new BrokenLineGraph(2);
            brokenLineGraph.X = 491;
            brokenLineGraph.Y = 581;

            brokenLineGraph.CreatePointInGraph(1, 1,2);
            brokenLineGraph.CreatePointInGraph(2,52,62);


            ArrayList objectList = new ArrayList() {square, brokenLineGraph};


            ShowMethod show;
            foreach (var obj in objectList)
            {
                if (obj is CGraphicsObject showableObj)
                {
                    show = showableObj.Show;
                    show();
                }
            }
        }
    }
}
