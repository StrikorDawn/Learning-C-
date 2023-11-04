public class BreathingActivity : Activity
{
    private string _activityName = "Breathing Activity";
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    private int _userTime;
    private string _breathIn;
    private string _breathOut;
    
    public BreathingActivity()
    {
        _breathIn = "Breath In...";
        _breathOut = "Breath Out...";
    }
    public void Start()
    {
        _userTime = StartActivity(_activityName, _description);
        Console.WriteLine();
        BreathDirection(_userTime);
        DisplayEndPrompt();
    }


    public void BreathDirection(int time)
    {
        bool _completedBreath = true;
        DateTime _start = CurrentTime();
        DateTime _end = SetDelay(_start, time);
        while(_start <= _end)
        {
            if (_completedBreath)
            {
                Console.Write($"{_breathIn}");
                _completedBreath = false;
            }
            else
            {
                Console.Write($"{_breathOut}");
                _completedBreath = true;

            }
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("\n");
            if (_completedBreath)
            {
                _start = CurrentTime();
            }
        }
    }

    
}