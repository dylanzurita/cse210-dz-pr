public abstract class Activity
{
    protected string _name;
    protected string _date;
    protected int _duration;

    public Activity (string name, string date, int duration)
    {
        _name = name;
        _date = date;
        _duration = duration;
    }

    public virtual string GetSummary ()
    {
        return $"{_date} ; {_name}";
    }

    public abstract double GetDistance ();

    public abstract double GetSpeed ();

    public abstract double GetPace ();
}