using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference to the scripture (book, chapter, verse)
        Reference reference = new Reference("John", 3, 16);

        // Create a scripture with the reference and a text (the verse)
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        // Display the full scripture
        Console.WriteLine("Scripture: ");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        // Hide words until all are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break; // Exit the loop if the user types 'quit'
            }
            else if (input == "")
            {
                // Hide 3 random words
                scripture.HideRandomWords(1);

                // Clear the console and display the updated scripture
                Console.Clear();
                Console.WriteLine("Scripture: ");
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
            }
        }

        // When all words are hidden, show final message to end the program
        Console.WriteLine("Congratulations! You've successfully memorized the scripture!");
    }
}