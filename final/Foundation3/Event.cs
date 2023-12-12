public class Event
{
    protected string _typeEvent;
    protected string _eTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event (string typeEvent, string eTitle, string description, string date, string time, Address address)
    {
        _typeEvent = typeEvent;
        _eTitle = eTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardMessage ()
    {
        return $"{_eTitle}: {_description} \n{_date} hour: {_time} \nWhere?: {_address.GetAddress()} ";
    }


    public string GetShortDescription ()
    {
        return $"{_typeEvent}: {_eTitle} \nWhen?: {_date}";
    }
}