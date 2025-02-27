using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        //Initialize a list to store the numbers.
        List<int> numbers = new List<int>();

        int userInput;

        // Ask the user to enter a series of numbers until they enter 0
        Console.WriteLine("Enter a list of numbers, type 0 whe finished.");

        do
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0) //Only add numbers to the list if it's not 0
            {
                numbers.Add(userInput);
            }
        } while (userInput != 0);  // Continue the loop until the user enters 0


        //1. Compute the sum, or total, of the numbers in the list.
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        //2. Compute the average of the numbers in the list.
        double average = 0; //Using double for precision
        if (numbers.Count > 0)
        {
            average = (double)sum / numbers.Count;
        }

        //3. Find the maximum, or largest, number in the list.
        int maxNumber = numbers.Max();

        //Stretch Challenge.
        //1. Find the smallest positive number (closest to zero) based on user input.
        List<int> positiveNumbers = numbers.Where(n => n > 0).ToList();

        //Use DefaultEmpty() to handle the case when there are no positive numbers.
        int smallestPositive = positiveNumbers.DefaultIfEmpty(int.MaxValue).Min();

        Console.WriteLine($"The total sum of the numbers is: {sum}");
        Console.WriteLine($"The average of the numbers is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine($"The sorted list is:");

        //Stretch Challenge
        //2.Sort the list and print each number in vertical order
        List<int> sortedNumbers = new List<int>(); //Variable to store sorted list
        sortedNumbers = numbers.OrderBy(n => n).ToList();
        foreach (int number in sortedNumbers)
        {
            Console.WriteLine(number);
        }


    }
}