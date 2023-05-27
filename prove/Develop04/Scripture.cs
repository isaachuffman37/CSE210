public class Scripture
{
    string _text;
    List <Word> _words = new List<Word>();
    List <Word> _hiddenWords = new List<Word>();
    
    Reference _reference = new Reference("2 Nephi", "2", "25", null);


    public void ConvertStringToWords(string texts)
    {
        _text = texts;
        string[] words = texts.Split(" ");
        
        foreach(string item in words)
        {
            Word word = new Word(item);
            _words.Add(word);
        }
    }

    public int GenerateNumber()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_words.Count);
        return randomNumber;
    }

    public Word WordValidator(Word word)
    {

        while (_hiddenWords.Contains(word))
        {
            word = _words[GenerateNumber()];
        }

        return word;
    }

    public void HideRandomWords()
    {

        Word word = _words[GenerateNumber()];
        Word hiddenword = WordValidator(word);
        hiddenword.HideWord();
        _hiddenWords.Add(hiddenword);

    }


    


    public void DisplayScripture()
    {
        Console.WriteLine($"{_reference.Display()}");
        foreach (Word word in _words)
        {
            Console.Write($"{word.DisplayWord()} ");
        }
    }

    public bool AllHidden()
    {
        if (_hiddenWords.Count == _words.Count)
        {
            return true;
        }
        else
        {
            return false; 
        }
    }
}