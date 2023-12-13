using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new();

        Running running = new Running ("Running", "12 Dec 2023", 40, 7.3);
        activities.Add(running);

        Cycling cycling = new Cycling ("Cycling", "12 Dec 2023", 20, 25.0);
        activities.Add(cycling);

        Swimming swimming = new Swimming ("Swimming", "12 Dec 2023", 60, 30);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine (activity.GetSummary());
        }
    }
}