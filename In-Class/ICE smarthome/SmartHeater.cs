class SmartHeater : SmartDevice
{

    double _CurrentTemp = 60.0;
    bool _status;
    string _name;

    SmartHeater(string name, bool status) : base(name)
    {
        _status = status;
        _name = name;
    }

    public void IncreaseTemperature(double amount)
    {
        if (Status)
        {
            _CurrentTemp += amount;
        }
    }

    public void DecreaseTemperature(double amount)
    {
        if (Status)
        {
            _CurrentTemp -= amount;
        }
    }

        public override string ToString()
    {
        string deviceStatus = Status ? "on" : "off";
        return $"{base.ToString()}, Current Temperature: {CurrentTemp}°F, Status: {deviceStatus}, Name: {Name}";
    }
}