using System.Reflection;

namespace l4;

public class CGraphicsObject
{
    public double X
    {
        get;
        set;
    }
    public double Y
    {
        get;
        set;
    }

    public CGraphicsObject
    {
        Console.WriteLine($"{GetType().Name} successfully created");
    }

    ~CGraphicsObject()
    {
        Console.WriteLine($"{GetType().Name} successfully destroyed");
    }


    public void Show()
    {
        Type objectType = GetType();

        Console.WriteLine($"Object {objectType}");

        foreach (PropertyInfo property in objectType.GetProperties())
        {
            Console.WriteLine($"Property: {property.Name}, Value: {property.GetValue(this)}");
        }
    }
}