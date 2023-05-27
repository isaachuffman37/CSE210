public class Word
{
string _word;
bool _shown = true;
string _dashes;

public Word (string word)
{
    _word = word;
}

public string DisplayWord()
{
    if (_shown)
    {
        return $"{_word}";
    }
    else
    {
         _dashes = "";
        
         
        

        foreach( char letter in _word )
        {
            if( Char.IsLetter(letter))
            {
                _dashes += "_";
            }
            else
            {
                _dashes += letter;
            }

            
        }
        return _dashes;

     
    }
    
}

public void HideWord()
{
    _shown = false;
}



}