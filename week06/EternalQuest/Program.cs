/*
    Exceeding Requirements:
    To show creativity, beyond the core requirements, I implemented the following:

    1- User Input Handling:
        -Added input validation throughout the program, for the main menu, submenus, etc.
        -This ensures that the user only selects valid entries and correct inputs (e.g. positive numbers, options from the menu, etc.)
        -This helps to enahance the user experience and avoid errors.

    2- Delete Goal Functionality:
        -I added a DeleteGoal() method inside the GoalManager class. This allows the user remove any goals they no longer want to set or track.
        -This helps the user decide if a goal is no longer needed, allowing the program to be more flexibile and user-friendly. 

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}