using System.IO;
public class Menu
{
    List<Goals> _goals = new List<Goals>();
    string user_response = "0";
    int _totalPoints = 0;
    public void DisplayMenu()
    {
        while(user_response != "6")
        {
            Console.WriteLine($"Your total points are: {_totalPoints}");
            Console.Write("Menu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\nWhich would you like to do? ");
            user_response = Console.ReadLine();
            if(user_response == "1")
            {
                Console.Write("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhich goal would you like to create? ");
                string goal_response = Console.ReadLine();

                if (goal_response == "1")
                {
                    SimpleGoal s = new SimpleGoal();
                    s.AddGoal();
                    _goals.Add(s);
                }
                else if(goal_response == "2")
                {
                    EternalGoal e = new EternalGoal();
                    e.AddGoal();
                    _goals.Add(e);
                }
                else if(goal_response == "3")
                {
                    ChecklistGoal c = new ChecklistGoal();
                    c.AddGoal();
                    _goals.Add(c);
                }
            }

            else if(user_response == "2")
            {
                foreach (Goals goal in _goals)
                {
                    Console.WriteLine(goal.DisplayGoal());
                }
            }

            else if(user_response == "3")
            {
                SaveFile();
            }

            else if(user_response == "4")
            {
                LoadFile();
            }

            else if (user_response == "5")
            {
                int number = 1;

                if (_goals.Count() > 0)
                {
                    foreach(Goals goal in _goals)
                    {
                        
                        Console.Write($"{number}. {goal.DisplayGoal()}\n");
                        number += 1;
                    }
                    Console.Write("Which goal would you like to record? ");
                    int record_number = int.Parse(Console.ReadLine());
                    _totalPoints += _goals[record_number - 1].RecordEvent();
                }
                else
                {
                    Console.WriteLine("There are no goals yet, please create some first.");
                }
            }
        }
    }

    public void SaveFile()
    {
        Console.Write("What would you like the name of the file to be?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Goals goal in _goals)
            {
                outputFile.WriteLine(goal.ConvertToString()); 
            }
        }
    }

    public void LoadFile()
    {
        Console.Write("Which file would you like to load? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(";");

            if(parts[0] == "Simple Goal")
            {
                string type = parts[0];
                bool completed = bool.Parse(parts[1]);
                string name = parts[2];
                string description = parts[3];
                int points = int.Parse(parts[4]);
                SimpleGoal s = new SimpleGoal();
                s.SetType(type);
                s.SetCompleted(completed);
                s.SetName(name);
                s.SetDescription(description);
                s.SetPoints(points);
                if (completed == true)
                {
                    _totalPoints += points;
                }
                _goals.Add(s);
            }

            else if(parts[0] == "Eternal Goal")
            {
                string type = parts[0];
                bool completed = bool.Parse(parts[1]);
                string name = parts[2];
                string description = parts[3];
                int points = int.Parse(parts[4]);
                EternalGoal e = new EternalGoal();
                e.SetType(type);
                e.SetCompleted(completed);
                e.SetName(name);
                e.SetDescription(description);
                e.SetPoints(points);
                if (completed == true)
                {
                    _totalPoints += points;
                }
                _goals.Add(e);
            }

            else if (parts[0] == "Checklist Goal")
            {
                string type = parts[0];
                bool completed = bool.Parse(parts[1]);
                string name = parts[2];
                string description = parts[3];
                int points = int.Parse(parts[4]);
                int completedPoints = int.Parse(parts[5]);
                int numerator = int.Parse(parts[6]);
                int denominator = int.Parse(parts[7]);
                ChecklistGoal c = new ChecklistGoal();
                c.SetType(type);
                c.SetCompleted(completed);
                c.SetName(name);
                c.SetDescription(description);
                c.SetPoints(points);
                c.SetCompletedPoints(completedPoints);
                c.SetNumerator(numerator);
                c.SetDenominator(denominator);

                if (completed == true)
                {
                    _totalPoints += completedPoints + (points * numerator);
                }
                else if (completed != true)
                {
                    _totalPoints += points * numerator;
                }
                _goals.Add(c); 
            }
        }
    }
}