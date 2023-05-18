public class Player
{
    private string _name;
    private string _position = "";
    private int _jersey;


    public Player(string name, int jersey)
    {
        _name = name;
        _jersey = jersey;
    }

    public Player(string name, int jersey, string position)
    {
        _name = name;
        _position = position;
        _jersey = jersey;
    }

    public void SetPosition(string position)
    {
        _position = position;
    }

    public void display()
    {
        Console.WriteLine($"Name: {_name}\nJersey: {_jersey}\nPosition: {_position}");
    }



}