public class Test
{
    private List<string> _animation = new List<string>
    {"|","/","-","\\","|","/","-","\\"};
    
    public Test()
    {
    }

    public DateTime CurrentTime()
    {
        DateTime startTime = DateTime.Now;
        return startTime;
    }
    public DateTime SetDelay(DateTime startTime, double delay)
    {
        DateTime endTime = startTime.AddSeconds(5);
        return endTime;
    }
    public string GetUserString()
    {
        return Console.ReadLine();
    }
    public void DisplayReadyPrompt()
    {
        Console.WriteLine("Get Ready...");

    }
    public void LoadingAnimation(double delay)
    {
        int i = 0;
        DateTime _start = CurrentTime();
        DateTime _delay = SetDelay(_start, delay);
        while(_start <= _delay)
        {
            string s = _animation[i];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");
            _start = CurrentTime();


            i++;
            if(i >= _animation.Count)
            {
                i = 0;
            }
        }
    }




}