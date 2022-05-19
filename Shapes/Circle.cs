namespace Shapes;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Некорретное значение радиуса");
        }
        _radius = radius;
    }
    
    public double Square() => Math.PI * _radius * _radius;
}