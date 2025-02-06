using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Dylan Encarnacion", "Mathematics");
        Console.WriteLine(assignment.GetSummary());

    }
}