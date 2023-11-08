public abstract class SmartDevice
{
    string _name;
    bool _status = false;
    DateTime _startTime;
    DateTime _runTime;
    DateTime _time = new DateTime();
    
    public void TurnOn()
    {
        _status = true;
        _startTime = _time.utcNow;
        Console.WriteLine("Device is now on, starting RunTime.");
        
    }

    public void TurnOff()
    {
        _status = false;
        _runTime = GetRunTime();
        Console.WriteLine($"Device is off. RunTime was: {_runTime}");
    }

    public DateTime GetRunTime()
    {
        return _time.utcNow - _startTime;
    }

    
}