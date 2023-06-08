public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();
    List<string> _usedPrompts = new List<string>();
    List<string> _usedQuestions = new List<string>();

    public ReflectingActivity(string name, string explanation) : base(name, explanation)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public string GetRandomPrompt()
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


    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"---{randomPrompt}---");
        _prompts.Remove(randomPrompt);
        _usedPrompts.Add(randomPrompt);
    }



    public string GetRandomQuestion()
    {
        if(_prompts.Count <=0 )
        {
            foreach(string prompt in _usedQuestions)
            {
                _usedQuestions.Remove(prompt);
                _questions.Add(prompt);
            }
            var random = new Random();
            var randomNumber = random.Next(0,_questions.Count);
            string randomQuestion= _questions[randomNumber];
            return randomQuestion;
        }
        var randoms = new Random();
        var randomNumbers = randoms.Next(0,_questions.Count);
        string randomQuestions = _questions[randomNumbers];
        return randomQuestions;
        
    }

    public void DisplayQuestion()
    {
        string randomQuestion = GetRandomQuestion();
        Console.Write($"{randomQuestion} ");
        _questions.Remove(randomQuestion);
        _usedQuestions.Add(randomQuestion);
    }

    public void RunReflectionActivity()
 {
    DisplayStartMessage();
    Console.WriteLine();
    Console.WriteLine("Get ready...");
    PauseSpinner(4);
    Console.WriteLine("Consider this prompt: ");
    DisplayPrompt();
    Console.WriteLine("When you have something in mind, press Enter to continue.");
    string response = Console.ReadLine() ?? String.Empty;
    if (response == String.Empty)
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        PauseTimer(5);
        Console.WriteLine("  ");
        Console.WriteLine();
        int repeats = _duration/ 10;
        for (int i = 0; i < repeats; i++)
        {
            DisplayQuestion();
            PauseSpinner(20);
            Console.WriteLine("  ");
            Console.WriteLine();
            
        }
    }
    DisplayEndMessage();
 }


}