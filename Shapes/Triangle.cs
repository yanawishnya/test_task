namespace Shapes;

public class Triangle : IShape
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;
    
    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Некорректное значение стороны треугольника");
        }
        if (b + c < a || a + c < b || a + b < c)
        {
            throw new ArgumentException("Сторона должна быть меньше суммы двух других сторон");
        }
        _a = a;
        _b = b;
        _c = c;
    }

    private double Perimeter() => _a + _b + _c;

    public double Square()
    {
        // Проверка на то, что треугольник прямоугольный.
        if (Math.Round(_a * _a + _b * _b) == Math.Round(_c * _c))
        {
            return _a * _b / 2;
        }
        return Math.Sqrt(Perimeter() / 2 * (Perimeter() / 2 - _a) *
                         (Perimeter() / 2 - _b) * (Perimeter() / 2 - _c));
    }
}