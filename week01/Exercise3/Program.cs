using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //First part of the code corresponds to Part 1 and 2 where the user provides the magic number. 
        //I have commented it out so that in part 3 the program provides a random number. See part 3 below.

        // //# Core Requirements

        // //#1. Start by asking the user for the magic number and for a guess.
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());


        // // Initialize the guess variable to ensure it enters the loop
        // int guessNumber = -1;

        // //2. Use a while loop to keep asking the user for their guess until they get it right.
        // while (guessNumber != magicNumber)
        // {
        //     Console.Write("What is your guess? ");
        //     guessNumber = int.Parse(Console.ReadLine());


        //     //# 3. Adding an if statement to prompt the user to guess a higher, lower number or if they guessed it.
        //     if (guessNumber < magicNumber)
        //     {
        //         Console.WriteLine("Higher");
        //     }

        //     else if (guessNumber > magicNumber)
        //     {
        //         Console.WriteLine("Lower");
        //     }

        //     else
        //     {
        //         Console.WriteLine("You guessed it!");
        //     }
        // }

        string playAgain;

        do
        {
            // Part 3. Generate a random magic number between 1 and 100.
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); // Generate a number between 1 and 100 inclusive.

            // Initialize the guess variable.
            int guessNumber = -1;

            // Initialize the attempts count.
            int attemptCount = 0;

            Console.WriteLine("I have generated a random number between 1 and 100. Can you guess it?");

            // 3.2 Use a while loop to keep asking the user for their guess until they get it right.
            while (guessNumber != magicNumber)
            {
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());

                attemptCount += 1; // Increment the attempt counter.

                // 4. Prompt the user to guess higher, lower, or inform them they guessed correctly.
                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {attemptCount} attempts.");
                }
            }

            // 4. Ask the user if they want to play again.
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes" || playAgain == "y"); // Repeat the game if the user answers "yes" or "y".

        // Thank the the user after the game ends.
        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}