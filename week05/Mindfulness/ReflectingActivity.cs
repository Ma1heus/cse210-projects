using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you did something really difficult.",
        "Think of a time you helped someone."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful?",
        "What did you learn about yourself?",
        "How did you feel at the time?",
        "What made this experience special?"
    };

    public ReflectingActivity()
        : base("Reflecting Activity", "This activity helps you reflect on experiences.")
    {
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();

        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}");

        Console.WriteLine("\nThink about it...");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"\n{question}");
            ShowSpinner(4);
        }

        EndActivity();
    }
}