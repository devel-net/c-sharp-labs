using System;

interface IShape
{
    double GetArea();
}

class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : IShape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double GetArea()
    {
        return width * height;
    }
}

class Program4
{
    static void Main()
    {
        IShape[] shapes = new IShape[2];
        shapes[0] = new Circle(5);
        shapes[1] = new Rectangle(3, 4);

        foreach (var shape in shapes)
        {
            double area = shape.GetArea();
            Console.WriteLine($"Площа фігури: {area}");
        }

        Console.ReadLine();
    }
}