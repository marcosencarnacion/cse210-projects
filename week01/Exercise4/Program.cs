using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        //Initialize a list to store the numbers.
        List<int> numbers = new List<int>();

        int userInput;

        // Ask the user to enter a series of numbers until they enter 0
        Console.WriteLine("Enter a list of numbers, type 0 whe finished.");

        do
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0) //Only add numbers to the list if it's not 0
            {
                numbers.Add(userInput);
            }
        }

    }
}