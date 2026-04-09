// EXCEEDING REQUIREMENTS:
// - Added score system
// - Added checklist bonus system
// - Persistent save/load system
// - Improved UI with status symbols ([X], [ ], [∞])

using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        string choice = "";

        while (choice != "6")
        {
            Console.Clear();
            manager.DisplayScore();

            Console.WriteLine("\n1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            Console.Write("Choose: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.DisplayGoals(); Console.ReadLine(); break;
                case "3": manager.RecordEvent(); Console.ReadLine(); break;
                case "4": manager.Save(); break;
                case "5": manager.Load(); break;
            }
        }
    }
}