using System;
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);

        Scripture scripture = new Scripture(
            reference,
            "For God so loved the world that he gave his only begotten Son"
        );

        Random rand = new Random();

        // Creativity: The program hides a random number of words (1–3) each time,
        // making the memorization process more dynamic and less predictable.

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
                break;

            Console.WriteLine("\nPress Enter to continue or type 'quit':");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(rand.Next(1, 4));
        }
    }
}