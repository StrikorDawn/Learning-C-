
public class SimpleGoal : Goal
{   
    public SimpleGoal()
    {
        SetGoalType("Simple");
    }
    public override void Display(int number)
    {
        if(_isComplete)
        {
             Console.WriteLine($"{number}. [X] {_goalName} ({_goalDescription})");
        }
             Console.WriteLine($"{number}. [ ] {_goalName} ({_goalDescription})");
    }
        public override string Format()
    {
        string formated = $"{_goalType}|{_goalName}|{_goalDescription}|{_goalPoints}|{_isComplete}";
        return formated;
    }
    public override void LoadGoal(string[] items)
    {
        base.LoadGoal(items);
        _isComplete = bool.Parse(items[4]);
    }

}
