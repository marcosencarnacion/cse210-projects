using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Dylan Encarnacion", "Mathematics");
        Console.WriteLine(assignment.GetSummary());

        Assignment assignment1 = new Assignment("Roberto Rodriguez", "Fractions");
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}