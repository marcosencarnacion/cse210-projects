using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine($"Fraction 1: {f1.GetFractionString()}");

        Fraction f2 = new Fraction(6);
        Console.WriteLine($"Fraction 2: {f2.GetFractionString()}");

        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine($"Fraction 3: {f3.GetFractionString()}");

        // Show the decimal value of the fractions
        Console.WriteLine($"Fraction 1 in decimal: {f1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2 in decimal: {f2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3 in decimal: {f3.GetDecimalValue()}");
    }
}