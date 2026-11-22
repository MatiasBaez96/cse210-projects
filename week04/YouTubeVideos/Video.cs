public class Video
{
    private List<Comment> _comments = new();
    private string _title;
    private string _author;
    private int _length;

    public Video(string title, string author, int length)
    {
      _title = title;
      _author = author;
      _length = length;     
    }
    
    public void AddComment(Comment comment)
    {
      _comments.Add(comment);
    }
    private int NumberOfComments()
    {
      return _comments.Count;
    }
    
    public void GetDisplay()
    {
      string display = $"TITLE: {_title}\n AUTHOR: {_author}\n DURATION: {_length}\n";
      Console.WriteLine($"{display}");
      foreach(Comment comment in _comments)
      {
        Console.WriteLine($"{comment.GetDisplayText()}");
      }
      Console.WriteLine($"Number of Comments: {NumberOfComments()})");
      Console.WriteLine("");
     }
}