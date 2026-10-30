using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine() ?? "");

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // empty list check
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        int sum = 0;

        foreach (int value in numbers)
        {
            sum += value;
        }

        Console.WriteLine($"The sum is: {sum}");

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        int largest = numbers[0];

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");

        int smallestPositive = int.MaxValue;

        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }

        // sorting numbers
        numbers.Sort();

        // sorted list will be displayed
        Console.WriteLine("The sorted list is:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}