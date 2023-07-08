public class Times
{
    private string _time;
    bool _isAvailable = true;

    public Times(string time)
    {
        _time = time;
    }

    public reserveTime()
    {
        _isAvailable = false;
    }

    public string GetTime()
    {
        return _time;
    }

    public bool GetAvailable()
    {
        return _isAvailable;
    }

    public string SetTime(string time)
    {
        _time = time;
    }

    public bool SetAvailable(bool available)
    {
        _isAvailable = available;
    }
}