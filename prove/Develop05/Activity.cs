public class Activity 
{
    protected int _duration;
    string _activityName;
    string _explanation;

    public Activity(string name, string explanation)
    {
        _activityName = name;
        _explanation = explanation;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}!");
        Console.WriteLine();
        Console.WriteLine($"{_explanation}");
        Console.WriteLine();
        Console.Write($"How long do you want to do this activity? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        
    }


    public void PauseSpinner(int times)
    {
        for (int i = 0; i <times; i++){
        Console.Write(" /");
        Thread.Sleep(85);
        Console.Write("\b\b");
        Console.Write(" -");
        Thread.Sleep(85);
        Console.Write("\b\b");
        Console.Write(" |");
        Thread.Sleep(85);
        Console.Write("\b\b");
        Console.Write(" /");
        Thread.Sleep(85);
        Console.Write("\b\b");
        Console.Write(" -");
        Thread.Sleep(85);
        Console.Write("\b\b");
        Console.Write(" |");
        Thread.Sleep(85);
        Console.Write("\b\b");
        Console.Write(" \\");
        Console.Write("\b\b");
        }

    }

    public void PauseTimer(int duration)
    {

        for (int i= duration; i > 0; i--)
        {
        Console.Write($" {i}");
        Thread.Sleep(1000);
        Console.Write("\b\b");
        }
        
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        PauseSpinner(4);
        Console.WriteLine("  ");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}!");
        PauseSpinner(4);
        Console.WriteLine("  ");
    }
}