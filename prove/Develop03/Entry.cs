public class Entry
{

Prompt _prompt = new Prompt();
public string prompt;

public string _date;
public string _text;
public string _location;
public string _emotion;

public Entry()
{
    prompt = _prompt.GetRandomPrompt();
    DateTime theCurrentTime = DateTime.Now;
    _date = theCurrentTime.ToShortDateString();
     
}


}






