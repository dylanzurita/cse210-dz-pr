public class Customer
{
    private string _name;
    private Address _address;

    public Customer (string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsCustomerInUSA ()
    {
        if (_address.IsInUSA() == "National")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string InfoCustomer ()
    {
        return $"{_name} \n{_address.GetAddressString()}";
    }
}