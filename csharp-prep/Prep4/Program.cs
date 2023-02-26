using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int intNumber = -1;

        while (intNumber != 0)
        {
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            intNumber = int.Parse(userNumber);
            if (intNumber != 0)
            {
                numbers.Add(intNumber);
            }
        }

        // int sumNumbers = 0;
        // foreach (int number in numbers)
        // {
        //     sumNumbers += number;
        // }
        
        int sumNumbers = numbers.Sum();
        float avg = ((float)sumNumbers) / numbers.Count;
        int largestNumber = numbers.Max();

        Console.WriteLine($"The sum is: {sumNumbers}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}