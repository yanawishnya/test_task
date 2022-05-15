using System;
using NUnit.Framework;
using Shapes;

namespace ShapeTest;

public class Tests
{
    [Test]
    public void InvalidCircle()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var circle = new Circle(-5);
        }, "Некорретное значение радиуса");
    }
    
    [Test]
    public void CircleSquare()
    {
        IShape circle = new Circle(1);
        Assert.AreEqual(Math.PI, circle.Square());
    }
    
    [Test]
    public void InvalidTriangle()
    {
        const string message = "Некорретное значение стороны треугольника";
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(0, 1, 2);
        }, message);
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(2, 0, 1);
        }, message);
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(3, 2, 0);
        }, message);
    }
    
    [Test]
    public void TriangleSquare()
    {
        IShape triangle = new Triangle(3, 4, 5);
        Assert.AreEqual(6, triangle.Square());
    }
    
    [Test]
    public void RightTriangleSquare()
    {
        IShape rightTriangle = new Triangle(3, 4, 5);
        Assert.AreEqual(6, rightTriangle.Square());
    }
}