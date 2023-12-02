public abstract class Goal
{   
    protected string _goalType;
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;
    protected bool _isComplete;

    public virtual void CreateGoal()
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

    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }

    public virtual void Display(int number)
    {     
        
    }

    public virtual string Format(){
        string formated = "";
        return formated;
    }
    
    public virtual void LoadGoal(string[] items)
    {   
        _goalType = items[0];
        _goalName = items[1];
        _goalDescription = items[2];
        _goalPoints = int.Parse(items[3]);
    }

    public virtual int CompleteGoal()
    {
        
    }
}