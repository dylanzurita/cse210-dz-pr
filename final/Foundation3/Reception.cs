public class Reception: Event
{
    private string _emailRSVP;

    public Reception (string typeEvent, string eTitle, string description, string date, string time, Address address, string emailRSVP): base(typeEvent, eTitle, description, date, time, address)
    {
        _emailRSVP = emailRSVP;
    }

    public string GetReservationDetailedMessage ()
    {
        return $"{_typeEvent}: {_eTitle}, {_description} \nWhen?: {_date} hour:{_time} \nWhere?: {_address.GetAddress()} \nEmail Reservation: {_emailRSVP}";
    } 

}