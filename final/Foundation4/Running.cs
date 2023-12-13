public class Running : Activity
{
    protected double _distance;

    public Running (string name, string date, int duration, double distance): base (name, date, duration)
    {
        _distance = distance;
    }

     public override double GetSpeed ()
    {
        return (_distance / _duration) * 60;
    }

    public override double GetDistance ()
    {
        return _distance;
    }

    public override double GetPace ()
    {
        return _duration / _distance;
    }

    public override string GetSummary ()
    {
        return $"{_date} {_name} ({_duration} min) - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}