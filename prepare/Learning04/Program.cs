using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        WritingAssignment a = new WritingAssignment("Samuel Bennett", "Multiplication", "How to Multiply Fractions");
        Console.WriteLine($"{a.GetSummary()}");
        Console.WriteLine($"{a.GetWritingInformation()}");

    }
}