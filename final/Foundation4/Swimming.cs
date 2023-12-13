public class Swimming : Activity
{
    protected int _laps;

    public Swimming (string name, string date, int duration, int laps): base (name, date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance ()
    {
        return _laps * 50 / 1000.0;
    }

     public override double GetSpeed ()
    {
        double distance = GetDistance();
        return (distance / _duration) * 60;
    }

    public override double GetPace ()
    {
        double distance = GetDistance();
        return _duration / distance;
    }

    public override string GetSummary ()
    {
        return $"{_date} {_name} ({_duration} min) - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}