public class VIP : Elevator
{  
    
    public VIP(int passcode, int currentFloor, bool doorClosed, int numberOfFloors) : base(currentFloor, doorClosed, numberOfFloors)
    {
        
    }
    public VIP(int passcode, int vipFloors, int currentFloor, bool doorClosed, int numberOfFloors) : base(currentFloor, doorClosed, numberOfFloors)
    {
        
    }
}