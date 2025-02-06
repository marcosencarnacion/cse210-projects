using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment = new Assignment("Dylan Encarnacion", "Mathematics");
        // Console.WriteLine(assignment.GetSummary());

        Assignment assignment1 = new Assignment("Roberto Rodriguez", "Fractions");
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");

        Console.WriteLine(mathAssignment.GetHomeworkList());

    }
}