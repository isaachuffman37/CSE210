using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int chosenNumber = -1;
        // Console.Write("Enter a list of numbers, type 0 when finished: ");
        // number = int.Parse(Console.ReadLine());

        while(chosenNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            chosenNumber = int.Parse(Console.ReadLine());
            if(chosenNumber != 0)
            {
            numbers.Add(chosenNumber);
            }
        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The total is: {total}");

        float average = ((float)total)/ numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if ( number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is {max}");

    }
}