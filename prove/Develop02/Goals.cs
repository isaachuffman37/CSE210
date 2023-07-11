public abstract class Goals 
{
    protected string  _name;
    protected string _description;
    protected bool _completed = false;
    protected int _totalPoints = 0;
    protected string _type;
    protected int _points;
    


    public Goals ()
    {

    }


    public bool Completed()
    {
        _completed = true;
        return  _completed;
    }

    public abstract int RecordEvent();
    

    public virtual void SetType(string type)
    {
        _type = type;
    }

    public virtual void SetPoints(int points)
    {
        _points = points;
    }


    public virtual void SetDescription(string description)
    {
        _description = description;
    }

    public virtual void SetName(string name)
    {
        _name = name;
    }

    public virtual void SetCompleted(bool completed)
    {
        _completed = completed;
    }

    public abstract void AddGoal();

    public string GetName()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine() ?? String.Empty;
        return _name;
        
    }

    public string GetDescription()
    {
        Console.WriteLine("What is the description of your goal? ");
        _description = Console.ReadLine() ?? String.Empty;
        return _description;
    }

    public abstract int GetPoints();


    public abstract string DisplayGoal();

    public abstract string GetGoalType();

    public virtual int GetDenominator()
    {
        return 0;
    }

    public virtual int GetNumerator()
    {
        return 0;
    }


    public abstract string ConvertToString();
    
    public void DisplayTotalPoints()
    {
        Console.WriteLine($"Your total points are: {_totalPoints}");
    }

    public virtual int ReturnPoints()
    {
        return _points;
    }

}