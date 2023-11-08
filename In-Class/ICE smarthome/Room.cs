public class Room
{
    private string _name;
    private List<SmartDevice> _devices = new List<SmartDevice>();

    public Room (string name)
    {
        _name = name;
    }

    public void AddDevice(SmartDevice device)
    {
        _devices.Add(device);
    }

    public void Display()
    {
        Console.WriteLine(_name);
        for (int i=0; i<_devices.Count;i++)
        {
            Console.WriteLine($"    {_devices[i]}");
        }
    }

}