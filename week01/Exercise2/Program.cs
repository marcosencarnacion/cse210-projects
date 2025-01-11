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

        //Stretch Challenge: Determine "+" "-" sign for the letter

        string sign = "";
        int lastDigit = number % 10;

        // Determine "+" or "-" based on the last digit

        //Check for a perfect grade (100) and avoid adding a sign
        if (number >= 97)
        {
            sign = "";
        }

        else if (gradeLetter != "F") // No "+" or "-" for grade F
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }

            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }



        //Grade letter is printed with sign.

        Console.WriteLine($"Your grade letter is: {gradeLetter}{sign}");

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