using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine(" 1. Breathing Activity");
        Console.WriteLine(" 2. Listing Activity");
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
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.Run();
        }
        else if (choice == "3")
        {
            ReflectingActivity reflectingActivity = new ReflectingActivity();
            reflectingActivity.Run();
        }
        else
        {
            Console.WriteLine("Invalid choice. Exiting...");
        }


    }

}