public class Address
{
    private string _eventPlace;
    private string _city;
    private string _country;

    public Address (string eventPlace, string city, string country)
    {
        _eventPlace = eventPlace;
        _city = city;
        _country = country;
    }

    public string GetAddress ()
    {
        return $"{_eventPlace}, {_city}, {_country}";
    }
}