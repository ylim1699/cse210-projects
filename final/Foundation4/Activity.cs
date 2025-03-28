using System.Runtime.InteropServices;

public class Activity {
    protected string _date;
    protected double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
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
        Console.WriteLine($"{_date} Running ({_length}min)- Distance {GetDistance()} miles, Speed {GetSpeed()}mph, Pace: {GetPace()}min per mile");
    }
}