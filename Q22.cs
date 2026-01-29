using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Example Usage:
        string[] inputs = { "C 5", "R 4 6", "T 10 5" };
        Console.WriteLine(CalculateTotalArea(inputs)); 
    }

    public static double CalculateTotalArea(string[] shapes)
    {
        double totalArea = 0;

        foreach (string entry in shapes)
        {
            string[] parts = entry.Split(' ');
            string type = parts[0];

            Shape shape = type switch
            {
                "C" => new Circle(double.Parse(parts[1])),
                "R" => new Rectangle(double.Parse(parts[1]), double.Parse(parts[2])),
                "T" => new Triangle(double.Parse(parts[1]), double.Parse(parts[2])),
                _ => null
            };

            if (shape != null)
            {
                totalArea += shape.GetArea();
            }
        }

        // Round to 2 decimals using AwayFromZero
        return Math.Round(totalArea, 2, MidpointRounding.AwayFromZero);
    }
}

// 1. Interface for Area
public interface IArea
{
    double GetArea();
}

// 2. Abstract Base Class
public abstract class Shape : IArea
{
    public abstract double GetArea();
}

// 3. Concrete Shape Classes
public class Circle : Shape
{
    private double _r;
    public Circle(double r) => _r = r;
    public override double GetArea() => Math.PI * _r * _r;
}

public class Rectangle : Shape
{
    private double _w, _h;
    public Rectangle(double w, double h) { _w = w; _h = h; }
    public override double GetArea() => _w * _h;
}

public class Triangle : Shape
{
    private double _b, _h;
    public Triangle(double b, double h) { _b = b; _h = h; }
    public override double GetArea() => 0.5 * _b * _h;
}
