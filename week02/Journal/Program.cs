//CSE210 W2 Journal Program by April Cleaver

// Exceeding Requirements: I added a mood tracker to the "Write an entry" option. When the user selects 1, they are asked how they are feeling. The answer is stored in a string, then the program gives them the prompt and continues as required. The mood info is displayed in the journal after the date.

using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        Journal myJournal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        while (userChoice != 5)
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                string date = DateTime.Now.ToShortDateString();

                Console.WriteLine("How are you feeling today?");
                Console.Write("> ");
                string mood = Console.ReadLine();

                PromptGenerator newPrompt = new PromptGenerator();
                string prompt = newPrompt.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");
                string input = Console.ReadLine();

                Entry anEntry = new Entry(date, mood, prompt, input);
                myJournal.AddEntry(anEntry);
            }
            else if (userChoice == 2)
            {
                myJournal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                myJournal.SaveToFile("myJournal.txt");
            }
            else if (userChoice == 4)
            {
                Console.Write("What is the file name? ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
        }
        Console.WriteLine("Goodbye.");
    }
}