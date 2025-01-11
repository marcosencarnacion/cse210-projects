using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //#1. Start by asking the user for the magic number and for a guess.
        Console.WriteLine("What is the magic number?");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("What is your guess?");
        int guessNumber = int.Parse(Console.ReadLine());

    }
}