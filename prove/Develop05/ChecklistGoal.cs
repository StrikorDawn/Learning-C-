
public class ChecklistGoal : Goal
{
    int _bonusPoints;
    int _timesCompleted = 0;
    int _total;
    public ChecklistGoal()
    {
        SetGoalType("Checklist");
    }
    public override void CreateGoal()
    {
        base.CreateGoal();
        Console.WriteLine("How many times dois this goal need to be accomplished for a bonus? ");
        _total = SetInt();
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = SetInt();
    }
    public override void Display(int number)
    {
        if(_timesCompleted >= _total)
        {
             Console.WriteLine($"{number}. [X] {_goalName} ({_goalDescription}) -- Currently completed: {_timesCompleted}/{_total}");
        }
        else
        {
             Console.WriteLine($"{number}. [ ] {_goalName} ({_goalDescription}) -- Currently completed: {_timesCompleted}/{_total}");
        }
    }

    public override string Format()
    {
        string formated = $"{_goalType}|{_goalName}|{_goalDescription}|{_goalPoints}|{_bonusPoints}|{_timesCompleted}|{_total}";
        return formated;
    }
    public override void LoadGoal(string[] items)
    {
        base.LoadGoal(items);
        _bonusPoints = int.Parse(items[4]);
        _timesCompleted = int.Parse(items[5]);
        _total = int.Parse(items[6]);

    }

    public override int GetPoints()
    {
        _timesCompleted += 1;
        if(_timesCompleted == _total)
        {
            Console.WriteLine($"Congratulations! You have earned {_goalPoints +_bonusPoints} points!");
            return _goalPoints + _bonusPoints;
        }
        else
        {
            return base.GetPoints();
        }
    }
}