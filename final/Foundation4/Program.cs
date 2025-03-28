using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        Running _running = new Running("March 27, 2025", 30, 4);
        _activities.Add(_running);

        Cycling _cycling = new Cycling("March 29, 2025", 20, 10);
        _activities.Add(_cycling);

        Swimming _swimming = new Swimming("April 10, 2025", 10, 5);
        _activities.Add(_swimming);

        foreach (Activity activity in _activities)
        {
            activity.GetSummary();
        }
    }
}