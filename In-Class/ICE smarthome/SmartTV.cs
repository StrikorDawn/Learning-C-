 public class SmartTV : SmartDevice
 {
     int volume = 25;
     int channel;

     public SmartTV()
     {

     }

     public void Mute()
     {
         volume = 0;
         Console.WriteLine("Muted");
     }
     public void VolumeUp()
     {
         if (volume == 100)
         {
             Console.WriteLine("Max Volume");
         }
         else
         {
             volume += 1;
         }
     }
     public void VolumeDown()
     {
         if (volume == 0)
         {
             Console.WriteLine("Muted");
         }
         else
         {
             volume -= 1;
         }
     }
     public void ChannelUp()
     {
         channel += 1;
     }
     public void ChannelDown()
    {
         channel -= 1;
    }

 }