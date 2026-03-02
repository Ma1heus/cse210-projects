using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();
        int grade = int.Parse (valueFromUser);
        string letter = "";
        string sign = "";

        if (grade > 100 || grade < 0){
            Console.Write("Invalid Grade! Try again!");
            return;
        }
        else {
            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
            else if (grade >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            if (grade % 10 >= 7)
            {
                if (grade > 90 || grade < 60)
                {
                    sign = "";
                }
                else
                {
                    sign = "+";
                }
            }
            else if (grade % 10 < 3)
            {
                if (grade < 60)
                {
                    sign = "";
                }
                else
                {
                    sign = "-";
                }
            }
            else
            {
                sign = "";
            }

            Console.WriteLine($"Your final grade is {letter}{sign}!");

            if (grade >= 70){
                Console.Write("Good Job! You are approved!");   
            }
            else
            {
                Console.Write("I'm sorry, but you failed. I know that you can do better, so keep trying!");
            }
        }
    }
}