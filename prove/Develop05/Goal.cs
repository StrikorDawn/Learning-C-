public abstract class Goal
{
    string _goalName;
    string _goalDescription;
    int _goalPoints;
    bool _isComplete;

    public void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _goalName = SetString();
        Console.WriteLine("What is a short description of it? ");
        _goalDescription = SetString();
        Console.WriteLine("How many points do you want to have associated with this goal? ");
        _goalPoints = SetInt();
        _isComplete = false;

    }
    public string SetString()
    {

        return Console.ReadLine();
    }
    public int SetInt()
    {
        return int.Parse(Console.ReadLine()); 
    }
    public void Display(int number)
    {     
        if(_isComplete)
        {
             Console.WriteLine($"{number}. [X] {_goalName} ({_goalDescription})");
        }
             Console.WriteLine($"{number}. [ ] {_goalName} ({_goalDescription})");
    }

    public string Format(){
        string formated = $"{_goalName}|{_goalDescription}|{_goalPoints}|{_isComplete}";
        return formated;
    }
}