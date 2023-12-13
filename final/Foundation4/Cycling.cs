public class Cycling : Activity
{
    private double _speed;

    public Cycling (string name, string date, int duration, double speed): base (name, date, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed ()
    {
        return _speed;
    }

    public override double GetDistance ()
    {
        return _speed * (_duration / 60.0);
    }

    public override double GetPace ()
    {
        return 60 / _speed;
    }

    public override string GetSummary ()
    {
        return $"{_date} {_name} ({_duration} min) - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}