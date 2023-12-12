public class Lectures : Event
{
    private string _speakerName;
    private int _capacity;

    public Lectures (string typeEvent, string eTitle, string description, string date, string time, Address address, string speakerName, int capacity) :  base( typeEvent, eTitle, description,  date,  time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public string GetLectureDetailedMessage ()
    {
        return $"{_typeEvent}: {_eTitle}, {_description} \nWhen?: {_date} hour:{_time} \nWhere?: {_address.GetAddress()} \nSpeaker: {_speakerName}";
    }
}