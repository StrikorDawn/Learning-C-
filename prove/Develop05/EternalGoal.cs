public class EternalGoal : Goal
{
    public EternalGoal()
    {
        SetGoalType("Eternal");
    }
    public override void Display(int number)
    {
        Console.WriteLine($"{number}. [E] {_goalName} ({_goalDescription})");
    }
        public override string Format()
    {
        string formated = $"{_goalType}|{_goalName}|{_goalDescription}|{_goalPoints}";
        return formated;
    }
}