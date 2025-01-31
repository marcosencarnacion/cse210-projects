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

    // Public properties to access the comment details.
    public string CommenterName
    {
        get { return _commenterName; }
    }

    public string CommentText
    {
        get { return _commentText; }
    }
}