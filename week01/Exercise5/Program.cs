using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();


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
            return userName; // Return the name
        }

         //Function #3. PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }
        

    }
}