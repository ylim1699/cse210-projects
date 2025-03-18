using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 3.5);
        Rectangle rectangle = new Rectangle("green", 5.2, 6.5);
        Circle circle = new Circle("blue", 12.5);

        string sColor = square.GetColor();
        Console.WriteLine(sColor);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"color: {shape.GetColor()}, Area: {Math.Round(shape.GetArea(),2)}");
        }
    }
}