public class ListingActivity : Activity
{
    private string _activityName = "Listing Activity";
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private int _userTime;
    public ListingActivity()
    {
                
    }

    public void Start()
    {
        _userTime = StartActivity(_activityName, _description);
        Console.WriteLine();
        
        DisplayEndPrompt();    
    }
    // public void AnswerQuestion()
    // {

    // }

    // public void DisplayTotalResponses()
    // {
        
    // }
}