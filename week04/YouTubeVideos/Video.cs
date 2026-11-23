using System;
using System.Collections.Generic;

public class Video
{
    private List<Comment> _comments = new List<Comment>();
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

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"TITLE: {_title}");
        Console.WriteLine($"AUTHOR: {_author}");
        Console.WriteLine($"LENGTH: {_length} seconds");
        Console.WriteLine($"NUMBER OF COMMENTS: {GetNumberOfComments()}");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetDisplayText());
        }

        Console.WriteLine();
    }
}