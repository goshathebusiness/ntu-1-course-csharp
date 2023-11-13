namespace l6v8;

public class BrokenLineGraph : CGraphicsObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public double[][] Cords { get; set; }

    public BrokenLineGraph(int capacity)
    {
        Cords = new double[capacity][];
        Console.WriteLine("BrokenLineGraph successfully created");
    }

    public void CreatePointInGraph(int num, double x, double y)
    {
        Cords[num - 1] = new double[2] { x, y };
    }

    public new void Show()
    {
        string line = "";
        line += $"This is {GetType().Name} object with properties:\n" +
                $"initial point x = {X}\n" +
                $"initial point y = {Y}\n";

        for (int i = 0; i < Cords.Length; i++)
        {
            line += $"{i + 1} point:\n" +
                    $"X = {Cords[i][0]}\n" +
                    $"Y = {Cords[i][1]}\n";
        }

        Console.WriteLine(line);
    }

}