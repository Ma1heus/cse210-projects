using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int tries = 0;

            Console.WriteLine("I chose a number!");

            while (true) 
            {
                Console.Write("What is your guess? ");
                string valueFromUser = Console.ReadLine();
                int guess = int.Parse(valueFromUser);
                tries += 1;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You tried {tries} times");
                    Console.Write("Do you want to play again? ");
                    response = Console.ReadLine();
                    if (response == "no")
                    {
                        break;
                    }
                }
            }
            if (response == "no")
            {
                break;
            }
        } while (true);
    }
}