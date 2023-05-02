using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // creates a object in the car class
        // Car bmw_m3 = new Car();

        // puts values in the variables creates in Car.cs
        // bmw_m3.brand = "BMW";
        // bmw_m3.miles = 10000;
        // bmw_m3.color = "black";

        // calls the function that displays all the variables in Car.cs
        // bmw_m3.DisplayInfo();
        // bmw_m3.move_forward();

        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2019";
        job1._endYear = "2022";

        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = "2022";
        job2._endYear = "2023";

        job1.DisplayJobInfo();
        job2.DisplayJobInfo();

        Resume resume1 = new Resume();

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.name = "Isaac Huffman";

        Console.WriteLine($"{resume1._jobs[0]._jobTitle}");
        resume1.DisplayResume();
    }
}