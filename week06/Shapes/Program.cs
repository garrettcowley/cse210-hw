using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square(4) { Color = "Red" },
            new Rectangle(4, 5) { Color = "Blue" },
            new Circle(3) { Color = "Green" }
        };

        DisplayShapes(shapes);
    }

    static void DisplayShapes(List<Shape> shapes)
    {
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetType().Name}, Color: {shape.GetColor()}, Area: {shape.GetArea():0.00}");
        }
    }
}
