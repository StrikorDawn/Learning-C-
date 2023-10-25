public class VIP : Elevator
{  
    
    public VIP(int passcode, int currentFloor, bool doorClosed, List<int> floors) : base(currentFloor, doorClosed, floors)
    {
        
    }
    public VIP(int passcode, int vipFloors, int currentFloor, bool doorClosed, List<int> floors) : base(currentFloor, doorClosed, floors)
    {
        
    }
}