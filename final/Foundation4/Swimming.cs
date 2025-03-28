public class Swimming : Activity {
    private double _laps;
    public Swimming(string date, double length, double laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return Math.Round(_laps * 50 / 1000, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(GetDistance() / _length, 2);
    }
    
    public override double GetPace()
    {
        return Math.Round(_length / GetDistance(), 2);
    }

// The distance = _laps * 50 / 1000
// The speed (miles per hour or kilometers per hour) = distance / _length
// The pace (minutes per mile or minutes per kilometer) = _length / distance
}