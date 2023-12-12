public class Running : Activity
{
    public Running(double distance, float delay)
    {
        GetActivity("Running");
        GetDate();
        GetStartTime();
        GetEndTime(delay);
        CalculateTime();
        GetDistance(distance);
        GetPace();
        GetSpeed();
    }
}