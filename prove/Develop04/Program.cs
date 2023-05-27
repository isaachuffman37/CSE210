using System;

class Program
{
    static void Main(string[] args)
    {

        Scripture s = new Scripture();
        s.ConvertStringToWords("Adam fell that men might be; and men are, that they might have joy.");
        s.DisplayScripture();

        bool _continue = true;

        while(_continue == true)
        {
            Console.WriteLine($"\nPress Enter to conitinue or type 'quit' to stop.");
            string _response = Console.ReadLine() ?? String.Empty;
            if (_response == "quit" || s.AllHidden() == true)
            {
                _continue = false;
            }
            else
            {
                s.HideRandomWords();
                s.DisplayScripture();
            }
        }


    }
}