using System.Collections;

namespace l6
{
    class Program
    {
        delegate void ShowMethod();

        static void Main(string[] args)
        {
			var parallelogram = new Parallelogram();
            parallelogram.XSide = 10;
            parallelogram.YSide = 15;

            var trapezoid = new Trapezoid();
            trapezoid.BottomBase = 15;
            trapezoid.TopBase = 5;
            trapezoid.LeftSide = 10;
            trapezoid.RightSide = 10;

            ArrayList objectList = new ArrayList() {parallelogram, trapezoid};


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
