using System;

class Program
{
    static void Main(string[] args)
    {
        // Square square = new Square("Blue", 3);

        // Console.WriteLine($"Color of Square: {square.GetColor()}");
        // Console.WriteLine($"Area of Square: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Orange", 5, 7);
        Console.WriteLine($"Color of Rectangle: {rectangle.GetColor()}");
        Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");

    }

}