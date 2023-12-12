public class Outdoor : Event
{
    private string _weather;

    public Outdoor (string typeEvent, string eTitle, string description, string date, string time, Address address, string weather): base ( typeEvent, eTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetOutdoorDetailedMessage ()
    {
        return $"{_typeEvent}: {_eTitle}, {_description} \nWhen?: {_date} hour:{_time} \nWhere?: {_address.GetAddress()} \nHow's weather?: {_weather}";
    } 
}