using System.Reflection;

namespace l4v2;

public class CGraphicsObject
{
    public CGraphicsObject()
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

    public virtual double GetArea()
    {
        return 0;
    }

    public static double operator -(CGraphicsObject obj1, CGraphicsObject obj2)
    {
        return obj1.GetArea() - obj2.GetArea();
    }
}