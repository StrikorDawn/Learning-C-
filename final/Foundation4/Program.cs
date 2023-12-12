using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Cycling c = new Cycling(7,25);
        Running r = new Running(3.2, 55);
        Swimming s = new Swimming(100, 30);
        activities.Add(c);
        activities.Add(r);
        activities.Add(s);

        foreach (var activity in activities)
        {
            activity.GetSummary();
            Console.WriteLine();
        }
    }
}