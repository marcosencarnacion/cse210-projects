using System;
using System.Collections.Generic;


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

    // Behavior: Adds a comment to the video.
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Behavior: Get number of comments.
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Behavior: Return the list of comments.
    public List<Comment> GetComments()
    {
        return _comments;
    }

    // Behavior: Returns a formatted string displaying all comments.
    public string DisplayAllComments()
    {
        if (_comments.Count == 0)
        {
            return "No comments available.";
        }

        string output = "";
        foreach (Comment comment in _comments)
        {
            output += $"Commenter: {comment.CommenterName}\n";
            output += $"Comment: {comment.CommentText}\n";
        }
    }
}

