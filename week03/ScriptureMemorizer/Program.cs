using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding Requirements:

        // 1. A library of 10 scriptures from the Standard Works (Old Testament, New Testament, Book of Mormon, 
        // Doctrine and Covenants, and Pearl of Great Price) is created. A random scripture is selected each time 
        // the program runs.

        // 2. Input validation has been added to ensure the user can only hit "Enter" or type "quit" to exit the 
        // program. Any other input is handled with an error message guiding the user to make a valid entry.

        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            // Old Testament
            // Old Testament
            new Scripture(new Reference("Genesis", 1, 1, 2), "In the beginning God created the heaven and the earth. And the earth was without form, and void; and darkness was upon the face of the deep. And the Spirit of God moved upon the face of the waters."),
            new Scripture(new Reference("Isaiah", 40, 31), "But they that wait upon the Lord shall renew their strength; they shall mount up with wings as eagles; they shall run, and not be weary; and they shall walk, and not faint."),

            // New Testament
            new Scripture(new Reference("John", 3, 16, 17), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved."),
            new Scripture(new Reference("Matthew", 5, 14), "Ye are the light of the world. A city that is set on a hill cannot be hid."),

            // Book of Mormon
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Alma", 37, 6, 7), "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise. And the Lord God doth work by means to bring about his great and eternal purposes; and by very small means the Lord doth confound the wise and bringeth about the salvation of many souls."),

            // Doctrine and Covenants
            new Scripture(new Reference("D&C", 58, 26, 27), "For behold, it is not meet that I should command in all things; for he that is compelled in all things, the same is a slothful and not a wise servant; wherefore he receiveth no reward. Verily I say, men should be anxiously engaged in a good cause, and do many things of their own free will, and bring to pass much righteousness;"),
            new Scripture(new Reference("D&C", 121, 45), "Let thy bowels be full of charity towards all men, and to the household of faith, and let virtue garnish thy thoughts unceasingly; then shall thy confidence wax strong in the presence of God; and the doctrine of the priesthood shall distil upon thy soul as the dews from heaven."),
            
            // Pearl of Great Price
            new Scripture(new Reference("Moses", 1, 38, 39), "And as one earth shall pass away, and the heavens thereof even so shall another come; and there is no end to my works, neither to my words. For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man."),
            new Scripture(new Reference("Abraham", 3, 22), "Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones;"),
        };

        // Create a Random object to pick a random scripture from the library.
        Random random = new Random();
        int randomIndex = random.Next(scriptureLibrary.Count); // Pick a random index

        // Get the random scripture
        Scripture randomScripture = scriptureLibrary[randomIndex];

        // Display the full scripture
        Console.WriteLine("Scripture: ");
        Console.WriteLine(randomScripture.GetDisplayText());
        Console.WriteLine();

        // Hide words until all are hidden
        while (!randomScripture.IsCompletelyHidden())
        {
            Console.WriteLine("Please press Enter to continue or type 'quit' to finish.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break; // Exit the loop if the user types 'quit'
            }
            else if (input == "")
            {
                // Hide 3 random words
                randomScripture.HideRandomWords(3);

                // Clear the console and display the updated scripture
                Console.Clear();
                Console.WriteLine("Scripture: ");
                Console.WriteLine(randomScripture.GetDisplayText());
                Console.WriteLine();
            }
            else
            {
                // Display an error message for invalid input
                Console.Write("Invalid input. ");
            }
        }

        // When all words are hidden, show final message to end the program
        Console.WriteLine("Congratulations! You've successfully memorized the scripture!");
    }
}