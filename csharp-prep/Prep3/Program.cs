using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do{
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);
            
            int guess = 0;
            int count = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                count++;
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You made {count} guesses.");
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        } while (playAgain == "yes");
    }
}