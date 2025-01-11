using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        // Call DisplayWelcome function
        DisplayWelcome();

        // Call PromptUserName function and store the returned value
        string name = PromptUserName();

        // Call PromptUserNumber function and store the returned value
        int favoriteNumber = PromptUserNumber();

        // Call SquareNumber function and store the squared result
        int squaredNumber = SquareNumber(favoriteNumber);

        // Call DisplayResult function to display the final output
        DisplayResult(name, squaredNumber);
    }

    // Simple Functions 
    //Function #1. DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //Function #2. PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName; // Return the entered name
    }

    //Function #3. PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine()); // Parse input to integer
        return userNumber;
    }

    //Function #4. SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number)
    {
        return number * number; //retunr the square of the number
    }

    //Function #5. DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string userName, int SquaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {SquaredNumber}");
    }

    

}