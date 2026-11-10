using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        // Test the getter for the numerator
        Console.WriteLine($"Numerator: {fraction3.GetTop()}");

        // Change numerator
        fraction3.SetTop(8);

        // Verify numerator
        Console.WriteLine($"Updated numerator: {fraction3.GetTop()}");
    }
}