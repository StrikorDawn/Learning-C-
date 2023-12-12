using System.Runtime.CompilerServices;

public class Cycling : Activity
{
    public Cycling(double distance, float delay)
    {
        GetActivity("Cycling");
        GetDate();
        GetStartTime();
        GetEndTime(delay);
        CalculateTime();
        GetDistance(distance);
        GetPace();
        GetSpeed();
    }

}