using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Thanks for playing! You have finished managing your goals today.");
                    break;
                default:
                    Console.WriteLine("Invalid Entry. Please enter a number between 1 and 6.");
                    break;

            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals are created yet. ");
            return;
        }

        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        string choice;
        do
        {
            Console.Write("Which type of goal would you like to create? ");
            choice = Console.ReadLine();

            if (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("Invalid option. Please select 1, 2, or 3.");
            }
        }

        while (choice != "1" && choice != "2" && choice != "3");

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        int points;
        Console.Write("What is the amount of points associated with this goal? ");
        while (!int.TryParse(Console.ReadLine(), out points) || points < 0)
        {
            Console.Write("Invalid Entry. Please enter a positive number of points: ");
        }

        Goal newGoal = null;
        switch (choice)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                int target;
                Console.Write("How many times does this goal need to be accomplihsed for a bonus? ");
                while (!int.TryParse(Console.ReadLine(), out target) || target <= 0)
                {
                    Console.Write("Please enter a valid positive number for the target: ");
                }

                int bonus;
                Console.Write("What is the bonus for accomplishing it that many times? ");
                while (!int.TryParse(Console.ReadLine(), out bonus) || bonus < 0)

                {
                    Console.WriteLine("Please enter a positive number for the bonus: ");
                }

                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Ivalid option. Please select 1, 2, or 3. ");
                return;

        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal Created!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nWhich goal did you accomplish?");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }

        Console.Write("Enter the number of the goal: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goals.Count)
        {
            Goal selectedGoal = _goals[choice - 1];
            selectedGoal.RecordEvent();

            _score += selectedGoal.GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid entry. Please select a valid goal number.");
        }


    }

    public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines("goals.txt");
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string type = parts[0];
                string[] details = parts[1].Split(",");

                Goal goal = CreateGoalFromString(type, details);
                if (goal != null) _goals.Add(goal);
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }

    private Goal CreateGoalFromString(string type, string[] details)
    {
        string name = details[0];
        string description = details[1];
        int points = int.Parse(details[2]);

        if (type == "SimpleGoal")
        {
            bool isComplete = bool.Parse(details[3]);
            SimpleGoal goal = new SimpleGoal(name, description, points);
            if (isComplete) goal.RecordEvent();
            return goal;
        }
        else if (type == "EternalGoal")
        {
            return new EternalGoal(name, description, points);
        }
        else if (type == "ChecklistGoal")
        {
            int target = int.Parse(details[3]);
            int bonus = int.Parse(details[4]);
            int amountCompleted = int.Parse(details[5]);

            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            goal.SetAmountCompleted(amountCompleted);
            return goal;
        }

        return null;
    }
}