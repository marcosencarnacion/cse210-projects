using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //#1. Start by asking the user for the magic number and for a guess.
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.Write("What is your guess? ");
        int guessNumber = int.Parse(Console.ReadLine());

        //# 2. Adding an if statement to prompt the user to guess a higher, lower number or if they guessed it.
        if (guessNumber < magicNumber)
        {
            Console.Write("Higher");
        }

        else if (guessNumber > magicNumber)
        {
            Console.Write("Lower");
        }

        else
        {
            Console.Write("You guessed it!");
        }


    }
}