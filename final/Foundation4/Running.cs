public class Running : Activity {
    private double _distance;

    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

      public override double GetDistance()
    {
        return Math.Round(_distance, 1);
    }

    public override double GetSpeed()
    {
        return Math.Round((_distance / _length) * 60, 1);
    }
    
    public override double GetPace()
    {
        return Math.Round(_length / _distance, 1);
    }

// The distance = _distance
// The speed (miles per hour or kilometers per hour) = ( _distance / _length) * 60
// The pace (minutes per mile or minutes per kilometer) = _length / _distance
}