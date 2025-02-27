using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // List of prompts for the user to choose from
    public List<string> _prompts = new List<string>
    {
        "What made you smile today?",
        "What is something new you learned today?",
        "Describe a challenge you overcame today.",
        "What are you grateful for today?",
        "What was your favorite moment of the day?"
    };

    // Method to get a random prompt from the list.
    public string GetRandomPrompt()
    {
        Random random = new Random(); // Create new random number generator
        return _prompts[random.Next(_prompts.Count)]; // Return a random prompt from the list
    }
}