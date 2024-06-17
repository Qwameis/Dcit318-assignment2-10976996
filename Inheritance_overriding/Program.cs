using System;

// Step 1: Define the base class Animal
class Animal
{
    // Virtual method MakeSound
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Step 2: Create the derived class Dog
class Dog : Animal
{
    // Override the MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Step 3: Create the derived class Cat
class Cat : Animal
{
    // Override the MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 4: Create instances of Animal, Dog, and Cat
        Animal genericAnimal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        // Call MakeSound() method on each instance
        genericAnimal.MakeSound(); // Output: Some generic sound
        dog.MakeSound();            // Output: Bark
        cat.MakeSound();            // Output: Meow

        // Prevent the console from closing immediately
        Console.ReadLine();
    }
}