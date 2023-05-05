// public class Prompt
// {
// List<string> _usedPrompts;
// List<string> _prompts;

// public Prompt()
// {
//     _prompts.Add("How was your day?")
// }
// public string GetRandomPrompt()
// {
//     return "This is a prompt";
// }



// }

public class Quote
{
    private string _author = "";
    private string _quote = "";
    private Source _source;

    public Quote(string person, string quote, Source source)
    {
        _author = person;
        _quote = quote;
        _source = source;

    }

    public bool HasAuthor(string name)
    {
        if (_author.ToUpper().Contains(name.ToUpper()))
        {
            return true;
        }
        return false;
    }

    public string GetQuote()
    {
        return $"\"{_quote}\"\n{_author} - {_source.Stringify()}";
    }
}