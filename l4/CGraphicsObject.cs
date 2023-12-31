using System.Reflection;

namespace l4;

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

    public virtual double GetPerimeter()
    {
        return 0;
    }

    public static bool operator ==(CGraphicsObject obj1, CGraphicsObject obj2)
    {
        if (ReferenceEquals(obj1, obj2))
            return true;

        return obj1.GetPerimeter().Equals(obj2.GetPerimeter());
    }

    public static bool operator !=(CGraphicsObject obj1, CGraphicsObject obj2)
    {
        return !(obj1 == obj2);
    }
}