using System;
using System.Collections.Generic;


public class Comment
{
    private string _commenterName;
    private string _commentText;

    // Constructor
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }
}


public class Video
{
    private string _title;
    private string _author;
    private int _length; // in seconds
    private List<Comment> _comments;

    // Constructor that initializes the attributes and creates an empty list for comments.
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
}

