using System;

//Exceeding Requirements:
//1. A Question counter added in the "Reflecting Activity" to track how many questions the user is asked during the 
//session. Once these are tracked, they are displayed back to the user so they know the amount of questions they reflected upon.
//2. A while loop was added in the menu of the main program here. This will handle any user invalid input and will continue 
// until the user enters a valid input.

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Begin Breathing Activity");
            Console.WriteLine(" 2. Begin Reflecting Activity");
            Console.WriteLine(" 3. Begin Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you so much for participating in this activity!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid entry. Please select a valid option.");
            }


        }

    }
}