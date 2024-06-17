using System;

// Step 1: Define the IMovable interface
interface IMovable
{
    void Move();
}

// Step 2: Create the Car class implementing IMovable
class Car : IMovable
{
    // Implement the Move method
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Step 3: Create the Bicycle class implementing IMovable
class Bicycle : IMovable
{
    // Implement the Move method
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 4: Create instances of Car and Bicycle
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        // Call Move() method on each instance
        car.Move();      // Output: Car is moving
        bicycle.Move();  // Output: Bicycle is moving

        // Prevent the console from closing immediately
        Console.ReadLine();
    }
}