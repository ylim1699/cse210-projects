using System.Runtime.InteropServices;

public class Activity {
    protected string _date;
    protected double _length;
    protected string _title;

    public Activity(string date, double length, string title)
    {
        _date = date;
        _length = length;
        _title = title;
    }

    public virtual double GetDistance()
    {
        return -1;
    }

    public virtual double GetSpeed()
    {
        return -1;
    }
    
    public virtual double GetPace()
    {
        return -1;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date} ${_title} ({_length}min)- Distance {GetDistance()} miles, Speed {GetSpeed()}mph, Pace: {GetPace()}min per mile");
    }
}