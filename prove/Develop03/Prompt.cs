public class Prompt
{
List<string> _usedPrompts = new List<string>();
List<string> _prompts = new List<string>();

public Prompt()
{
    _prompts.Add("How was my day?");
    _prompts.Add("Who was the most interesting person I interacted with today?");
    _prompts.Add("What was the best part of my day?");
    _prompts.Add("How did I see the hand of the Lord in my life today?");
    _prompts.Add("What was the strongest emotion I felt today?");
    _prompts.Add("If I had one thing I could do over today, what would it be?");
}
public string GetRandomPrompt()
{
    var random = new Random();
    var randomNumber = random.Next(0,_prompts.Count);
    string randomPrompt = _prompts[randomNumber];
    return randomPrompt;
}

public void MoveToUsed(int index)
{
    //this will get rid of prompts to be picked if they are used
    _prompts.Remove(GetRandomPrompt());
    _usedPrompts.Add(GetRandomPrompt());
}

public bool CheckForPrompt()
{
    // checks for if their are prompts in the list
    if (_prompts.Count > 0)
    {
    return true;
    }
    else
    {
        return false;
    }
}

public void ShufflePrompts()
{
    // this will re-enter the prompts to unused if the list is done. 
    if (CheckForPrompt() == false)
    {
        foreach( string prompt in _usedPrompts)
        {
           _usedPrompts.Remove(prompt);
           _prompts.Add(prompt);
        }
    }
}



}