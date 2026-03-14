// Creativity and Exceeding Requirements:
// - Added input validation for menu options using TryParse.
// - Prevented program crashes when invalid values are entered.
// - Added file existence validation before loading a journal.
// - Automatically adds .txt extension when saving files.
// - Added checks to prevent errors when reading file lines.


using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit");

            choice = GetMenuChoice();

            if (choice == 1)
            {
                string prompt = promptGen.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._prompt = prompt;
                entry._response = response;

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
            }
        }
    }

    static int GetMenuChoice()
    {
        int choice;

        while (true)
        {
            Console.Write("Select an option (1-5): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 5)
            {
                return choice;
            }

            Console.WriteLine("Invalid option. Please enter a number between 1 and 5.");
        }
    }
}