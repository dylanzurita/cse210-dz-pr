public class Comments

{
    private string _name;
    private string _comment;

    public Comments (string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public string DisplayComments ()
    {
        return $"User: {_name} : {_comment}";
    }
}