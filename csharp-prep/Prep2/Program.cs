using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter_grade = "";

        if (percent >= 90)
        {
            letter_grade = "A";
        }
        else if (percent >= 80)
        {
            letter_grade = "B";
        }
        else if (percent >= 70)
        {
            letter_grade = "C";
        }
        else if (percent >= 60)
        {
            letter_grade = "D";
        }
        else
        {
            letter_grade = "F";
        }
        Console.WriteLine($"Your grade is : {letter_grade}");
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Gotta try better next time.");
        }
    }
}