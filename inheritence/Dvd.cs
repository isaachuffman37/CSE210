public class Dvd : Loanable
{
    string _title;

    public Dvd(string title)
    {
        _title = title;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Title: {_title}");
    }
}