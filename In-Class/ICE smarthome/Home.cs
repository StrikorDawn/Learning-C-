public class Home
{
    private string _name;
    private List<Room> _rooms = new List<Room>(){};

    public Home(string name)
    {
        _name = name;
    }

    public void AddRoom(Room room)
    {
        _rooms.Add(room);
    }

    public void ListRooms()
    {
        foreach (Room room in _rooms)
        {
            room.Display();
        }
    }
}