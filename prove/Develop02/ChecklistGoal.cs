public class ChecklistGoal : Goals
{
    int _numerator = 0;
    int _denominator;
    int _completedPoints;
    public override string GetGoalType()
    {
        _type = "Checklist Goal";
        return _type;
    }
    public override int RecordEvent()
    {
        if(_completed == true)
        {
            Console.WriteLine("You can not record a goal that has been completed");
            return 0;
        }

        else 
        {
             _numerator += 1;
        
            if (_numerator/_denominator == 1)
            {
                Completed();
                return ReturnCompletedPoints();
            }
            return ReturnPoints();
        }
    }

    public override int GetPoints()
    {
        Console.Write("How many points would you like to earn each time you do it? ");
        _points = int.Parse(Console.ReadLine());
        return _points;
    }

    public override void AddGoal()
    {
        GetName();
        GetDescription();
        GetDenominator();
        GetPoints();
        GetCompletedPoints();
        GetType();
    }

    public override string DisplayGoal()
    {
        if(_completed == false)
        {
            return $"[ ] {_name} ({_description}) -- Currently Completed: {_numerator}/{_denominator}";
        }
        else
        {
           return $"[X] {_name} {_description} -- Currently Completed: {_numerator}/{_denominator}"; 
        }
    }

    public override int GetDenominator()
    {
        Console.Write("How many times would you like to do this goal? ");
        _denominator = int.Parse(Console.ReadLine());
        return _denominator;
    }

    public override int GetNumerator()
    {
        return _numerator;
    }

    public void GetCompletedPoints()
    {
        Console.Write("How many points would you like to earn when it is completed? ");
        _completedPoints = int.Parse(Console.ReadLine());
    }


    public override string ConvertToString()
    {
        return $"{_type};{_completed};{_name};{_description};{_points};{_completedPoints};{_numerator};{_denominator}";
    }

    public int ReturnCompletedPoints()
    {
        return _completedPoints + _points;
    }

    public void SetCompletedPoints(int completedPoints)
    {
        _completedPoints = completedPoints;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }
    
}