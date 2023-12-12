public class Swimming : Activity
{
    public Swimming(double laps, float delay)
    {
        GetActivity("Swimming");
        GetDate();
        GetStartTime();
        GetEndTime(delay);
        CalculateTime();
        GetDistance(CalculateDistance(laps));
        GetPace();
        GetSpeed();
    }
    public double CalculateDistance(double laps)
    {
        double distance = laps * 50;
        distance /= 1000;
        distance *= 0.62;
        return Math.Round(distance,2);
    }
}