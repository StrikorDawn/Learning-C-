using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("532", "State Rd", "Rexburg", "ID", 55555);
        Address a2 = new Address("568", "Moutain St", "Rexburg", "ID", 55555);
        Address a3 = new Address("540", "Steak Way", "Rexburg", "ID", 55555);
        LectureEvent lectureEvent = new LectureEvent("Devotional", "This is a spiritually uplifting event.","1/6/2024","11:30pm", a1, "President Maredith", 1500);
        ReceptionEvent receptionEvent = new ReceptionEvent("Wedding","The marraige of Jayden and Brodey","12/16/2023","12:00pm",a2,"wedding@gmail.com");
        OutdoorEvent outdoorEvent = new OutdoorEvent("Nature Hike","We will be exploring the great Outdoors","5/13/2024","7:45am",a3,"Clear");

        lectureEvent.StandardDetails();
        Console.WriteLine("-------------------------------------");
        lectureEvent.FullDetails();
        Console.WriteLine("-------------------------------------");
        lectureEvent.ShortDescription();
        Console.WriteLine("-------------------------------------");
        receptionEvent.StandardDetails();
        Console.WriteLine("-------------------------------------");
        receptionEvent.FullDetails();
        Console.WriteLine("-------------------------------------");
        receptionEvent.ShortDescription();
        Console.WriteLine("-------------------------------------");
        outdoorEvent.StandardDetails();
        Console.WriteLine("-------------------------------------");
        outdoorEvent.FullDetails();
        Console.WriteLine("-------------------------------------");
        outdoorEvent.ShortDescription();
        Console.WriteLine("-------------------------------------");
    }

}