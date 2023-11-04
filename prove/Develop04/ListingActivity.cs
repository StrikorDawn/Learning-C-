public class ListingActivity : Activity
{
    private string _activityName = "Listing Activity";
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private int _userTime;
    List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    List<string> _responses = new List<string>();
    public ListingActivity()
    {
                
    }

    public void Start()
    {
        Random _random = new Random();
        int i = _random.Next(_prompts.Count()-1);
        _userTime = StartActivity(_activityName, _description);
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[i]} ---");
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.WriteLine();
        AnswerQuestion(_userTime);
        Console.WriteLine($"You have succesfully inputed {_responses.Count()} entries for this prompt!");
        DisplayEndPrompt();    
    }
    public void AnswerQuestion(int time)
    {
        DateTime _start = CurrentTime();
        DateTime _end = SetDelay(_start, time);
        while (_start <=_end)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _responses.Add(response);
            _start = CurrentTime();
        }
    }

}