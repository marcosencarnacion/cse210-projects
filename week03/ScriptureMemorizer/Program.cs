using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding Requirements: Created a library of scriptures (10 scriptures, 2 from each book)
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            // Old Testament
            // Old Testament
            new Scripture(new Reference("Genesis", 1, 1), "In the beginning God created the heaven and the earth."),
            new Scripture(new Reference("Isaiah", 40, 31), "But they that wait upon the Lord shall renew their strength; they shall mount up with wings as eagles; they shall run, and not be weary; and they shall walk, and not faint."),

            // New Testament
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Matthew", 5, 14), "Ye are the light of the world. A city that is set on a hill cannot be hid."),

            // Book of Mormon
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Alma", 37, 6), "By small and simple things are great things brought to pass."),

            // Doctrine and Covenants
            new Scripture(new Reference("D&C", 58, 26), "For behold, it is not meet that I should command in all things; for he that is compelled in all things, the same is a slothful and not a wise servant."),
            new Scripture(new Reference("D&C", 121, 45), "Let thy bowels be full of charity towards all men, and to the household of faith, and let virtue garnish thy thoughts unceasingly; then shall thy confidence wax strong in the presence of God; and the doctrine of the priesthood shall distil upon thy soul as the dews from heaven."),
            
            // Pearl of Great Price
            new Scripture(new Reference("Moses", 1, 39), "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man."),
            new Scripture(new Reference("Abraham", 3, 22), "Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones; and God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers."),
        };
        

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
                scripture.HideRandomWords(3);

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