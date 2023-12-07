public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address (string street, string city, string state, string country)
    {
        _street = street;
        _city =  city;
        _state = state;
        _country = country;
    }

    public string IsInUSA ()
    {
        if (_country == "USA")
        {
            return "National";
        }
        else 
        {
            return "International";
        }
    }

    public string GetAddressString()
    {
        return $"Country : {_country} \nCity: {_city} \nState: {_state} \nStreet {_street}";
    }
}