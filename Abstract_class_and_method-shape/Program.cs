using System;

// Step 1: Define the abstract class Shape
abstract class Shape
{
    // Abstract method GetArea
    public abstract double GetArea();
}

// Step 2: Create the derived class Circle
class Circle : Shape
{
    public double Radius { get;}

    // Constructor to initialize the radius
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Implement the GetArea method
    public override double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

// Step 3: Create the derived class Rectangle
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    // Constructor to initialize width and height
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Implement the GetArea method
    public override double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 4: Create instances of Circle and Rectangle
        Shape circle = new Circle(5.0);
        Shape rectangle = new Rectangle(4.0, 6.0);

        // Display their areas
        Console.WriteLine($"Circle area: {circle.GetArea():0.00} square units");  // Output: Circle area: 78.54 square units
        Console.WriteLine($"Rectangle area: {rectangle.GetArea():0.00} square units"); // Output: Rectangle area: 24.00 square units

        // Prevent the console from closing immediately
        Console.ReadLine();
    }
}