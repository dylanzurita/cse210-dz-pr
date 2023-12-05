public class Video
{
    private string _title;
    private string _author;
    private int _length;

    public List<Comments> _comment = new List<Comments>();

    public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int CommentsCount()
    {
        return _comment.Count;
    }
    public string DisplayVideoInfo ()
    {
        return $"Song: {_title}. Author: {_author}. Duration: {_length}. Number of Comments: {this.CommentsCount()}";
    }


}