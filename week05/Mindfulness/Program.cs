using System;

class Program
{
    static void Main(string[] args)
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
        }
        else
        {
            Console.WriteLine("Invalid entry. Please select a valid option.");
        }


    }

}