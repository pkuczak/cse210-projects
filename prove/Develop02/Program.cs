using System;

class Program
{
    static void Main(string[] args)
    {
        // Create menu and user input variables
        Journal journal = new Journal();
        int menuUserInput = 0;

        List<string> menu = new List<string>
        {
            "Please select one of the following choices:",
            "1. Write an entry",
            "2. Display entries",
            "3. Load a file",
            "4. Save to file",
            "5. Quit"
        };

        // While user input is not 5
        // Switch statement for user input.
        while (menuUserInput != 5)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }

            Console.Write("What would you like to do? ");
            menuUserInput = int.Parse(Console.ReadLine());

            if (menuUserInput == 1)
            {
                journal.CreateJournalEntry();
            }

            else if(menuUserInput == 2)
            {
                journal.DisplayJournalEntries();
            }

            else if(menuUserInput == 3)
            {
                journal.LoadFromCSV();
            }

            else if(menuUserInput == 4)
            {
                journal.SaveToCSV();
            }

            else
            {
                Console.Write("Goodbye");
            }
        }
        
    }
}