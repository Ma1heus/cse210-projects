using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        Console.WriteLine("Enter a list of number, type 0 when finished: ");
        int sum = 0;
        int largestNumber = 0;
        int smallestPositiveNumber = 0;
        float average = 0;

        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (smallestPositiveNumber == 0 && number > 0)
            {
                smallestPositiveNumber = number;
            }
            else if (number < smallestPositiveNumber && number > 0)
            {
                smallestPositiveNumber = number;
            }
            if (number != 0)
            {
                numberList.Add(number);
                sum += number;
            }
            if (number > largestNumber)
            {
                largestNumber = number;
            }

            if (number == 0)
            {
                average = (float)sum / numberList.Count;
                numberList.Sort();

                Console.WriteLine($"The Sum is: {sum}");
                Console.WriteLine($"The average is: {average}");
                Console.WriteLine($"The largest number is: {largestNumber}");
                Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");

                Console.WriteLine("The sorted list is:");
                foreach (int n in numberList)
                {
                    Console.WriteLine(n);
                }

                break;
            }
        }

    }
}