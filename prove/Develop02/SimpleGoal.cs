public class SimpleGoal : Goals 
{
    public override string GetGoalType()
    {
        _type = "Simple Goal";
        return _type;
    }
    public override int RecordEvent()
    {
        Completed();
        return ReturnPoints();
        
    }

    public override int GetPoints()
    {
        Console.Write("How many points would you like this goal to be? ");
        _points = int.Parse(Console.ReadLine());
        return _points;
    }

    public override void AddGoal()
    {
        GetName();
        GetDescription();
        GetPoints();
        GetType();
    }

    public override string DisplayGoal()
    {
        if(_completed == true)
        {
            return $"[X] {_name} ({_description})";
        }
        else
        {
           return $"[ ] {_name} {_description}"; 
        }
    }

    public override string ConvertToString()
    {
        return $"{_type};{_completed};{_name};{_description};{_points}";
    }

    
}