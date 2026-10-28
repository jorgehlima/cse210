
Console.Write("What is your grade percentage? ");
string input = Console.ReadLine() ?? "";
int grade = int.Parse(input);

// Create a variable to store the letter grade
string letter = "";

// Displays the letter grade
if (grade >= 90)
{
    letter = "A";
}
else if (grade >= 80)
{
    letter = "B";
}
else if (grade >= 70)
{
    letter = "C";
}
else if (grade >= 60)
{
    letter = "D";
}
else
{
    letter = "F";
}

// Displays the grade sign
string sign = "";

// Get the last digit of the grade
int lastDigit = grade % 10;

if (lastDigit >= 7)
{
    sign = "+";
}
else if (lastDigit < 3)
{
    sign = "-";
}

 // Display the letter grade and sign
Console.WriteLine($"Your grade is {letter}{sign}.");

// passed or failed message
if (grade >= 70)
{
    Console.WriteLine("Congratulations! You passed the course!");
}
else
{
    Console.WriteLine("Keep trying! You can do better next time!");
}
