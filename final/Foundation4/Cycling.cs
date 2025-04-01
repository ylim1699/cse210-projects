public class Cycling : Activity {
    private double _speed;
    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return Math.Round((_speed / 60) * _length, 1);
    }

    public override double GetSpeed()
    {
        return Math.Round(_speed, 1);
    }
    
    public override double GetPace()
    {
        return Math.Round(_length / GetDistance(), 1);
    }

// The distance = (_speed / 60) * _length
// The speed (miles per hour or kilometers per hour) = _speed
// The pace (minutes per mile or minutes per kilometer) =
}