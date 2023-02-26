using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade precentage: ");
        string valueFromUser = Console.ReadLine();
        int percentage = int.Parse(valueFromUser);
        string letter = "";
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string symbol = "";
        int lastDigit = percentage % 10;
        if (lastDigit >= 7)
        {
            symbol = "+";
        }
        else if (lastDigit < 3)
        {
            symbol = "-";
        }

        if (percentage >= 93 || percentage < 60)
        {
            Console.WriteLine($"Your letter grade is {letter}");
        }
        else
        {
            Console.WriteLine($"Your letter grade is {letter}{symbol}");
        }
    }
}