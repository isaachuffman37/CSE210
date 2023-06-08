public class ListingActivity : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _usedPrompts = new List<string>();
    List<string> _responses = new List<string>();
    public ListingActivity(string name, string explanation) : base(name, explanation)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

    }

    public string GetPrompt()
    {
        // var random = new Random();
        // var randomNumber = random.Next(0,_prompts.Count);
        // string randomPrompt = _prompts[randomNumber];
        // return randomPrompt;
        if(_prompts.Count <=0 )
        {
            foreach(string prompt in _usedPrompts)
            {
                _usedPrompts.Remove(prompt);
                _prompts.Add(prompt);
            }
            var random = new Random();
            var randomNumber = random.Next(0,_prompts.Count);
            string randomPrompt = _prompts[randomNumber];
            return randomPrompt;
        }
        var randoms = new Random();
        var randomNumbers = randoms.Next(0,_prompts.Count);
        string randomPrompts = _prompts[randomNumbers];
        return randomPrompts;
    }

    
    public void Display()
    {
        string randomPrompt = GetPrompt();
        Console.WriteLine($"---{randomPrompt}---");
        _prompts.Remove(randomPrompt);
        _usedPrompts.Add(randomPrompt);
    }

    public void TimeLeft()
    {
        // int time = int.Parse(_duration);
        // while(time > 0)
        // {
        //     time--;
        //     return true;
        // }
        // return false;


    }

    public void RunListingActivity()
    {
        DisplayStartMessage();
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        PauseSpinner(4);
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Display();
        Console.Write("You may begin in:");
        PauseTimer(3);
        Console.WriteLine("  ");
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);
        while(currentTime < futureTime)
        {
            Console.Write(">");
            string response = Console.ReadLine() ?? String.Empty;
            currentTime = DateTime.Now;

        }
        DisplayEndMessage();


    }
}