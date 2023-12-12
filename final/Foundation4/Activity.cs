using System.Dynamic;

public abstract class Activity
{
    string _date;
    DateTime _startTime;
    DateTime _endTime;
    int _workoutTime;
    string _activity;
    double _distance;
    double _speed;
    double _pace; 


    public void GetDate()
    {
        _date = DateTime.Now.ToString("dd MMM yyyy");
    }
    public void GetStartTime()
    {
        _startTime = DateTime.Now;
    }
    public void GetEndTime(float delay)
    {
        _endTime = _startTime.AddMinutes(delay);
    }

    public void CalculateTime()
    {
        TimeSpan difference = _endTime.Subtract(_startTime);
        _workoutTime = (int)difference.TotalMinutes;
    }
    public void GetActivity(string activity)
    {
        _activity = activity;
    }
    public virtual void GetDistance(double distance)
    {
        _distance = distance;
    }
    public virtual void GetPace()
    {
        _pace = Math.Round(_workoutTime / _distance, 2);
    }
    public virtual void GetSpeed()
    {
        // (_distance / _workoutTime) * 60;
        _speed = Math.Round(60 / _pace, 2);
    } 
    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} {_activity} ({_workoutTime} min): Distance {_distance} miles, Speed: {_speed} mph, Pace: {_pace} min per mile. ");
    }


}