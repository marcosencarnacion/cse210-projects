using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        //Core Requirements

        //User is asked to enter his grade percentage.
        Console.WriteLine("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();
        int number = int.Parse(gradePercentage);

        //Letter Variable Assigned

        string gradeLetter = "";

        if (number >= 90)
        {
            gradeLetter = "A";
        }

        else if (number >= 80)
        {
            gradeLetter = "B";
        }

        else if (number >= 70)
        {
            gradeLetter = "C";
        }

        else if (number >= 60)
        {
            gradeLetter = "D";
        }

        else
        {
            gradeLetter = "F";
        }

        //Grade letter is printed.

        Console.WriteLine($"Your grade letter is: {gradeLetter}");

        //Message depending on the grade is displayed to user.

        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }

        else
        {
            Console.WriteLine("Stay focused and you'll get it next time!");
        }

    }
}