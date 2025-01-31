using System;
using System.Collections.Generic;


public class Comment
{
    private string _commentName;
    private string _commentText;
}


public class Video
{
    private string _title;
    private string _author;
    private int _length; // in seconds
    private List<Comment> _comments;
}

