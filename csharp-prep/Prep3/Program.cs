using System;

class Program
{
    static void Main(string[] args)
    
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int response;
        do 
        {
        Console.Write ("What is your guess?");
        response = int.Parse(Console.ReadLine());

        if (response > number)
        {
            Console.WriteLine("lower");
        }

        else if (response< number)
        {
            Console.WriteLine("higher");
        }

        else
        {
            Console.WriteLine("You got it!");
        }
        } while (number != response);

    }
}