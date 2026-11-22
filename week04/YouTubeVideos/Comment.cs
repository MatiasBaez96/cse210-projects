public class Comment
{   
    private string _name;
    private string _comment;
    public Comment(string name,string comment)
    {
        _name = name;
        _comment = comment;
    }
    public string GetDisplayText()
    {
        string display = $"{_name}:\n {_comment}";
        return display;
    }
}